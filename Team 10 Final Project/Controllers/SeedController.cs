using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    public class SeedController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedController(AppDbContext db, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _context = db;
            _userManager = um;
            _roleManager = rm;
        }

        public IActionResult Index()
        {
            return Content("Seed controller is wired up, but role/user seed logic has not been implemented yet.");
        }

        public async Task<IActionResult> SeedRoles()
        {
            try
            {
                string[] roles = { "Customer", "Employee", "Manager", "Admin" };

                foreach (string roleName in roles)
                {
                    if (!await _roleManager.RoleExistsAsync(roleName))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }

                return Content("Roles seeded successfully.");
            }
            catch (Exception ex)
            {
                return View("Error", new List<string> { ex.Message, ex.InnerException?.Message ?? "" });
            }
        }

        public IActionResult SeedPeople()
        {
            return Content("User seeding has not been implemented yet.");
        }
    }
}