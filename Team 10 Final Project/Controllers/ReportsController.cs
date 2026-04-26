using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.ViewModels;

namespace Team10FinalProject.Controllers
{
    [Authorize(Roles = "Manager")]
    public class ReportsController : Controller
    {
        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Reports
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Reports/AllSongsSold
        public IActionResult AllSongsSold()
        {
            // Only individual song line items (AlbumID is null = direct song purchase, not part of album order)
            var results = _context.OrderDetails
                .Include(od => od.Song)
                    .ThenInclude(s => s.Artist)
                .Include(od => od.Order)
                .Where(od => od.SongID != null
                          && od.AlbumID == null
                          && od.Order.IsRefunded == false)
                .GroupBy(od => new { od.Song.SongID, od.Song.SongName, od.Song.Artist.ArtistName })
                .Select(g => new SongSalesViewModel
                {
                    SongTitle     = g.Key.SongName,
                    ArtistName    = g.Key.ArtistName,
                    PurchaseCount = g.Count(),
                    Revenue       = g.Sum(od => od.Price)
                })
                .OrderByDescending(x => x.Revenue)
                .ToList();

            ViewBag.RecordCount = results.Count;
            return View(results);
        }

        // GET: /Reports/AllAlbumsSold
        public IActionResult AllAlbumsSold()
        {
            // Pull into memory first because Albums->Artists is many-to-many (can't project in SQL)
            var rawDetails = _context.OrderDetails
                .Include(od => od.Album)
                    .ThenInclude(a => a.Artists)
                .Include(od => od.Order)
                .Where(od => od.AlbumID != null
                          && od.Order.IsRefunded == false)
                .ToList();

            var results = rawDetails
                .GroupBy(od => new { od.Album.AlbumID, od.Album.AlbumName })
                .Select(g => new AlbumSalesViewModel
                {
                    AlbumTitle    = g.Key.AlbumName,
                    ArtistName    = g.First().Album.Artists
                                        .Select(a => a.ArtistName)
                                        .FirstOrDefault() ?? "Unknown",
                    PurchaseCount = g.Count(),
                    Revenue       = g.Sum(od => od.Price)
                })
                .OrderByDescending(x => x.Revenue)
                .ToList();

            ViewBag.RecordCount = results.Count;
            return View(results);
        }

        // GET: /Reports/TopSellingBands
        public IActionResult TopSellingBands()
        {
            // Load all non-refunded song line items (direct purchases only)
            var songDetails = _context.OrderDetails
                .Include(od => od.Song)
                    .ThenInclude(s => s.Artist)
                .Include(od => od.Order)
                .Where(od => od.SongID != null
                          && od.AlbumID == null
                          && od.Order.IsRefunded == false)
                .ToList();

            // Load all non-refunded album line items
            var albumDetails = _context.OrderDetails
                .Include(od => od.Album)
                    .ThenInclude(a => a.Artists)
                .Include(od => od.Order)
                .Where(od => od.AlbumID != null
                          && od.Order.IsRefunded == false)
                .ToList();

            // All genres with their associated artists
            var allGenres = _context.Genres
                .Include(g => g.Artists)
                .ToList();

            var results = new List<TopSellingBandViewModel>();

            foreach (var genre in allGenres.OrderBy(g => g.GenreName))
            {
                if (!genre.Artists.Any()) continue;

                var bandStats = genre.Artists.Select(artist =>
                {
                    // Songs sold directly for this artist
                    var artistSongSales = songDetails
                        .Where(od => od.Song.ArtistID == artist.ArtistID)
                        .ToList();

                    int songPurchases   = artistSongSales.Count;
                    decimal songRevenue = artistSongSales.Sum(od => od.Price);

                    // Albums sold where this artist is listed
                    var artistAlbumSales = albumDetails
                        .Where(od => od.Album.Artists.Any(a => a.ArtistID == artist.ArtistID))
                        .ToList();

                    var albumBreakdown = artistAlbumSales
                        .GroupBy(od => new { od.Album.AlbumID, od.Album.AlbumName })
                        .Select(g => new AlbumBreakdownViewModel
                        {
                            AlbumTitle     = g.Key.AlbumName,
                            AlbumPurchases = g.Count(),
                            AlbumRevenue   = g.Sum(od => od.Price)
                        })
                        .ToList();

                    decimal totalAlbumRevenue   = albumBreakdown.Sum(a => a.AlbumRevenue);
                    int     totalAlbumPurchases = albumBreakdown.Sum(a => a.AlbumPurchases);
                    decimal totalRevenue        = songRevenue + totalAlbumRevenue;

                    return new TopSellingBandViewModel
                    {
                        GenreName           = genre.GenreName,
                        ArtistName          = artist.ArtistName,
                        SongPurchases       = songPurchases,
                        SongRevenue         = songRevenue,
                        AlbumBreakdown      = albumBreakdown,
                        TotalAlbumPurchases = totalAlbumPurchases,
                        TotalAlbumRevenue   = totalAlbumRevenue,
                        TotalRevenue        = totalRevenue
                    };
                }).ToList();

                // Only the top artist per genre (by total revenue)
                var top = bandStats.OrderByDescending(b => b.TotalRevenue).First();
                results.Add(top);
            }

            ViewBag.RecordCount = results.Count;
            return View(results);
        }
    }
}