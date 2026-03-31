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
                .FirstOrDefault(o => o.Customer == user && o.Status == true);

            if (order == null)
            {
                order = new Order
                {
                    // FIXED: was AppUser = user, OrderStatus = "Pending"
                    Customer = user,
                    Status = true,
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
                .FirstOrDefault(o => o.Customer == user && o.Status == true);

            // FIXED: removed .Include(s => s.Album) — Song model has no Album property yet
            // TODO: add Album navigation property to Song model, then restore the include
            Song song = _context.Songs.FirstOrDefault(s => s.SongID == songID);

            // Check for duplicates
            bool exists = order.OrderDetails.Any(od => od.Song.SongID == songID);
            if (exists)
            {
                TempData["Error"] = "Song already in cart!";
                return RedirectToAction("Index");
            }

            // Check for album overlap
            // TODO: restore once Song.Album navigation property is added to Song model
            // bool albumExists = order.OrderDetails.Any(od => od.Song.Album.AlbumID == song.Album.AlbumID);
            // if (albumExists)
            // {
            //     TempData["Error"] = "You already have a song from this album!";
            //     return RedirectToAction("Index");
            // }

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
                .FirstOrDefault(o => o.Customer == user && o.Status == true);

            return View(order);
        }

        // Place order
        [HttpPost]
        public async Task<IActionResult> Checkout(Order orderInput)
        {
            AppUser user = await _userManager.GetUserAsync(User);

            Order order = _context.Orders
                .Include(o => o.OrderDetails)
                .FirstOrDefault(o => o.Customer == user && o.Status == true);

            // Apply promotion
            // TODO: Add PromoCode and DiscountAmount to Order model to re-enable this
            // if (!String.IsNullOrEmpty(orderInput.PromoCode))
            // {
            //     Promotion promo = _context.Promotions.FirstOrDefault(p => p.Code == orderInput.PromoCode);
            //     if (promo != null)
            //     {
            //         order.DiscountAmount = promo.DiscountAmount;
            //     }
            // }

            // finalize order
            order.Status = false;
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