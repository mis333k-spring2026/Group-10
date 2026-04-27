using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.ViewModels;

namespace Team10FinalProject.Controllers
{
    public class SongController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public SongController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var songs = _context.Songs
                .Include(s => s.Artist)
                .Include(s => s.Albums)
                .ToList();

            return View(songs);
        }

        public async Task<IActionResult> Details(int id)
        {
            var song = _context.Songs
                .Include(s => s.Artist)
                .Include(s => s.Albums)
                .Include(s => s.Genres)
                .FirstOrDefault(s => s.SongID == id);

            if (song == null)
                return View("Error", new List<string> { "Song not found." });

            var reviews = _context.Reviews
                .Include(r => r.Reviewer)
                .Where(r => r.SongID == id && r.IsApproved == true)
                .ToList();

            bool canAddToCart = false;
            bool alreadyInCart = false;
            bool canReview = false;

            if (User.Identity != null && User.Identity.IsAuthenticated
                && !User.IsInRole("Manager") && !User.IsInRole("Employee") && !User.IsInRole("Admin"))
            {
                var user = await _userManager.GetUserAsync(User);

                alreadyInCart = _context.OrderDetails
                    .Include(od => od.Order)
                    .Any(od => od.SongID == id
                            && od.Order.CustomerID == user.Id
                            && od.Order.IsRefunded == false
                            && od.Order.Status == true);

                bool hasPurchased = _context.OrderDetails
                    .Include(od => od.Order)
                    .Any(od => od.SongID == id
                            && od.Order.CustomerID == user.Id
                            && od.Order.IsRefunded == false
                            && od.Order.Status == false);

                canAddToCart = !alreadyInCart && !hasPurchased;
                canReview = hasPurchased;
            }

            var promotion = _context.Promotions
                .FirstOrDefault(p => p.SongID == id && p.PromotionStatus == true);

            bool isDiscounted = promotion != null;
            decimal currentPrice = isDiscounted ? song.Price - (promotion!.DiscountAmount ?? 0) : song.Price;
            decimal? originalPrice = isDiscounted ? song.Price : null;

            decimal avgRating = reviews.Any() ? reviews.Average(r => (decimal)r.Rating) : 0m;

            var vm = new SongDetailsViewModel
            {
                Song          = song,
                Reviews       = reviews,
                CurrentPrice  = currentPrice,
                OriginalPrice = originalPrice,
                IsDiscounted  = isDiscounted,
                CanAddToCart  = canAddToCart,
                AlreadyInCart = alreadyInCart,
                CanReview     = canReview,
                AverageRating = avgRating
            };

            return View(vm);
        }


        // =========================
        // CREATE SONG (STAFF ONLY)
        // =========================

        [Authorize(Roles = "Admin,Manager")]
        public IActionResult Create()
        {
            ViewBag.AllArtists = new SelectList(_context.Artists, "ArtistID", "ArtistName");
            return View();
        }


        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Song song)
        {
            ModelState.Remove("Artist");
            ModelState.Remove("Albums");
            ModelState.Remove("Genres");
            ModelState.Remove("Reviews");

            if (!ModelState.IsValid)
            {
                ViewBag.AllArtists = new SelectList(_context.Artists, "ArtistID", "ArtistName", song.ArtistID);
                return View(song);
            }

            song.AvgRating = 0;

            _context.Songs.Add(song);
            _context.SaveChanges();

            return RedirectToAction("Index", "Song");
        }
    }
}