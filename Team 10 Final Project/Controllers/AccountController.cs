#nullable disable warnings

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.ViewModels;
using Team10FinalProject.Utilities;
using System;

namespace Team10FinalProject.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;
        private readonly IEmailSender<AppUser> _emailSender; 

        public AccountController(AppDbContext appDbContext,
                                 UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signIn,
                                 IEmailSender<AppUser> emailSender)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            _emailSender = emailSender;
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
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
                LastName = rvm.LastName
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
                //Send Email - IEmailSender<AppUser> doesn't have a SendAsync method in this version
                // await _emailSender.SendAsync(
                //     newUser.Email,
                //     "Welcome to Longhorn Music Store 🎵",
                //     $"Hello {newUser.FirstName}, your account has been created!"
                // );

                await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, false);

                return RedirectToAction("Index", "Home");
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(rvm);
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string? returnUrl)
        {
            if (User.Identity?.IsAuthenticated == true)
            {
                return View("Error", new string[] { "Access Denied" });
            }

            _signInManager.SignOutAsync();
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel lvm, string? returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(lvm);
            }

            var result = await _signInManager.PasswordSignInAsync(
                lvm.Email, lvm.Password, lvm.RememberMe, false);

            if (result.Succeeded)
            {
                return Redirect(returnUrl ?? "/");
            }

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(lvm);
        }

        public IActionResult AccessDenied()
        {
            return View("Error", new string[] { "Not authorized" });
        }

        public async Task<IActionResult> Index()
        {
            var userName = User.Identity?.Name;
            if (string.IsNullOrEmpty(userName))
            {
                return View("Error", new string[] { "User not found" });
            }

            AppUser user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return View("Error", new string[] { "User not found" });
            }

            IndexViewModel ivm = new IndexViewModel
            {
                Email = user.Email,
                HasPassword = true,
                UserID = user.Id,
                UserName = user.UserName
            };

            return View(ivm);
        }

        // GET
        public IActionResult ChangePassword()
        {
            return View();
        }

        // POST
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
                return View("Error", new string[] { "User not found" });
            }

            AppUser user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return View("Error", new string[] { "User not found" });
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