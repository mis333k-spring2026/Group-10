using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.Utilities;

namespace Team10FinalProject.Controllers
{
    [Authorize(Roles = "Employee,Manager")]
    public class EmployeeOrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public EmployeeOrderController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Step 1: select customer
        [HttpGet]
        public async Task<IActionResult> SelectCustomer()
        {
            var customers = await _userManager.GetUsersInRoleAsync("Customer");
            ViewBag.Customers = customers
                .Where(c => c.Status)
                .OrderBy(c => c.LastName).ThenBy(c => c.FirstName)
                .ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SelectCustomer(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return RedirectToAction("SelectCustomer");

            return RedirectToAction("Cart", new { customerId });
        }

        // Step 2: cart — view + inline search
        public async Task<IActionResult> Cart(string customerId, string? songQuery = null, string? albumQuery = null)
        {
            AppUser? customer = await _userManager.FindByIdAsync(customerId);
            if (customer == null)
                return View("Error", new List<string> { "Customer not found." });

            ViewBag.Customer = customer;
            ViewBag.CustomerId = customerId;
            ViewBag.SongQuery = songQuery;
            ViewBag.AlbumQuery = albumQuery;

            if (!string.IsNullOrWhiteSpace(songQuery))
            {
                ViewBag.SongResults = _context.Songs
                    .Include(s => s.Artist)
                    .Where(s => s.Status == true && s.SongName.Contains(songQuery))
                    .OrderBy(s => s.SongName)
                    .Take(20)
                    .ToList();
            }

            if (!string.IsNullOrWhiteSpace(albumQuery))
            {
                ViewBag.AlbumResults = _context.Albums
                    .Include(a => a.Artists)
                    .Where(a => a.Status == true && a.AlbumName.Contains(albumQuery))
                    .OrderBy(a => a.AlbumName)
                    .Take(20)
                    .ToList();
            }

            Order? order = GetPendingOrder(customerId);
            return View(order);
        }

        // Add song to customer cart
        public async Task<IActionResult> AddSong(string customerId, int songId)
        {
            AppUser? customer = await _userManager.FindByIdAsync(customerId);
            if (customer == null)
                return View("Error", new List<string> { "Customer not found." });

            Song? song = _context.Songs.Include(s => s.Albums).FirstOrDefault(s => s.SongID == songId);
            if (song == null)
                return View("Error", new List<string> { "Song not found." });

            Order order = GetOrCreatePendingOrder(customerId, customer);

            if (order.OrderDetails.Any(od => od.SongID == songId))
            {
                TempData["Error"] = "That song is already in the cart.";
                return RedirectToAction("Cart", new { customerId });
            }

            bool inAlbum = order.OrderDetails
                .Where(od => od.Album != null)
                .Any(od => od.Album!.Songs.Any(s => s.SongID == songId));

            if (inAlbum)
            {
                TempData["Error"] = "That song is already included through an album in the cart.";
                return RedirectToAction("Cart", new { customerId });
            }

            _context.OrderDetails.Add(new OrderDetail
            {
                OrderID = order.OrderID,
                SongID = song.SongID,
                Price = song.Price
            });
            _context.SaveChanges();

            return RedirectToAction("Cart", new { customerId });
        }

        // Add album to customer cart
        public async Task<IActionResult> AddAlbum(string customerId, int albumId)
        {
            AppUser? customer = await _userManager.FindByIdAsync(customerId);
            if (customer == null)
                return View("Error", new List<string> { "Customer not found." });

            Album? album = _context.Albums.Include(a => a.Songs).FirstOrDefault(a => a.AlbumID == albumId);
            if (album == null)
                return View("Error", new List<string> { "Album not found." });

            Order order = GetOrCreatePendingOrder(customerId, customer);

            if (order.OrderDetails.Any(od => od.AlbumID == albumId))
            {
                TempData["Error"] = "That album is already in the cart.";
                return RedirectToAction("Cart", new { customerId });
            }

            var albumSongIds = album.Songs.Select(s => s.SongID).ToList();
            if (order.OrderDetails.Any(od =>
                (od.SongID != null && albumSongIds.Contains(od.SongID.Value)) ||
                (od.Album != null && od.Album.Songs.Any(s => albumSongIds.Contains(s.SongID)))))
            {
                TempData["Error"] = "One or more songs from this album are already in the cart.";
                return RedirectToAction("Cart", new { customerId });
            }

            _context.OrderDetails.Add(new OrderDetail
            {
                OrderID = order.OrderID,
                AlbumID = album.AlbumID,
                Price = album.Price
            });
            _context.SaveChanges();

            return RedirectToAction("Cart", new { customerId });
        }

        // Remove song
        public IActionResult RemoveSong(string customerId, int songId)
        {
            Order? order = GetPendingOrder(customerId);
            if (order != null)
            {
                var detail = _context.OrderDetails.FirstOrDefault(od => od.OrderID == order.OrderID && od.SongID == songId);
                if (detail != null) { _context.OrderDetails.Remove(detail); _context.SaveChanges(); }
            }
            return RedirectToAction("Cart", new { customerId });
        }

        // Remove album
        public IActionResult RemoveAlbum(string customerId, int albumId)
        {
            Order? order = GetPendingOrder(customerId);
            if (order != null)
            {
                var detail = _context.OrderDetails.FirstOrDefault(od => od.OrderID == order.OrderID && od.AlbumID == albumId);
                if (detail != null) { _context.OrderDetails.Remove(detail); _context.SaveChanges(); }
            }
            return RedirectToAction("Cart", new { customerId });
        }

        // Step 3: checkout
        [HttpGet]
        public async Task<IActionResult> Checkout(string customerId)
        {
            AppUser? customer = await _userManager.FindByIdAsync(customerId);
            if (customer == null)
                return View("Error", new List<string> { "Customer not found." });

            Order? order = GetPendingOrder(customerId);
            if (order == null || !order.OrderDetails.Any())
                return View("Error", new List<string> { "The cart is empty. Add items before checking out." });

            ViewBag.Customer = customer;
            ViewBag.CustomerId = customerId;
            ViewBag.Cards = _context.Cards.Where(c => c.CustomerID == customerId && c.Status).ToList();

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(string customerId, int cardId)
        {
            AppUser? customer = await _userManager.FindByIdAsync(customerId);
            if (customer == null)
                return View("Error", new List<string> { "Customer not found." });

            Order? order = GetPendingOrder(customerId);
            if (order == null || !order.OrderDetails.Any())
                return View("Error", new List<string> { "The cart is empty." });

            Card? card = _context.Cards.FirstOrDefault(c => c.CardID == cardId && c.CustomerID == customerId && c.Status);
            if (card == null)
            {
                ViewBag.Customer = customer;
                ViewBag.CustomerId = customerId;
                ViewBag.Cards = _context.Cards.Where(c => c.CustomerID == customerId && c.Status).ToList();
                ModelState.AddModelError("", "Please select a valid card on file for this customer.");
                return View(order);
            }

            order.CardID = card.CardID;
            order.Card = card;
            order.Status = false;
            order.IsRefunded = false;
            order.OrderDate = DateTime.Now;
            order.OrderNumber = GetNextOrderNumber();
            _context.SaveChanges();

            try
            {
                var emailOrder = _context.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.OrderDetails).ThenInclude(od => od.Song)
                    .Include(o => o.OrderDetails).ThenInclude(od => od.Album)
                    .FirstOrDefault(o => o.OrderID == order.OrderID);

                if (emailOrder != null)
                {
                    string refundLink = Url.Action("Refund", "Order", new { id = emailOrder.OrderID }, Request.Scheme)!;
                    EmailMessaging.SendOrderConfirmationEmail(emailOrder, refundLink, "Pop", "Taylor Swift");
                }
            }
            catch { }

            return RedirectToAction("Confirmation", new { customerId, orderId = order.OrderID });
        }

        // Step 4: confirmation
        public async Task<IActionResult> Confirmation(string customerId, int orderId)
        {
            AppUser? customer = await _userManager.FindByIdAsync(customerId);
            ViewBag.Customer = customer;
            ViewBag.OrderId = orderId;
            return View();
        }

        // Helpers
        private Order GetOrCreatePendingOrder(string customerId, AppUser customer)
        {
            Order? order = GetPendingOrder(customerId);
            if (order == null)
            {
                order = new Order
                {
                    CustomerID = customerId,
                    Customer = customer,
                    Status = true,
                    IsRefunded = false,
                    OrderDate = DateTime.Now,
                    OrderNumber = 0
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
                order = GetPendingOrder(customerId)!;
            }
            return order;
        }

        private Order? GetPendingOrder(string customerId)
        {
            return _context.Orders
                .Include(o => o.OrderDetails).ThenInclude(od => od.Song).ThenInclude(s => s!.Artist)
                .Include(o => o.OrderDetails).ThenInclude(od => od.Album).ThenInclude(a => a!.Artists)
                .Include(o => o.OrderDetails).ThenInclude(od => od.Album).ThenInclude(a => a!.Songs)
                .FirstOrDefault(o => o.CustomerID == customerId && o.Status == true);
        }

        private int GetNextOrderNumber()
        {
            int? max = _context.Orders.Where(o => o.Status == false).Select(o => (int?)o.OrderNumber).Max();
            return (max == null || max < 212000) ? 212000 : max.Value + 1;
        }
    }
}
