using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

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
            return View(_context.Songs.ToList());
        }

        public IActionResult Details(int id)
        {
            var song = _context.Songs
                .Include(s => s.Album)
                .FirstOrDefault(s => s.SongID == id);

            return View(song);
        }
    }
}