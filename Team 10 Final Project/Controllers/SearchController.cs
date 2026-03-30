using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;

namespace Team10FinalProject.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString)
        {
            var songs = _context.Songs
                .Include(s => s.Artist)
                .Include(s => s.Album)
                .AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                songs = songs.Where(s => s.Title.Contains(searchString));
            }

            return View(songs.ToList());
        }
    }
}