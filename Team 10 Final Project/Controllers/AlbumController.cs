using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;

namespace Team10FinalProject.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AppDbContext _context;

        public AlbumController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var albums = _context.Albums
                .Include(a => a.Artists)
                .ToList();

            return View(albums);
        }

        public IActionResult Details(int id)
        {
            var album = _context.Albums
                .Include(a => a.Artists)
                .Include(a => a.Songs)
                    .ThenInclude(s => s.Artist)
                .Include(a => a.Genres)
                .FirstOrDefault(a => a.AlbumID == id);

            if (album == null)
            {
                return View("Error", new List<string> { "Album not found." });
            }

            return View(album);
        }
    }
}