using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Authorize(Roles = "Admin,Employee,Manager")]
        public IActionResult Create()
        {
            ViewBag.AllArtists = new MultiSelectList(_context.Artists, "ArtistID", "ArtistName");
            ViewBag.AllSongs = new MultiSelectList(_context.Songs, "SongID", "SongName");

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Employee,Manager")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Album album, int[] selectedArtists, int[] selectedSongs)
        {
            ModelState.Remove("Artists");
            ModelState.Remove("Genres");
            ModelState.Remove("Songs");
            ModelState.Remove("Reviews");

            if (!ModelState.IsValid)
            {
                ViewBag.AllArtists = new MultiSelectList(_context.Artists, "ArtistID", "ArtistName", selectedArtists);
                ViewBag.AllSongs = new MultiSelectList(_context.Songs, "SongID", "SongName", selectedSongs);

                return View(album);
            }

            album.AvgRating = 0;
            album.Status = true;

            if (selectedArtists != null)
            {
                album.Artists = _context.Artists
                    .Where(a => selectedArtists.Contains(a.ArtistID))
                    .ToList();
            }

            if (selectedSongs != null)
            {
                album.Songs = _context.Songs
                    .Where(s => selectedSongs.Contains(s.SongID))
                    .ToList();
            }

            _context.Albums.Add(album);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}