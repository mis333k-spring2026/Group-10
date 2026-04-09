using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;

namespace Team10FinalProject.Controllers
{
    public class ArtistController : Controller
    {
        private readonly AppDbContext _context;

        public ArtistController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Artists.ToList());
        }

        public IActionResult Details(int id)
        {
            var artist = _context.Artists
                .Include(a => a.Songs)
                .Include(a => a.Albums)
                .Include(a => a.Genres)
                .FirstOrDefault(a => a.ArtistID == id);

            if (artist == null)
            {
                return View("Error", new List<string> { "Artist not found." });
            }

            return View(artist);
        }
    }
}