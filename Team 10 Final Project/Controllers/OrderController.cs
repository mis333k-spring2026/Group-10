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

        // GET: Order (Cart)
        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.GetUserAsync(User);

            Order order = _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Song)
                .FirstOrDefault(o => o.AppUser == user && o.OrderStatus == "Pending");

            if (order == null)
            {
                order = new Order
                {
                    AppUser = user,
                    OrderStatus = "Pending",
                    OrderDate = DateTime.Now,
                    OrderDetails = new List<OrderDetail>()
                };

                _context.Orders.Add(order);
                _context.SaveChanges();
            }

            return View(order);
        }

        // Add song to cart
        public async Task<IActionResult> AddSong(int songID)
        {
            AppUser user = await _userManager.GetUserAsync(User);

            Order order = _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Song)
                .FirstOrDefault(o => o.AppUser == user && o.OrderStatus == "Pending");

            Song song = _context.Songs.Include(s => s.Album).FirstOrDefault(s => s.SongID == songID);

            // Check for duplicates
            bool exists = order.OrderDetails.Any(od => od.Song.SongID == songID);
            if (exists)
            {
                TempData["Error"] = "Song already in cart!";
                return RedirectToAction("Index");
            }

            // Check for album overlap
            bool albumExists = order.OrderDetails.Any(od => od.Song.Album.AlbumID == song.Album.AlbumID);
            if (albumExists)
            {
                TempData["Error"] = "You already have a song from this album!";
                return RedirectToAction("Index");
            }

            OrderDetail od = new OrderDetail
            {
                Song = song,
                Price = song.Price
            };

            order.OrderDetails.Add(od);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // Checkout Page
        public async Task<IActionResult> Checkout()
        {
            AppUser user = await _userManager.GetUserAsync(User);

            Order order = _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefault(o => o.AppUser == user && o.OrderStatus == "Pending");

            return View(order);
        }

        // Place order
        [HttpPost]
        public async Task<IActionResult> Checkout(Order orderInput)
        {
            AppUser user = await _userManager.GetUserAsync(User);

            Order order = _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefault(o => o.AppUser == user && o.OrderStatus == "Pending");

            // Apply promotion
            if (!String.IsNullOrEmpty(orderInput.PromoCode))
            {
                Promotion promo = _context.Promotions.FirstOrDefault(p => p.Code == orderInput.PromoCode);

                if (promo != null)
                {
                    order.DiscountAmount = promo.DiscountAmount;
                }
            }

            // finalize order
            order.OrderStatus = "Completed";
            order.OrderDate = DateTime.Now;

            _context.SaveChanges();

            // check method created EmailMessaging confirmation
            EmailMessaging.SendOrderConfirmation(user.Email, order);

            return RedirectToAction("Confirmation");
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}