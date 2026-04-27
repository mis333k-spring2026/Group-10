using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.ViewModels;

namespace Team10FinalProject.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // =========================
        // SONG SEARCH
        // =========================
        [HttpGet]
        public IActionResult SongSearch()
        {
            SongSearchViewModel svm = new SongSearchViewModel();
            PopulateGenres(svm);
            svm.SearchResults = new List<Song>();
            svm.TotalResultsCount = _context.Songs.Count(s => s.Status == true);
            return View(svm);
        }

        [HttpPost]
        public IActionResult SongSearch(SongSearchViewModel svm)
        {
            IQueryable<Song> query = _context.Songs
                .Include(s => s.Artist)
                .Include(s => s.Albums)
                .Include(s => s.Genres)
                .Where(s => s.Status == true);

            svm.TotalResultsCount = query.Count();

            if (!String.IsNullOrWhiteSpace(svm.SearchSongName))
            {
                query = query.Where(s => s.SongName.Contains(svm.SearchSongName));
            }

            if (!String.IsNullOrWhiteSpace(svm.SearchArtistName))
            {
                query = query.Where(s => s.Artist.ArtistName.Contains(svm.SearchArtistName));
            }

            if (!String.IsNullOrWhiteSpace(svm.SearchAlbumName))
            {
                query = query.Where(s => s.Albums.Any(a => a.AlbumName.Contains(svm.SearchAlbumName)));
            }

            if (svm.SelectedGenreIDs != null && svm.SelectedGenreIDs.Count > 0)
            {
                query = query.Where(s => s.Genres.Any(g => svm.SelectedGenreIDs.Contains(g.GenreID)));
            }

            if (svm.RatingValue.HasValue)
            {
                if (svm.RatingValue < 1.0m || svm.RatingValue > 5.0m)
                {
                    ModelState.AddModelError("RatingValue", "Rating must be between 1.0 and 5.0.");

                    PopulateGenres(svm);
                    svm.SearchResults = new List<Song>();
                    return View(svm);
                }

                if (svm.RatingComparison == "GreaterThan")
                {
                    query = query.Where(s => s.AvgRating > svm.RatingValue.Value);
                }
                else if (svm.RatingComparison == "LessThan")
                {
                    query = query.Where(s => s.AvgRating < svm.RatingValue.Value);
                }
            }

            query = svm.SortOption switch
            {
                "SongNameDesc" => query.OrderByDescending(s => s.SongName),
                "ArtistNameAsc" => query.OrderBy(s => s.Artist.ArtistName),
                "ArtistNameDesc" => query.OrderByDescending(s => s.Artist.ArtistName),
                "RatingAsc" => query.OrderBy(s => s.AvgRating),
                "RatingDesc" => query.OrderByDescending(s => s.AvgRating),
                _ => query.OrderBy(s => s.SongName)
            };

            svm.SearchResults = query.ToList();
            PopulateGenres(svm);

            return View(svm);
        }

        // =========================
        // ALBUM SEARCH
        // =========================
        [HttpGet]
        public IActionResult AlbumSearch()
        {
            AlbumSearchViewModel avm = new AlbumSearchViewModel();
            PopulateGenres(avm);
            avm.SearchResults = new List<Album>();
            avm.TotalResultsCount = _context.Albums.Count(a => a.Status == true);
            return View(avm);
        }

        [HttpPost]
        public IActionResult AlbumSearch(AlbumSearchViewModel avm)
        {
            IQueryable<Album> query = _context.Albums
                .Include(a => a.Artists)
                .Where(a => a.Status == true);

            avm.TotalResultsCount = query.Count();

            if (!String.IsNullOrWhiteSpace(avm.SearchAlbumName))
            {
                query = query.Where(a => a.AlbumName.Contains(avm.SearchAlbumName));
            }

            if (!String.IsNullOrWhiteSpace(avm.SearchArtistName))
            {
                query = query.Where(a => a.Artists.Any(ar => ar.ArtistName.Contains(avm.SearchArtistName)));
            }

            if (avm.SelectedGenreIDs != null && avm.SelectedGenreIDs.Count > 0)
            {
                query = query.Where(a => a.Genres.Any(g => avm.SelectedGenreIDs.Contains(g.GenreID)));
            }

            if (avm.RatingValue.HasValue)
            {
                if (avm.RatingValue < 1.0m || avm.RatingValue > 5.0m)
                {
                    ModelState.AddModelError("RatingValue", "Rating must be between 1.0 and 5.0.");

                    PopulateGenres(avm);
                    avm.SearchResults = new List<Album>();
                    return View(avm);
                }

                if (avm.RatingComparison == "GreaterThan")
                {
                    query = query.Where(s => s.AvgRating > avm.RatingValue.Value);
                }
                else if (avm.RatingComparison == "LessThan")
                {
                    query = query.Where(s => s.AvgRating < avm.RatingValue.Value);
                }
            }

            query = avm.SortOption switch
            {
                "AlbumNameDesc" => query.OrderByDescending(a => a.AlbumName),
                "ArtistNameAsc" => query.OrderBy(a => a.Artists.FirstOrDefault().ArtistName),
                "ArtistNameDesc" => query.OrderByDescending(a => a.Artists.FirstOrDefault().ArtistName),
                "RatingAsc" => query.OrderBy(a => a.AvgRating),
                "RatingDesc" => query.OrderByDescending(a => a.AvgRating),
                _ => query.OrderBy(a => a.AlbumName)
            };

            avm.SearchResults = query.ToList();
            PopulateGenres(avm);

            return View(avm);
        }

        // =========================
        // ARTIST SEARCH
        // =========================
        [HttpGet]
        public IActionResult ArtistSearch()
        {
            ArtistSearchViewModel avm = new ArtistSearchViewModel();
            PopulateGenres(avm);
            avm.SearchResults = new List<Artist>();
            avm.TotalResultsCount = _context.Artists.Count();
            return View(avm);
        }

        [HttpPost]
        public IActionResult ArtistSearch(ArtistSearchViewModel avm)
        {
            IQueryable<Artist> query = _context.Artists
                .Include(a => a.Genres)
                .Include(a => a.Songs)
                .Include(a => a.Albums);

            avm.TotalResultsCount = query.Count();

            if (!String.IsNullOrWhiteSpace(avm.SearchArtistName))
            {
                query = query.Where(a => a.ArtistName.Contains(avm.SearchArtistName));
            }

            if (avm.SelectedGenreIDs != null && avm.SelectedGenreIDs.Count > 0)
            {
                query = query.Where(a => a.Genres.Any(g => avm.SelectedGenreIDs.Contains(g.GenreID)));
            }

            if (avm.RatingValue.HasValue)
            {
                if (avm.RatingValue < 1.0m || avm.RatingValue > 5.0m)
                {
                    ModelState.AddModelError("RatingValue", "Rating must be between 1.0 and 5.0.");

                    PopulateGenres(avm);
                    avm.SearchResults = new List<Artist>();
                    return View(avm);
                }

                if (avm.RatingComparison == "GreaterThan")
                {
                    query = query.Where(s => s.AvgRating > avm.RatingValue.Value);
                }
                else if (avm.RatingComparison == "LessThan")
                {
                    query = query.Where(s => s.AvgRating < avm.RatingValue.Value);
                }
            }

            query = avm.SortOption switch
            {
                "ArtistNameDesc" => query.OrderByDescending(a => a.ArtistName),
                "RatingAsc" => query.OrderBy(a => a.AvgRating),
                "RatingDesc" => query.OrderByDescending(a => a.AvgRating),
                _ => query.OrderBy(a => a.ArtistName)
            };

            avm.SearchResults = query.ToList();
            PopulateGenres(avm);

            return View(avm);
        }

        // =========================
        // HELPERS
        // =========================
        private void PopulateGenres(SongSearchViewModel svm)
        {
            var genres = _context.Genres
                .OrderBy(g => g.GenreName)
                .ToList();

            svm.AllGenres = new SelectList(genres, "GenreID", "GenreName");
        }

        private void PopulateGenres(AlbumSearchViewModel avm)
        {
            var genres = _context.Genres
                .OrderBy(g => g.GenreName)
                .ToList();

            avm.AllGenres = new SelectList(genres, "GenreID", "GenreName");
        }

        private void PopulateGenres(ArtistSearchViewModel avm)
        {
            var genres = _context.Genres
                .OrderBy(g => g.GenreName)
                .ToList();

            avm.AllGenres = new SelectList(genres, "GenreID", "GenreName");
        }
    }
}