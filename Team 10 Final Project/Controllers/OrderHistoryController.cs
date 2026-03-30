using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    [Authorize]
    public class OrderHistoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderHistoryController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.GetUserAsync(User);

            var orders = _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Song)
                .Where(o => o.AppUser == user && o.OrderStatus == "Completed")
                .ToList();

            return View(orders);
        }
    }
}