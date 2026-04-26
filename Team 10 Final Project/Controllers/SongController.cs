using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        // =========================
        // CREATE SONG (STAFF ONLY)
        // =========================

        [Authorize(Roles = "Admin,Employee,Manager")]
        public IActionResult Create()
        {
            ViewBag.AllArtists = new SelectList(_context.Artists, "ArtistID", "ArtistName");
            return View();
        }


        [HttpPost]
        [Authorize(Roles = "Admin,Employee,Manager")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Song song)
        {
            ModelState.Remove("Artist");
            ModelState.Remove("Albums");
            ModelState.Remove("Genres");
            ModelState.Remove("Reviews");

            if (!ModelState.IsValid)
            {
                ViewBag.AllArtists = new SelectList(_context.Artists, "ArtistID", "ArtistName", song.ArtistID);
                return View(song);
            }

            song.AvgRating = 0;

            _context.Songs.Add(song);
            _context.SaveChanges();

            return RedirectToAction("Index", "Song");
        }
    }
}