using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;

namespace Team10FinalProject.Controllers
{
    public class SongController : Controller
    {
        private readonly AppDbContext _context;

        public SongController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var songs = _context.Songs
                .Include(s => s.Artist)
                .ToList();

            return View(songs);
        }

        public IActionResult Details(int id)
        {
            var song = _context.Songs
                .Include(s => s.Artist)
                .Include(s => s.Albums)
                .Include(s => s.Genres)
                .FirstOrDefault(s => s.SongID == id);

            if (song == null)
            {
                return View("Error", new List<string> { "Song not found." });
            }

            ViewBag.Reviews = _context.Reviews
                .Include(r => r.Reviewer)
                .Where(r => r.SongID == id && r.Status == true)
                .ToList();

            return View(song);
        }
    }
}