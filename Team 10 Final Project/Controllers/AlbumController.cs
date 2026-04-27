using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.ViewModels;

namespace Team10FinalProject.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AlbumController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: /Album
        public IActionResult Index()
        {
            var albums = _context.Albums
                .Include(a => a.Artists)
                .Where(a => a.Status == true)
                .ToList();

            return View(albums);
        }

        // GET: /Album/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var album = _context.Albums
                .Include(a => a.Artists)
                .Include(a => a.Songs).ThenInclude(s => s.Artist)
                .Include(a => a.Genres)
                .Include(a => a.Reviews)
                .FirstOrDefault(a => a.AlbumID == id);

            if (album == null)
                return View("Error", new List<string> { "Album not found." });

            // Reviews with customer info
            var reviews = _context.Reviews
                .Include(r => r.Reviewer)
                .Where(r => r.AlbumID == id && r.IsApproved == true)
                .ToList();

            bool canAddToCart   = false;
            bool alreadyInCart  = false;
            bool canReview      = false;

            if (User.Identity != null && User.Identity.IsAuthenticated
                && !User.IsInRole("Manager") && !User.IsInRole("Employee") && !User.IsInRole("Admin"))
            {
                var user = await _userManager.GetUserAsync(User);

                // Already in active (non-refunded) cart?
                alreadyInCart = _context.OrderDetails
                    .Include(od => od.Order)
                    .Any(od => od.AlbumID == id
                            && od.Order.CustomerID == user.Id
                            && od.Order.IsRefunded == false
                            && od.Order.Status == true);

                // Has the customer purchased it (completed order)?
                bool hasPurchased = _context.OrderDetails
                    .Include(od => od.Order)
                    .Any(od => od.AlbumID == id
                            && od.Order.CustomerID == user.Id
                            && od.Order.IsRefunded == false
                            && od.Order.Status == false); // false = completed

                canAddToCart = !alreadyInCart && !hasPurchased;
                canReview    = hasPurchased;
            }

            // Check for active promotion
            var promotion = _context.Promotions
                .FirstOrDefault(p => p.AlbumID == id
                                && p.PromotionStatus == true);

            bool    isDiscounted  = promotion != null;
            decimal currentPrice  = isDiscounted
                ? album.Price - (promotion.DiscountAmount ?? 0)
                : album.Price;
            decimal? originalPrice = isDiscounted ? album.Price : null;

            decimal avgRating = reviews.Any()
            ? reviews.Average(r => (decimal)r.Rating)
            : 0m;

            var vm = new AlbumDetailsViewModel
            {
                Album         = album,
                Reviews       = reviews,
                CurrentPrice  = currentPrice,
                OriginalPrice = originalPrice,
                IsDiscounted  = isDiscounted,
                CanAddToCart  = canAddToCart,
                AlreadyInCart = alreadyInCart,
                CanReview     = canReview,
                AverageRating = avgRating
            };

            return View(vm);
        }

        // GET: /Album/Create
        [Authorize(Roles = "Admin,Manager")]
        public IActionResult Create()
        {
            ViewBag.AllArtists = new MultiSelectList(_context.Artists.OrderBy(a => a.ArtistName), "ArtistID", "ArtistName");

            // Pass all songs as JSON so JS can filter by artist client-side
            var songsJson = _context.Songs
                .Select(s => new { songID = s.SongID, songName = s.SongName, artistID = s.ArtistID })
                .ToList();
            ViewBag.SongsJson = JsonSerializer.Serialize(songsJson);

            return View();
        }

        // POST: /Album/Create
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Album album, int[] selectedArtists, int[] selectedSongs)
        {
            ModelState.Remove("Artists");
            ModelState.Remove("Genres");
            ModelState.Remove("Songs");
            ModelState.Remove("Reviews");

            if (!ModelState.IsValid)
            {
                ViewBag.AllArtists = new MultiSelectList(_context.Artists.OrderBy(a => a.ArtistName), "ArtistID", "ArtistName", selectedArtists);
                var songsJson = _context.Songs
                    .Select(s => new { songID = s.SongID, songName = s.SongName, artistID = s.ArtistID })
                    .ToList();
                ViewBag.SongsJson = JsonSerializer.Serialize(songsJson);
                return View(album);
            }

            album.AvgRating = 0;
            album.Status    = true;

            if (selectedArtists != null && selectedArtists.Length > 0)
            {
                album.Artists = _context.Artists
                    .Where(a => selectedArtists.Contains(a.ArtistID))
                    .ToList();
            }

            if (selectedSongs != null && selectedSongs.Length > 0)
            {
                album.Songs = _context.Songs
                    .Where(s => selectedSongs.Contains(s.SongID))
                    .ToList();
            }

            _context.Albums.Add(album);
            _context.SaveChanges();

            return RedirectToAction("Details", new { id = album.AlbumID });
        }

        // GET: /Album/Edit/5
        [Authorize(Roles = "Admin,Manager")]
        public IActionResult Edit(int id)
        {
            var album = _context.Albums
                .Include(a => a.Artists)
                .Include(a => a.Songs)
                .Include(a => a.Genres)
                .FirstOrDefault(a => a.AlbumID == id);

            if (album == null)
                return View("Error", new List<string> { "Album not found." });

            ViewBag.AllArtists = new MultiSelectList(
                _context.Artists.OrderBy(a => a.ArtistName), "ArtistID", "ArtistName");

            var songsJson = _context.Songs
                .Select(s => new { songID = s.SongID, songName = s.SongName, artistID = s.ArtistID })
                .ToList();
            ViewBag.SongsJson = JsonSerializer.Serialize(songsJson);

            // Tell the view which artists/songs are currently selected
            ViewBag.CurrentArtistIds = JsonSerializer.Serialize(album.Artists.Select(a => a.ArtistID).ToList());
            ViewBag.CurrentSongIds   = JsonSerializer.Serialize(album.Songs.Select(s => s.SongID).ToList());

            return View(album);
        }

        // POST: /Album/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Album album, int[] selectedArtists, int[] selectedSongs)
        {
            if (id != album.AlbumID)
                return NotFound();

            ModelState.Remove("Artists");
            ModelState.Remove("Genres");
            ModelState.Remove("Songs");
            ModelState.Remove("Reviews");

            if (!ModelState.IsValid)
            {
                ViewBag.AllArtists = new MultiSelectList(
                    _context.Artists.OrderBy(a => a.ArtistName), "ArtistID", "ArtistName", selectedArtists);
                var songsJsonErr = _context.Songs
                    .Select(s => new { songID = s.SongID, songName = s.SongName, artistID = s.ArtistID })
                    .ToList();
                ViewBag.SongsJson        = JsonSerializer.Serialize(songsJsonErr);
                ViewBag.CurrentArtistIds = JsonSerializer.Serialize(selectedArtists);
                ViewBag.CurrentSongIds   = JsonSerializer.Serialize(selectedSongs);
                return View(album);
            }

            var dbAlbum = _context.Albums
                .Include(a => a.Artists)
                .Include(a => a.Songs)
                .FirstOrDefault(a => a.AlbumID == id);

            if (dbAlbum == null)
                return View("Error", new List<string> { "Album not found." });

            // Update editable fields only (AvgRating is auto-generated, don't touch it)
            dbAlbum.AlbumName  = album.AlbumName;
            dbAlbum.AlbumCover = album.AlbumCover;
            dbAlbum.Price      = album.Price;
            dbAlbum.Status     = album.Status;

            dbAlbum.Artists.Clear();
            if (selectedArtists != null && selectedArtists.Length > 0)
            {
                dbAlbum.Artists = _context.Artists
                    .Where(a => selectedArtists.Contains(a.ArtistID))
                    .ToList();
            }

            dbAlbum.Songs.Clear();
            if (selectedSongs != null && selectedSongs.Length > 0)
            {
                dbAlbum.Songs = _context.Songs
                    .Where(s => selectedSongs.Contains(s.SongID))
                    .ToList();
            }

            _context.Update(dbAlbum);
            _context.SaveChanges();

            return RedirectToAction("Details", new { id = dbAlbum.AlbumID });
        }
    }
}
