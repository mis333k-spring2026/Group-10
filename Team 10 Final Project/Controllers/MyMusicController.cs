using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    [Authorize]
    public class MyMusicController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public MyMusicController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            // TODO: Add null-forgiving operator (!) - change od.Song to od.Song! in Include
            var songs = _context.OrderDetails
                .Include(od => od.Order)
                .Include(od => od.Song)
                    .ThenInclude(s => s.Artist)
                .Include(od => od.Song)
                    .ThenInclude(s => s.Genres)
                .Where(od => od.Order != null &&
                             od.Order.CustomerID == user.Id &&
                             od.Order.Status == false &&
                             od.SongID != null)
                .Select(od => od.Song!)
                .Distinct()
                .ToList();

            return View(songs);
        }
    }
}