using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.Utilities;

namespace Team10FinalProject.Controllers
{
    [Authorize(Roles = "Admin, Manager, Employee")]
    public class ReviewModerationController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewModerationController(AppDbContext context)
        {
            _context = context;
        }

        // Show pending reviews
        public async Task<IActionResult> Index()
        {
            var reviews = await _context.Reviews
                .Include(r => r.Reviewer)
                .Include(r => r.Song)
                .Include(r => r.Album)
                .Include(r => r.Artist)
                .Where(r => r.IsApproved == false && r.IsRejected == false)
                .ToListAsync();

            return View(reviews);
        }

        // Approve review
        public async Task<IActionResult> Approve(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
                return View("Error", new List<string> { "Review not found." });

            review.IsApproved = true;

            _context.Update(review);
            await _context.SaveChangesAsync();

            await RatingHelper.UpdateRatingForReviewAsync(_context, review);

            return RedirectToAction(nameof(Index));
        }

        // GET: edit review text
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var review = await _context.Reviews
                .Include(r => r.Song)
                .Include(r => r.Album)
                .Include(r => r.Artist)
                .FirstOrDefaultAsync(r => r.ReviewID == id);

            if (review == null)
                return View("Error", new List<string> { "Review not found." });

            return View(review);
        }

        // POST: save edited review text only
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, string? reviewText)
        {
            var review = await _context.Reviews.FindAsync(id);

            if (review == null)
                return View("Error", new List<string> { "Review not found." });

            review.ReviewText = reviewText;

            _context.Update(review);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}