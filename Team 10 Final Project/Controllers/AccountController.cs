using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.ViewModels;
using Team10FinalProject.Utilities;

namespace Team10FinalProject.Controllers
{
    [Authorize]
    //[AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        public AccountController(AppDbContext appDbContext,
                                 UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (!ModelState.IsValid)
            {
                return View(rvm);
            }

            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                Address = rvm.Address,
                ZipCode = rvm.ZipCode,
                City = "",
                State = ""
            };

            AddUserModel aum = new AddUserModel
            {
                User = newUser,
                Password = rvm.Password,
                RoleName = "Customer"
            };

            IdentityResult result = await AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded)
            {
                EmailMessaging.SendAccountCreationEmail(newUser);
                await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, false);
                return RedirectToAction("Index", "Home");
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(rvm);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login(string? returnUrl)
        {
            if (User.Identity?.IsAuthenticated == true)
            {
                return View("Error", new List<string> { "You are already logged in." });
            }

            await _signInManager.SignOutAsync();
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel lvm, string? returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(lvm);
            }

            AppUser user = await _userManager.FindByEmailAsync(lvm.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(lvm);
            }

            if (user.Status == false)
            {
                ModelState.AddModelError("", "This account is disabled.");
                return View(lvm);
            }

            var result = await _signInManager.PasswordSignInAsync(
                lvm.Email, lvm.Password, lvm.RememberMe, false);

            if (result.Succeeded)
            {
                if (!string.IsNullOrWhiteSpace(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(lvm);
        }

        public IActionResult AccessDenied()
        {
            return View("Error", new List<string> { "You are not authorized to access that page." });
        }

        public async Task<IActionResult> Index()
        {
            var userName = User.Identity?.Name;

            if (string.IsNullOrEmpty(userName))
            {
                return View("Error", new List<string> { "User not found." });
            }

            AppUser user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            IndexViewModel ivm = new IndexViewModel
            {
                Email = user.Email,
                HasPassword = true,
                UserID = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                City = user.City,
                State = user.State,
                ZipCode = user.ZipCode,
                PhoneNumber = user.PhoneNumber
            };

            return View(ivm);
        }

        public async Task<IActionResult> Edit()
        {
            var userName = User.Identity?.Name;

            if (string.IsNullOrEmpty(userName))
            {
                return View("Error", new List<string> { "User not found." });
            }

            AppUser user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            IndexViewModel ivm = new IndexViewModel
            {
                Email = user.Email,
                HasPassword = true,
                UserID = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                City = user.City,
                State = user.State,
                ZipCode = user.ZipCode,
                PhoneNumber = user.PhoneNumber
            };

            return View(ivm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IndexViewModel ivm)
        {
            var userName = User.Identity?.Name;

            if (string.IsNullOrEmpty(userName))
            {
                return View("Error", new List<string> { "User not found." });
            }

            AppUser user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            // Update user properties
            user.FirstName = ivm.FirstName;
            user.LastName = ivm.LastName;
            user.Email = ivm.Email;
            user.UserName = ivm.Email; // Keep username in sync with email
            user.PhoneNumber = ivm.PhoneNumber;
            user.Address = ivm.Address;
            user.City = ivm.City;
            user.State = ivm.State;
            user.ZipCode = ivm.ZipCode;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(ivm);
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel cpvm)
        {
            if (!ModelState.IsValid)
            {
                return View(cpvm);
            }

            var userName = User.Identity?.Name;

            if (string.IsNullOrEmpty(userName))
            {
                return View("Error", new List<string> { "User not found." });
            }

            AppUser user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            var result = await _userManager.ChangePasswordAsync(user, cpvm.OldPassword, cpvm.NewPassword);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(cpvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}