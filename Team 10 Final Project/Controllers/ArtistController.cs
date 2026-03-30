using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

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
                .FirstOrDefault(a => a.ArtistID == id);

            return View(artist);
        }
    }
}