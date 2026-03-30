using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

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
            return View(_context.Albums.Include(a => a.Artist).ToList());
        }

        public IActionResult Details(int id)
        {
            var album = _context.Albums
                .Include(a => a.Songs)
                .FirstOrDefault(a => a.AlbumID == id);

            return View(album);
        }
    }
}