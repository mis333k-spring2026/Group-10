using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

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
            var pendingReviews = await _context.Reviews
                .Where(r => r.IsApproved == false && r.IsRejected == false)
                .ToListAsync();

            return View(pendingReviews);
        }

        // Approve review
        public async Task<IActionResult> Approve(int id)
        {
            var review = await _context.Reviews.FindAsync(id);

            review.IsApproved = true;

            _context.Update(review);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // Reject review
        public async Task<IActionResult> Reject(int id)
        {
            var review = await _context.Reviews.FindAsync(id);

            review.IsRejected = true;

            _context.Update(review);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}