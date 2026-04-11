using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    public class GenreController : Controller
    {
        private readonly AppDbContext _context;

        public GenreController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Genre
        public async Task<IActionResult> Index()
        {
            var genres = await _context.Genres.ToListAsync();
            return View(genres);
        }

        // GET: Genre/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = await _context.Genres
                .FirstOrDefaultAsync(g => g.GenreID == id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }
    }
}