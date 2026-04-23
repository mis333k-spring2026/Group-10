using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.Utilities;

namespace Team10FinalProject.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // normal logged-in user's cart page
        public async Task<IActionResult> Index()
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = GetPendingOrder(user.Id);

            if (order == null)
            {
                order = new Order
                {
                    CustomerID = user.Id,
                    Customer = user,
                    Status = true,
                    OrderDate = DateTime.Now,
                    OrderNumber = 0
                };

                _context.Orders.Add(order);
                _context.SaveChanges();

                order = GetPendingOrder(user.Id)!;
            }

            return View(order);
        }

        // public seeded-data page
        [AllowAnonymous]
        public async Task<IActionResult> SeedIndex()
        {
            var orders = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Card)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Song)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Album)
                .Where(o => o.Status == false)
                .ToListAsync();

            return View("SeedIndex", orders);
        }

        public async Task<IActionResult> AddSong(int songID)
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = GetPendingOrder(user.Id);
            if (order == null)
            {
                return RedirectToAction("Index");
            }

            Song? song = _context.Songs
                .Include(s => s.Albums)
                .FirstOrDefault(s => s.SongID == songID);

            if (song == null)
            {
                return View("Error", new List<string> { "Song not found." });
            }

            bool duplicateSong = order.OrderDetails.Any(od => od.SongID == songID);
            if (duplicateSong)
            {
                TempData["Error"] = "That song is already in your cart.";
                return RedirectToAction("Index");
            }

            bool duplicateViaAlbum = order.OrderDetails
                .Where(od => od.Album != null)
                .Any(od => od.Album!.Songs.Any(s => s.SongID == songID));

            if (duplicateViaAlbum)
            {
                TempData["Error"] = "That song is already included through an album in your cart.";
                return RedirectToAction("Index");
            }

            OrderDetail od = new OrderDetail
            {
                OrderID = order.OrderID,
                Order = order,
                SongID = song.SongID,
                Song = song,
                Price = song.Price
            };

            _context.OrderDetails.Add(od);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AddAlbum(int albumID)
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = GetPendingOrder(user.Id);
            if (order == null)
            {
                return RedirectToAction("Index");
            }

            Album? album = _context.Albums
                .Include(a => a.Songs)
                .FirstOrDefault(a => a.AlbumID == albumID);

            if (album == null)
            {
                return View("Error", new List<string> { "Album not found." });
            }

            bool duplicateAlbum = order.OrderDetails.Any(od => od.AlbumID == albumID);
            if (duplicateAlbum)
            {
                TempData["Error"] = "That album is already in your cart.";
                return RedirectToAction("Index");
            }

            List<int> albumSongIds = album.Songs.Select(s => s.SongID).ToList();

            bool duplicateSongs = order.OrderDetails.Any(od =>
                (od.SongID != null && albumSongIds.Contains(od.SongID.Value)) ||
                (od.Album != null && od.Album.Songs.Any(s => albumSongIds.Contains(s.SongID))));

            if (duplicateSongs)
            {
                TempData["Error"] = "You already have one or more songs from that album in your cart.";
                return RedirectToAction("Index");
            }

            OrderDetail od = new OrderDetail
            {
                OrderID = order.OrderID,
                Order = order,
                AlbumID = album.AlbumID,
                Album = album,
                Price = album.Price
            };

            _context.OrderDetails.Add(od);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveSong(int songID)
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = GetPendingOrder(user.Id);
            if (order == null)
            {
                return RedirectToAction("Index");
            }

            OrderDetail? detail = _context.OrderDetails
                .FirstOrDefault(od => od.OrderID == order.OrderID && od.SongID == songID);

            if (detail != null)
            {
                _context.OrderDetails.Remove(detail);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveAlbum(int albumID)
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = GetPendingOrder(user.Id);
            if (order == null)
            {
                return RedirectToAction("Index");
            }

            OrderDetail? detail = _context.OrderDetails
                .FirstOrDefault(od => od.OrderID == order.OrderID && od.AlbumID == albumID);

            if (detail != null)
            {
                _context.OrderDetails.Remove(detail);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Checkout()
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = GetPendingOrder(user.Id);
            if (order == null)
            {
                return View("Error", new List<string> { "Order not found." });
            }

            if (order.OrderDetails == null || order.OrderDetails.Count == 0)
            {
                return View("Error", new List<string> { "You must add items to your cart before checkout." });
            }

            ViewBag.Cards = _context.Cards
                .Where(c => c.CustomerID == user.Id && c.Status)
                .ToList();

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(int cardID, bool isGift, string? friendEmail)
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = GetPendingOrder(user.Id);
            if (order == null)
            {
                return View("Error", new List<string> { "Order not found." });
            }

            if (order.OrderDetails == null || order.OrderDetails.Count == 0)
            {
                return View("Error", new List<string> { "You must add items to your cart before checkout." });
            }

            Card? card = _context.Cards.FirstOrDefault(c => c.CardID == cardID && c.CustomerID == user.Id && c.Status);
            if (card == null)
            {
                ViewBag.Cards = _context.Cards
                    .Where(c => c.CustomerID == user.Id && c.Status)
                    .ToList();

                ModelState.AddModelError("", "Please select a valid saved card.");
                return View(order);
            }

            if (isGift)
            {
                if (String.IsNullOrWhiteSpace(friendEmail))
                {
                    ViewBag.Cards = _context.Cards
                        .Where(c => c.CustomerID == user.Id && c.Status)
                        .ToList();

                    ModelState.AddModelError("", "Please enter your friend's email for a gift purchase.");
                    return View(order);
                }

                AppUser? friend = await _userManager.FindByEmailAsync(friendEmail);

                if (friend == null)
                {
                    ViewBag.Cards = _context.Cards
                        .Where(c => c.CustomerID == user.Id && c.Status)
                        .ToList();

                    ModelState.AddModelError("", "No user with that email address was found.");
                    return View(order);
                }

                if (friend.Id == user.Id)
                {
                    ViewBag.Cards = _context.Cards
                        .Where(c => c.CustomerID == user.Id && c.Status)
                        .ToList();

                    ModelState.AddModelError("", "You cannot gift songs to yourself.");
                    return View(order);
                }

                bool containsAlbum = order.OrderDetails.Any(od => od.AlbumID != null);

                if (containsAlbum)
                {
                    ViewBag.Cards = _context.Cards
                        .Where(c => c.CustomerID == user.Id && c.Status)
                        .ToList();

                    ModelState.AddModelError("", "Gift purchases currently support songs only, not albums.");
                    return View(order);
                }

                order.FriendID = friend.Id;
                order.Friend = friend;
            }
            else
            {
                order.FriendID = null;
                order.Friend = null;
            }

            if (HasDuplicateSongs(order))
            {
                return View("Error", new List<string> { "Your cart contains duplicate songs. Remove duplicates before checkout." });
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
                    .Include(o => o.Friend)
                    .Include(o => o.OrderDetails)
                        .ThenInclude(od => od.Song)
                    .Include(o => o.OrderDetails)
                        .ThenInclude(od => od.Album)
                    .FirstOrDefault(o => o.OrderID == order.OrderID);

                if (emailOrder != null)
                {
                    string refundLink = Url.Action("Refund", "Order", new { id = emailOrder.OrderID }, Request.Scheme)!;

                    if (emailOrder.Friend != null)
                    {
                        var recommendation = GetGiftRecommendation(emailOrder);

                        EmailMessaging.SendGiftPurchaserConfirmationEmail(emailOrder, refundLink);

                        EmailMessaging.SendGiftRecipientEmail(
                            emailOrder,
                            recommendation.GenreName,
                            recommendation.ArtistName
                        );
                    }
                    else
                    {
                        EmailMessaging.SendOrderConfirmationEmail(emailOrder, refundLink);
                    }
                }
            }
            catch
            {
            }

            return RedirectToAction("Confirmation", new { id = order.OrderID });
        }

        public IActionResult Confirmation(int? id)
        {
            ViewBag.OrderID = id;
            return View();
        }

        public async Task<IActionResult> Refund(int id)
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Friend)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Song)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Album)
                .FirstOrDefault(o => o.OrderID == id);

            if (order == null)
            {
                return View("Error", new List<string> { "Order not found." });
            }

            if (order.CustomerID != user.Id)
            {
                return View("Error", new List<string> { "You are not authorized to refund this order." });
            }

            if (order.Status == true)
            {
                return View("Error", new List<string> { "This order has not been completed yet." });
            }

            if (order.IsRefunded == true)
            {
                return View("Error", new List<string> { "This order has already been refunded." });
            }

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmRefund(int id)
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Order? order = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Friend)
                .FirstOrDefault(o => o.OrderID == id);

            if (order == null)
            {
                return View("Error", new List<string> { "Order not found." });
            }

            if (order.CustomerID != user.Id)
            {
                return View("Error", new List<string> { "You are not authorized to refund this order." });
            }

            if (order.IsRefunded == true)
            {
                return View("Error", new List<string> { "This order has already been refunded." });
            }

            order.IsRefunded = true;
            _context.SaveChanges();

            if (order.Customer != null && !string.IsNullOrWhiteSpace(order.Customer.Email))
            {
                EmailMessaging.SendRefundEmail(order, order.Customer.Email);
            }

            if (order.Friend != null && !string.IsNullOrWhiteSpace(order.Friend.Email))
            {
                EmailMessaging.SendRefundEmail(order, order.Friend.Email);
            }

            return RedirectToAction("Index", "OrderHistory");
        }

        private (string GenreName, string ArtistName) GetGiftRecommendation(Order order)
        {
            Song? purchasedSong = order.OrderDetails
                .Where(od => od.Song != null)
                .Select(od => od.Song)
                .FirstOrDefault();

            if (purchasedSong == null)
            {
                return ("", "");
            }

            Song? songWithGenres = _context.Songs
                .Include(s => s.Genres)
                .FirstOrDefault(s => s.SongID == purchasedSong.SongID);

            if (songWithGenres == null || songWithGenres.Genres == null || songWithGenres.Genres.Count == 0)
            {
                return ("", "");
            }

            Genre selectedGenre = songWithGenres.Genres.First();

            Artist? recommendedArtist = _context.Artists
                .Include(a => a.Genres)
                .Where(a => a.Genres.Any(g => g.GenreID == selectedGenre.GenreID))
                .OrderByDescending(a => a.AvgRating)
                .FirstOrDefault();

            if (recommendedArtist == null)
            {
                return (selectedGenre.GenreName, "");
            }

            return (selectedGenre.GenreName, recommendedArtist.ArtistName);
        }

        private Order? GetPendingOrder(string userId)
        {
            // TODO: Add null-forgiving operators (!) for od.Song and od.Album in Include statements
            return _context.Orders
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Song)
                        .ThenInclude(s => s.Artist)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Album)
                        .ThenInclude(a => a.Artists)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Album)
                        .ThenInclude(a => a.Songs)
                .FirstOrDefault(o => o.CustomerID == userId && o.Status == true);
        }

        private int GetNextOrderNumber()
        {
            int? maxOrderNumber = _context.Orders
                .Where(o => o.Status == false)
                .Select(o => (int?)o.OrderNumber)
                .Max();

            if (maxOrderNumber == null || maxOrderNumber < 212000)
            {
                return 212000;
            }

            return maxOrderNumber.Value + 1;
        }

        private bool HasDuplicateSongs(Order order)
        {
            List<int> songIds = new List<int>();

            foreach (var detail in order.OrderDetails)
            {
                if (detail.SongID != null)
                {
                    songIds.Add(detail.SongID.Value);
                }

                if (detail.Album != null)
                {
                    songIds.AddRange(detail.Album.Songs.Select(s => s.SongID));
                }
            }

            return songIds.Count != songIds.Distinct().Count();
        }
    }
}