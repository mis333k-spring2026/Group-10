using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team10FinalProject.Seeding
{

    public static class ManagerSeeder
    {
        public static async Task SeedAllManagers(UserManager<AppUser> userManager, AppDbContext db)
        {
            Int32 intUsersAdded = 0;
            String strEmail = "Begin";


            strEmail = "c.baker@bevotunes.com";

            AppUser manager1 = new AppUser()
            {
                UserName = "c.baker@bevotunes.com",
                Email = "c.baker@bevotunes.com",
                PhoneNumber = "3395325649",
                FirstName = "Christopher",
                LastName = "Baker",
                Address = "1245 Lake Libris Dr.",
                ZipCode = "78613"
            };

            AppUser dbUser1 = await userManager.FindByEmailAsync("c.baker@bevotunes.com");

            if (dbUser1 == null)
            {
                IdentityResult result1 = await userManager.CreateAsync(manager1, "dewey4");

                if (result1.Succeeded == false)
                {
                    String errors1 = "";

                    foreach (IdentityError error in result1.Errors)
                    {
                        errors1 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating manager (c.baker@bevotunes.com): " + errors1);
                }

                dbUser1 = await userManager.FindByEmailAsync("c.baker@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser1, "Manager");
                intUsersAdded += 1;
            }
            else
            {
                dbUser1.UserName = "c.baker@bevotunes.com";
                dbUser1.Email = "c.baker@bevotunes.com";
                dbUser1.PhoneNumber = "3395325649";
                dbUser1.FirstName = "Christopher";
                dbUser1.LastName = "Baker";
                dbUser1.Address = "1245 Lake Libris Dr.";
                dbUser1.ZipCode = "78613";

                await userManager.UpdateAsync(dbUser1);

                if (await userManager.IsInRoleAsync(dbUser1, "Manager") == false)
                {
                    await userManager.AddToRoleAsync(dbUser1, "Manager");
                }
            }


            strEmail = "e.rice@bevotunes.com";

            AppUser manager2 = new AppUser()
            {
                UserName = "e.rice@bevotunes.com",
                Email = "e.rice@bevotunes.com",
                PhoneNumber = "2706602803",
                FirstName = "Eryn",
                LastName = "Rice",
                Address = "3405 Rio Grande",
                ZipCode = "78746"
            };

            AppUser dbUser2 = await userManager.FindByEmailAsync("e.rice@bevotunes.com");

            if (dbUser2 == null)
            {
                IdentityResult result2 = await userManager.CreateAsync(manager2, "arched");

                if (result2.Succeeded == false)
                {
                    String errors2 = "";

                    foreach (IdentityError error in result2.Errors)
                    {
                        errors2 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating manager (e.rice@bevotunes.com): " + errors2);
                }

                dbUser2 = await userManager.FindByEmailAsync("e.rice@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser2, "Manager");
                intUsersAdded += 1;
            }
            else
            {
                dbUser2.UserName = "e.rice@bevotunes.com";
                dbUser2.Email = "e.rice@bevotunes.com";
                dbUser2.PhoneNumber = "2706602803";
                dbUser2.FirstName = "Eryn";
                dbUser2.LastName = "Rice";
                dbUser2.Address = "3405 Rio Grande";
                dbUser2.ZipCode = "78746";

                await userManager.UpdateAsync(dbUser2);

                if (await userManager.IsInRoleAsync(dbUser2, "Manager") == false)
                {
                    await userManager.AddToRoleAsync(dbUser2, "Manager");
                }
            }


            strEmail = "a.rogers@bevotunes.com";

            AppUser manager3 = new AppUser()
            {
                UserName = "a.rogers@bevotunes.com",
                Email = "a.rogers@bevotunes.com",
                PhoneNumber = "4139645586",
                FirstName = "Allen",
                LastName = "Rogers",
                Address = "4965 Oak Hill",
                ZipCode = "78705"
            };

            AppUser dbUser3 = await userManager.FindByEmailAsync("a.rogers@bevotunes.com");

            if (dbUser3 == null)
            {
                IdentityResult result3 = await userManager.CreateAsync(manager3, "lottery");

                if (result3.Succeeded == false)
                {
                    String errors3 = "";

                    foreach (IdentityError error in result3.Errors)
                    {
                        errors3 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating manager (a.rogers@bevotunes.com): " + errors3);
                }

                dbUser3 = await userManager.FindByEmailAsync("a.rogers@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser3, "Manager");
                intUsersAdded += 1;
            }
            else
            {
                dbUser3.UserName = "a.rogers@bevotunes.com";
                dbUser3.Email = "a.rogers@bevotunes.com";
                dbUser3.PhoneNumber = "4139645586";
                dbUser3.FirstName = "Allen";
                dbUser3.LastName = "Rogers";
                dbUser3.Address = "4965 Oak Hill";
                dbUser3.ZipCode = "78705";

                await userManager.UpdateAsync(dbUser3);

                if (await userManager.IsInRoleAsync(dbUser3, "Manager") == false)
                {
                    await userManager.AddToRoleAsync(dbUser3, "Manager");
                }
            }


            strEmail = "w.sewell@bevotunes.com";

            AppUser manager4 = new AppUser()
            {
                UserName = "w.sewell@bevotunes.com",
                Email = "w.sewell@bevotunes.com",
                PhoneNumber = "7224308314",
                FirstName = "William",
                LastName = "Sewell",
                Address = "2365 51st St.",
                ZipCode = "78755"
            };

            AppUser dbUser4 = await userManager.FindByEmailAsync("w.sewell@bevotunes.com");

            if (dbUser4 == null)
            {
                IdentityResult result4 = await userManager.CreateAsync(manager4, "offbeat");

                if (result4.Succeeded == false)
                {
                    String errors4 = "";

                    foreach (IdentityError error in result4.Errors)
                    {
                        errors4 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating manager (w.sewell@bevotunes.com): " + errors4);
                }

                dbUser4 = await userManager.FindByEmailAsync("w.sewell@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser4, "Manager");
                intUsersAdded += 1;
            }
            else
            {
                dbUser4.UserName = "w.sewell@bevotunes.com";
                dbUser4.Email = "w.sewell@bevotunes.com";
                dbUser4.PhoneNumber = "7224308314";
                dbUser4.FirstName = "William";
                dbUser4.LastName = "Sewell";
                dbUser4.Address = "2365 51st St.";
                dbUser4.ZipCode = "78755";

                await userManager.UpdateAsync(dbUser4);

                if (await userManager.IsInRoleAsync(dbUser4, "Manager") == false)
                {
                    await userManager.AddToRoleAsync(dbUser4, "Manager");
                }
            }


            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                String msg = "Managers Added: " + intUsersAdded +
                             "; Error on Email: " + strEmail;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
