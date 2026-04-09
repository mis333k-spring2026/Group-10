using Microsoft.AspNetCore.Identity;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Team10FinalProject.ViewModels;

namespace Team10FinalProject.Utilities
{
    public static class AddUser
    {
        public static async Task<IdentityResult> AddUserWithRoleAsync(AddUserModel model, UserManager<AppUser> userManager, AppDbContext context)
        {
            // Create the user with the provided password
            var result = await userManager.CreateAsync(model.User, model.Password);

            if (result.Succeeded)
            {
                // Add the user to the specified role
                await userManager.AddToRoleAsync(model.User, model.RoleName);
            }

            return result;
        }
    }
}
