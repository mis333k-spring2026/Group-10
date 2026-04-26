using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.Utilities;

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

        [AllowAnonymous]
        public IActionResult SeedIndex()
        {
            var reviews = _context.Reviews
                .Include(r => r.Song)
                .Include(r => r.Reviewer)
                .ToList();

            return View(reviews);
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

            // Pre-fill with existing review if they already have one
            Review? existingReview = _context.Reviews
                .FirstOrDefault(r => r.SongID == songID && r.ReviewerID == user.Id);

            Review review = existingReview ?? new Review { SongID = songID };
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

            review.ReviewerID = user.Id;
            review.Status = false;

            ModelState.Remove("ReviewerID");
            ModelState.Remove("Reviewer");
            ModelState.Remove("ApproverID");
            ModelState.Remove("Approver");
            ModelState.Remove("Song");
            ModelState.Remove("Album");
            ModelState.Remove("Artist");

            if (!ModelState.IsValid)
            {
                return View(review);
            }

            Review? existingReview = _context.Reviews
                .FirstOrDefault(r => r.SongID == review.SongID && r.ReviewerID == user.Id);

            Review reviewToTrack;  // we'll pass this to the rating helper

            if (existingReview != null)
            {
                existingReview.Rating = review.Rating;
                existingReview.ReviewText = review.ReviewText;
                existingReview.Status = false;  // edits need re-approval
                reviewToTrack = existingReview;
            }
            else
            {
                _context.Reviews.Add(review);
                reviewToTrack = review;
            }

            await _context.SaveChangesAsync();
            await RatingHelper.UpdateRatingForReviewAsync(_context, reviewToTrack);

            return RedirectToAction("Details", "Song", new { id = review.SongID });
        }

        [Authorize(Roles = "Employee,Manager")]
        public IActionResult Approve()
        {
            var pending = _context.Reviews
                .Include(r => r.Song)
                .Include(r => r.Reviewer)
                .Where(r => r.Status == false)
                .ToList();

            return View(pending);
        }

        [Authorize(Roles = "Employee,Manager")]
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

            await _context.SaveChangesAsync();

            // Recalculate the average now that the review is approved
            await RatingHelper.UpdateRatingForReviewAsync(_context, review);

            return RedirectToAction("Approve");
        }

        [Authorize(Roles = "Employee,Manager")]
        public IActionResult EditReviewText(int id)
        {
            Review? review = _context.Reviews
                .Include(r => r.Song)
                .Include(r => r.Album)
                .Include(r => r.Artist)
                .Include(r => r.Reviewer)
                .FirstOrDefault(r => r.ReviewID == id);

            if (review == null)
            {
                return View("Error", new List<string> { "Review not found." });
            }

            return View(review);
        }

        [HttpPost]
        [Authorize(Roles = "Employee,Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditReviewText(int id, string reviewText)
        {
            Review? review = _context.Reviews.Find(id);
            if (review == null)
            {
                return View("Error", new List<string> { "Review not found." });
            }

            // Spec: employees can edit text but NOT the rating
            review.ReviewText = reviewText;

            await _context.SaveChangesAsync();
            // Rating didn't change, but call helper for consistency
            await RatingHelper.UpdateRatingForReviewAsync(_context, review);

            return RedirectToAction("Approve");
        }

        [HttpPost]
        [Authorize(Roles = "Employee,Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteReview(int id)
        {
            Review? review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return View("Error", new List<string> { "Review not found." });
            }

            // Capture IDs before deleting so we can recalculate after
            int? songId = review.SongID;
            int? albumId = review.AlbumID;
            int? artistId = review.ArtistID;

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            // Recalculate the affected entity's average
            if (songId.HasValue)
                await RatingHelper.UpdateSongRatingAsync(_context, songId.Value);
            else if (albumId.HasValue)
                await RatingHelper.UpdateAlbumRatingAsync(_context, albumId.Value);
            else if (artistId.HasValue)
                await RatingHelper.UpdateArtistRatingAsync(_context, artistId.Value);

            return RedirectToAction("Approve");
        }
    }
}