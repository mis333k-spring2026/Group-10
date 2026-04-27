using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.Utilities;
using Team10FinalProject.ViewModels;

namespace Team10FinalProject.Controllers
{
    [Authorize(Roles = "Employee,Manager")]
    public class CustomerManagementController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CustomerManagementController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _userManager.GetUsersInRoleAsync("Customer");
            var sorted = customers.OrderBy(u => u.LastName).ThenBy(u => u.FirstName).ToList();
            return View(sorted);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            AppUser? customer = await _userManager.FindByIdAsync(id);
            if (customer == null)
                return View("Error", new List<string> { "Customer not found." });

            var vm = new EditCustomerByEmployeeViewModel
            {
                UserID = customer.Id,
                Email = customer.Email ?? "",
                OriginalEmail = customer.Email ?? "",
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                City = customer.City ?? "",
                State = customer.State ?? "",
                ZipCode = customer.ZipCode,
                PhoneNumber = customer.PhoneNumber ?? "",
                Status = customer.Status
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, EditCustomerByEmployeeViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            AppUser? customer = await _userManager.FindByIdAsync(id);
            if (customer == null)
                return View("Error", new List<string> { "Customer not found." });

            if (!string.Equals(vm.Email.Trim(), vm.OriginalEmail.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                ModelState.AddModelError("Email", "Email address cannot be changed.");
                return View(vm);
            }

            customer.FirstName = vm.FirstName;
            customer.LastName = vm.LastName;
            customer.Address = vm.Address;
            customer.ZipCode = vm.ZipCode;
            customer.PhoneNumber = vm.PhoneNumber;
            customer.Status = vm.Status;

            var (city, state) = await ZipLookup.LookupAsync(vm.ZipCode);
            customer.City = city;
            customer.State = state;

            var updateResult = await _userManager.UpdateAsync(customer);
            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                    ModelState.AddModelError("", error.Description);
                return View(vm);
            }

            if (!string.IsNullOrWhiteSpace(vm.NewPassword))
            {
                await _userManager.RemovePasswordAsync(customer);
                var pwResult = await _userManager.AddPasswordAsync(customer, vm.NewPassword);
                if (!pwResult.Succeeded)
                {
                    foreach (var error in pwResult.Errors)
                        ModelState.AddModelError("", error.Description);
                    return View(vm);
                }
            }

            return RedirectToAction("Index");
        }
    }
}
