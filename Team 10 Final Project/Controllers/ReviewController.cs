using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    public class ReviewController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ReviewController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Create(int songID)
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            bool purchasedSong = _context.OrderDetails
                .Include(od => od.Order)
                .Any(od => od.SongID == songID &&
                           od.Order != null &&
                           od.Order.CustomerID == user.Id &&
                           od.Order.Status == false);

            if (!purchasedSong)
            {
                return View("Error", new List<string> { "You may only review songs you have purchased." });
            }

            Review review = new Review { SongID = songID };
            return View(review);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Review review)
        {
            AppUser? user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            if (!ModelState.IsValid)
            {
                return View(review);
            }

            if (review.SongID == null)
            {
                return View("Error", new List<string> { "Review target not found." });
            }

            bool purchasedSong = _context.OrderDetails
                .Include(od => od.Order)
                .Any(od => od.SongID == review.SongID &&
                           od.Order != null &&
                           od.Order.CustomerID == user.Id &&
                           od.Order.Status == false);

            if (!purchasedSong)
            {
                return View("Error", new List<string> { "You may only review songs you have purchased." });
            }

            Review? existingReview = _context.Reviews
                .FirstOrDefault(r => r.SongID == review.SongID && r.ReviewerID == user.Id);

            if (existingReview != null)
            {
                existingReview.Rating = review.Rating;
                existingReview.ReviewText = review.ReviewText;
                existingReview.Status = false;
            }
            else
            {
                review.ReviewerID = user.Id;
                review.Status = false;
                _context.Reviews.Add(review);
            }

            _context.SaveChanges();

            return RedirectToAction("Details", "Song", new { id = review.SongID });
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Approve()
        {
            var pending = _context.Reviews
                .Include(r => r.Song)
                .Include(r => r.Reviewer)
                .Where(r => r.Status == false)
                .ToList();

            return View(pending);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveReview(int id)
        {
            Review? review = _context.Reviews.Find(id);
            if (review == null)
            {
                return View("Error", new List<string> { "Review not found." });
            }

            AppUser? approver = await _userManager.GetUserAsync(User);
            review.Status = true;
            review.ApproverID = approver?.Id;

            _context.SaveChanges();

            return RedirectToAction("Approve");
        }
    }
}