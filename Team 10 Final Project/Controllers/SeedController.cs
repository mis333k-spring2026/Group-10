using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.Seeding; 

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
                string[] roles = { "Customer", "Employee", "Manager" };

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

        public IActionResult SeedArtists()
        {
            try
            {
                ArtistSeeder.SeedAllArtists(_context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public IActionResult SeedPeople()
        {
            return Content("User seeding has not been implemented yet.");
        }

        public IActionResult SeedGenres()
        {
            try
            {
                GenreSeeder.SeedAllGenres(_context);
            }
            catch (Exception ex)
            {
                return View("Error", new List<String> { ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedAlbums()
        {
            try
            {
                AlbumSeeder.SeedAllAlbums(_context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public IActionResult SeedSongs()
        {
            try
            {
                SongSeeder.SeedAllSongs(_context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public async Task<IActionResult> SeedCustomers()
        {
            try
            {
                await CustomerSeeder.SeedAllCustomers(_userManager, _context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public async Task<IActionResult> SeedEmployees()
        {
            try
            {
                await EmployeeSeeder.SeedAllEmployees(_userManager, _context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public async Task<IActionResult> SeedManagers()
        {
            try
            {
                await ManagerSeeder.SeedAllManagers(_userManager, _context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public IActionResult SeedReviews()
        {
            try
            {
                ReviewSeeder.SeedAllReviews(_context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public IActionResult SeedPromotions()
        {
            try
            {
                PromotionSeeder.SeedAllPromotions(_context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public IActionResult SeedCards()
        {
            try
            {
                CardSeeder.SeedAllCards(_context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }

        public IActionResult SeedOrders()
        {
            try
            {
                OrderSeeder.SeedAllOrders(_context);
            }
            catch (Exception ex)
            {
                List<String> errorList = new List<String>();
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            return View("Confirm");
        }
    }
}