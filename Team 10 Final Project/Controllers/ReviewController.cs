using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    public class ReviewController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Create(int songID)
        {
            Review review = new Review { SongID = songID };
            return View(review);
        }

        [HttpPost]
        public IActionResult Create(Review review)
        {
            review.Status = false; 
            _context.Reviews.Add(review);
            _context.SaveChanges();

            return RedirectToAction("Index", "Song");
        }

        // Admin approval
        [Authorize(Roles = "Admin")]
        public IActionResult Approve()
        {
            var pending = _context.Reviews.Where(r => r.Status == false).ToList();
            return View(pending);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ApproveReview(int id)
        {
            Review review = _context.Reviews.Find(id);
            review.Status = true;

            _context.SaveChanges();
            return RedirectToAction("Approve");
        }
    }
}