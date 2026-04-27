using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var featuredPromotions = _context.Promotions
            .Include(p => p.Song)
                .ThenInclude(s => s.Artist)
            .Include(p => p.Album)
            .Include(p => p.Artist)
            .Where(p => p.PromotionStatus == true
                     && p.PromotionType == "Featured")
            .ToList();

        ViewBag.FeaturedPromotions = featuredPromotions;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}