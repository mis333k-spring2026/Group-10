using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class RoleAdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleAdminController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: /RoleAdmin/
        public async Task<ActionResult> Index()
        {
            List<RoleEditModel> roles = new List<RoleEditModel>();

            foreach (IdentityRole role in _roleManager.Roles)
            {
                List<AppUser> RoleMembers = new List<AppUser>();
                List<AppUser> RoleNonMembers = new List<AppUser>();

                foreach (AppUser user in _userManager.Users)
                {
                    if (await _userManager.IsInRoleAsync(user, role.Name) == true)
                    {
                        RoleMembers.Add(user);
                    }
                    else
                    {
                        RoleNonMembers.Add(user);
                    }
                }

                RoleEditModel rem = new RoleEditModel
                {
                    Role = role,
                    RoleMembers = RoleMembers,
                    RoleNonMembers = RoleNonMembers
                };

                roles.Add(rem);
            }

            return View(roles);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create([Required] string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(name);
        }

        public async Task<ActionResult> Edit(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);

            List<AppUser> RoleMembers = new List<AppUser>();
            List<AppUser> RoleNonMembers = new List<AppUser>();

            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name) == true)
                {
                    RoleMembers.Add(user);
                }
                else
                {
                    RoleNonMembers.Add(user);
                }
            }

            RoleEditModel rem = new RoleEditModel
            {
                Role = role,
                RoleMembers = RoleMembers,
                RoleNonMembers = RoleNonMembers
            };

            return View(rem);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(RoleModificationModel rmm)
        {
            IdentityResult result;

            if (ModelState.IsValid)
            {
                if (rmm.IdsToAdd != null)
                {
                    foreach (string userId in rmm.IdsToAdd)
                    {
                        AppUser user = await _userManager.FindByIdAsync(userId);
                        result = await _userManager.AddToRoleAsync(user, rmm.RoleName);

                        if (result.Succeeded == false)
                        {
                            return View("Error", result.Errors);
                        }
                    }
                }

                if (rmm.IdsToDelete != null)
                {
                    foreach (string userId in rmm.IdsToDelete)
                    {
                        AppUser user = await _userManager.FindByIdAsync(userId);
                        result = await _userManager.RemoveFromRoleAsync(user, rmm.RoleName);

                        if (result.Succeeded == false)
                        {
                            return View("Error", result.Errors);
                        }
                    }
                }

                return RedirectToAction("Index");
            }

            return View("Error", new string[] { "Role Not Found" });
        }

        // NEW: Separate seeded-data pages

        public async Task<IActionResult> Customers()
        {
            List<AppUser> customers = new List<AppUser>();

            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, "Customer"))
                {
                    customers.Add(user);
                }
            }

            return View(customers);
        }

        public async Task<IActionResult> Employees()
        {
            List<AppUser> employees = new List<AppUser>();

            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, "Employee"))
                {
                    employees.Add(user);
                }
            }

            return View(employees);
        }

        public async Task<IActionResult> Managers()
        {
            List<AppUser> managers = new List<AppUser>();

            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, "Manager"))
                {
                    managers.Add(user);
                }
            }

            return View(managers);
        }
    }
}