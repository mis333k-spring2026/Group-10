using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    public class PromotionController : Controller
    {
        private readonly AppDbContext _context;

        public PromotionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Promotion
        public async Task<IActionResult> Index()
        {
            var promotions = await _context.Promotions
                .Include(p => p.Song)
                .Include(p => p.Album)
                .Include(p => p.Artist)
                .ToListAsync();

            return View(promotions);
        }

        // GET: Promotion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promotion = await _context.Promotions
                .Include(p => p.Song)
                .Include(p => p.Album)
                .Include(p => p.Artist)
                .FirstOrDefaultAsync(p => p.PromotionID == id);

            if (promotion == null)
            {
                return NotFound();
            }

            return View(promotion);
        }
    }
}