using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team10FinalProject.Seeding
{

    public static class EmployeeSeeder
    {
        public static async Task SeedAllEmployees(UserManager<AppUser> userManager, AppDbContext db)
        {
            Int32 intUsersAdded = 0;
            String strEmail = "Begin";


            strEmail = "j.smith@bevotunes.com";

            AppUser employee1 = new AppUser()
            {
                UserName = "j.smith@bevotunes.com",
                Email = "j.smith@bevotunes.com",
                PhoneNumber = "(339) 532-5649",
                FirstName = "John",
                LastName = "Smith",
                Address = "123 Oak St",
                ZipCode = "78701"
            };

            AppUser dbUser1 = await userManager.FindByEmailAsync("j.smith@bevotunes.com");

            if (dbUser1 == null)
            {
                IdentityResult result1 = await userManager.CreateAsync(employee1, "Password1");

                if (result1.Succeeded == false)
                {
                    String errors1 = "";

                    foreach (IdentityError error in result1.Errors)
                    {
                        errors1 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (j.smith@bevotunes.com): " + errors1);
                }

                dbUser1 = await userManager.FindByEmailAsync("j.smith@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser1, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser1.UserName = "j.smith@bevotunes.com";
                dbUser1.Email = "j.smith@bevotunes.com";
                dbUser1.PhoneNumber = "(339) 532-5649";
                dbUser1.FirstName = "John";
                dbUser1.LastName = "Smith";
                dbUser1.Address = "123 Oak St";
                dbUser1.ZipCode = "78701";

                await userManager.UpdateAsync(dbUser1);

                if (await userManager.IsInRoleAsync(dbUser1, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser1, "Employee");
                }
            }


            strEmail = "e.johnson@bevotunes.com";

            AppUser employee2 = new AppUser()
            {
                UserName = "e.johnson@bevotunes.com",
                Email = "e.johnson@bevotunes.com",
                PhoneNumber = "(963) 638-9416",
                FirstName = "Emily",
                LastName = "Johnson",
                Address = "456 Pine St",
                ZipCode = "78702"
            };

            AppUser dbUser2 = await userManager.FindByEmailAsync("e.johnson@bevotunes.com");

            if (dbUser2 == null)
            {
                IdentityResult result2 = await userManager.CreateAsync(employee2, "Summer2");

                if (result2.Succeeded == false)
                {
                    String errors2 = "";

                    foreach (IdentityError error in result2.Errors)
                    {
                        errors2 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (e.johnson@bevotunes.com): " + errors2);
                }

                dbUser2 = await userManager.FindByEmailAsync("e.johnson@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser2, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser2.UserName = "e.johnson@bevotunes.com";
                dbUser2.Email = "e.johnson@bevotunes.com";
                dbUser2.PhoneNumber = "(963) 638-9416";
                dbUser2.FirstName = "Emily";
                dbUser2.LastName = "Johnson";
                dbUser2.Address = "456 Pine St";
                dbUser2.ZipCode = "78702";

                await userManager.UpdateAsync(dbUser2);

                if (await userManager.IsInRoleAsync(dbUser2, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser2, "Employee");
                }
            }


            strEmail = "m.williams@bevotunes.com";

            AppUser employee3 = new AppUser()
            {
                UserName = "m.williams@bevotunes.com",
                Email = "m.williams@bevotunes.com",
                PhoneNumber = "(454) 713-5738",
                FirstName = "Michael",
                LastName = "Williams",
                Address = "789 Maple Ave",
                ZipCode = "78703"
            };

            AppUser dbUser3 = await userManager.FindByEmailAsync("m.williams@bevotunes.com");

            if (dbUser3 == null)
            {
                IdentityResult result3 = await userManager.CreateAsync(employee3, "SongLover5");

                if (result3.Succeeded == false)
                {
                    String errors3 = "";

                    foreach (IdentityError error in result3.Errors)
                    {
                        errors3 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (m.williams@bevotunes.com): " + errors3);
                }

                dbUser3 = await userManager.FindByEmailAsync("m.williams@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser3, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser3.UserName = "m.williams@bevotunes.com";
                dbUser3.Email = "m.williams@bevotunes.com";
                dbUser3.PhoneNumber = "(454) 713-5738";
                dbUser3.FirstName = "Michael";
                dbUser3.LastName = "Williams";
                dbUser3.Address = "789 Maple Ave";
                dbUser3.ZipCode = "78703";

                await userManager.UpdateAsync(dbUser3);

                if (await userManager.IsInRoleAsync(dbUser3, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser3, "Employee");
                }
            }


            strEmail = "s.brown@bevotunes.com";

            AppUser employee4 = new AppUser()
            {
                UserName = "s.brown@bevotunes.com",
                Email = "s.brown@bevotunes.com",
                PhoneNumber = "(581) 734-3315",
                FirstName = "Sarah",
                LastName = "Brown",
                Address = "101 Cedar St",
                ZipCode = "78704"
            };

            AppUser dbUser4 = await userManager.FindByEmailAsync("s.brown@bevotunes.com");

            if (dbUser4 == null)
            {
                IdentityResult result4 = await userManager.CreateAsync(employee4, "BrownSoCool");

                if (result4.Succeeded == false)
                {
                    String errors4 = "";

                    foreach (IdentityError error in result4.Errors)
                    {
                        errors4 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (s.brown@bevotunes.com): " + errors4);
                }

                dbUser4 = await userManager.FindByEmailAsync("s.brown@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser4, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser4.UserName = "s.brown@bevotunes.com";
                dbUser4.Email = "s.brown@bevotunes.com";
                dbUser4.PhoneNumber = "(581) 734-3315";
                dbUser4.FirstName = "Sarah";
                dbUser4.LastName = "Brown";
                dbUser4.Address = "101 Cedar St";
                dbUser4.ZipCode = "78704";

                await userManager.UpdateAsync(dbUser4);

                if (await userManager.IsInRoleAsync(dbUser4, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser4, "Employee");
                }
            }


            strEmail = "d.jones@bevotunes.com";

            AppUser employee5 = new AppUser()
            {
                UserName = "d.jones@bevotunes.com",
                Email = "d.jones@bevotunes.com",
                PhoneNumber = "(824) 191-5317",
                FirstName = "David",
                LastName = "Jones",
                Address = "222 Birch Rd",
                ZipCode = "78705"
            };

            AppUser dbUser5 = await userManager.FindByEmailAsync("d.jones@bevotunes.com");

            if (dbUser5 == null)
            {
                IdentityResult result5 = await userManager.CreateAsync(employee5, "JDJones");

                if (result5.Succeeded == false)
                {
                    String errors5 = "";

                    foreach (IdentityError error in result5.Errors)
                    {
                        errors5 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (d.jones@bevotunes.com): " + errors5);
                }

                dbUser5 = await userManager.FindByEmailAsync("d.jones@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser5, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser5.UserName = "d.jones@bevotunes.com";
                dbUser5.Email = "d.jones@bevotunes.com";
                dbUser5.PhoneNumber = "(824) 191-5317";
                dbUser5.FirstName = "David";
                dbUser5.LastName = "Jones";
                dbUser5.Address = "222 Birch Rd";
                dbUser5.ZipCode = "78705";

                await userManager.UpdateAsync(dbUser5);

                if (await userManager.IsInRoleAsync(dbUser5, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser5, "Employee");
                }
            }


            strEmail = "j.garcia@bevotunes.com";

            AppUser employee6 = new AppUser()
            {
                UserName = "j.garcia@bevotunes.com",
                Email = "j.garcia@bevotunes.com",
                PhoneNumber = "(247) 782-2475",
                FirstName = "Jessica",
                LastName = "Garcia",
                Address = "333 Walnut St",
                ZipCode = "78717"
            };

            AppUser dbUser6 = await userManager.FindByEmailAsync("j.garcia@bevotunes.com");

            if (dbUser6 == null)
            {
                IdentityResult result6 = await userManager.CreateAsync(employee6, "WalGarJes");

                if (result6.Succeeded == false)
                {
                    String errors6 = "";

                    foreach (IdentityError error in result6.Errors)
                    {
                        errors6 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (j.garcia@bevotunes.com): " + errors6);
                }

                dbUser6 = await userManager.FindByEmailAsync("j.garcia@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser6, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser6.UserName = "j.garcia@bevotunes.com";
                dbUser6.Email = "j.garcia@bevotunes.com";
                dbUser6.PhoneNumber = "(247) 782-2475";
                dbUser6.FirstName = "Jessica";
                dbUser6.LastName = "Garcia";
                dbUser6.Address = "333 Walnut St";
                dbUser6.ZipCode = "78717";

                await userManager.UpdateAsync(dbUser6);

                if (await userManager.IsInRoleAsync(dbUser6, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser6, "Employee");
                }
            }


            strEmail = "d.miller@bevotunes.com";

            AppUser employee7 = new AppUser()
            {
                UserName = "d.miller@bevotunes.com",
                Email = "d.miller@bevotunes.com",
                PhoneNumber = "(476) 496-6462",
                FirstName = "Daniel",
                LastName = "Miller",
                Address = "444 Cherry Ln",
                ZipCode = "78723"
            };

            AppUser dbUser7 = await userManager.FindByEmailAsync("d.miller@bevotunes.com");

            if (dbUser7 == null)
            {
                IdentityResult result7 = await userManager.CreateAsync(employee7, "MillHouse");

                if (result7.Succeeded == false)
                {
                    String errors7 = "";

                    foreach (IdentityError error in result7.Errors)
                    {
                        errors7 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (d.miller@bevotunes.com): " + errors7);
                }

                dbUser7 = await userManager.FindByEmailAsync("d.miller@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser7, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser7.UserName = "d.miller@bevotunes.com";
                dbUser7.Email = "d.miller@bevotunes.com";
                dbUser7.PhoneNumber = "(476) 496-6462";
                dbUser7.FirstName = "Daniel";
                dbUser7.LastName = "Miller";
                dbUser7.Address = "444 Cherry Ln";
                dbUser7.ZipCode = "78723";

                await userManager.UpdateAsync(dbUser7);

                if (await userManager.IsInRoleAsync(dbUser7, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser7, "Employee");
                }
            }


            strEmail = "a.davis@bevotunes.com";

            AppUser employee8 = new AppUser()
            {
                UserName = "a.davis@bevotunes.com",
                Email = "a.davis@bevotunes.com",
                PhoneNumber = "(512) 834-7291",
                FirstName = "Ashley",
                LastName = "Davis",
                Address = "555 Spruce St",
                ZipCode = "78727"
            };

            AppUser dbUser8 = await userManager.FindByEmailAsync("a.davis@bevotunes.com");

            if (dbUser8 == null)
            {
                IdentityResult result8 = await userManager.CreateAsync(employee8, "VolcanoAsh");

                if (result8.Succeeded == false)
                {
                    String errors8 = "";

                    foreach (IdentityError error in result8.Errors)
                    {
                        errors8 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (a.davis@bevotunes.com): " + errors8);
                }

                dbUser8 = await userManager.FindByEmailAsync("a.davis@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser8, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser8.UserName = "a.davis@bevotunes.com";
                dbUser8.Email = "a.davis@bevotunes.com";
                dbUser8.PhoneNumber = "(512) 834-7291";
                dbUser8.FirstName = "Ashley";
                dbUser8.LastName = "Davis";
                dbUser8.Address = "555 Spruce St";
                dbUser8.ZipCode = "78727";

                await userManager.UpdateAsync(dbUser8);

                if (await userManager.IsInRoleAsync(dbUser8, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser8, "Employee");
                }
            }


            strEmail = "m.rodriguez@bevotunes.com";

            AppUser employee9 = new AppUser()
            {
                UserName = "m.rodriguez@bevotunes.com",
                Email = "m.rodriguez@bevotunes.com",
                PhoneNumber = "(713) 245-6837",
                FirstName = "Matthew",
                LastName = "Rodriguez",
                Address = "666 Willow Dr",
                ZipCode = "78729"
            };

            AppUser dbUser9 = await userManager.FindByEmailAsync("m.rodriguez@bevotunes.com");

            if (dbUser9 == null)
            {
                IdentityResult result9 = await userManager.CreateAsync(employee9, "Marod1");

                if (result9.Succeeded == false)
                {
                    String errors9 = "";

                    foreach (IdentityError error in result9.Errors)
                    {
                        errors9 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (m.rodriguez@bevotunes.com): " + errors9);
                }

                dbUser9 = await userManager.FindByEmailAsync("m.rodriguez@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser9, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser9.UserName = "m.rodriguez@bevotunes.com";
                dbUser9.Email = "m.rodriguez@bevotunes.com";
                dbUser9.PhoneNumber = "(713) 245-6837";
                dbUser9.FirstName = "Matthew";
                dbUser9.LastName = "Rodriguez";
                dbUser9.Address = "666 Willow Dr";
                dbUser9.ZipCode = "78729";

                await userManager.UpdateAsync(dbUser9);

                if (await userManager.IsInRoleAsync(dbUser9, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser9, "Employee");
                }
            }


            strEmail = "a.martinez@bevotunes.com";

            AppUser employee10 = new AppUser()
            {
                UserName = "a.martinez@bevotunes.com",
                Email = "a.martinez@bevotunes.com",
                PhoneNumber = "(214) 567-9012",
                FirstName = "Amanda",
                LastName = "Martinez",
                Address = "777 Aspen Way",
                ZipCode = "78745"
            };

            AppUser dbUser10 = await userManager.FindByEmailAsync("a.martinez@bevotunes.com");

            if (dbUser10 == null)
            {
                IdentityResult result10 = await userManager.CreateAsync(employee10, "martin51");

                if (result10.Succeeded == false)
                {
                    String errors10 = "";

                    foreach (IdentityError error in result10.Errors)
                    {
                        errors10 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (a.martinez@bevotunes.com): " + errors10);
                }

                dbUser10 = await userManager.FindByEmailAsync("a.martinez@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser10, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser10.UserName = "a.martinez@bevotunes.com";
                dbUser10.Email = "a.martinez@bevotunes.com";
                dbUser10.PhoneNumber = "(214) 567-9012";
                dbUser10.FirstName = "Amanda";
                dbUser10.LastName = "Martinez";
                dbUser10.Address = "777 Aspen Way";
                dbUser10.ZipCode = "78745";

                await userManager.UpdateAsync(dbUser10);

                if (await userManager.IsInRoleAsync(dbUser10, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser10, "Employee");
                }
            }


            strEmail = "c.hernandez@bevotunes.com";

            AppUser employee11 = new AppUser()
            {
                UserName = "c.hernandez@bevotunes.com",
                Email = "c.hernandez@bevotunes.com",
                PhoneNumber = "(936) 778-4526",
                FirstName = "Christopher",
                LastName = "Hernandez",
                Address = "888 Poplar St",
                ZipCode = "77002"
            };

            AppUser dbUser11 = await userManager.FindByEmailAsync("c.hernandez@bevotunes.com");

            if (dbUser11 == null)
            {
                IdentityResult result11 = await userManager.CreateAsync(employee11, "Member2");

                if (result11.Succeeded == false)
                {
                    String errors11 = "";

                    foreach (IdentityError error in result11.Errors)
                    {
                        errors11 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (c.hernandez@bevotunes.com): " + errors11);
                }

                dbUser11 = await userManager.FindByEmailAsync("c.hernandez@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser11, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser11.UserName = "c.hernandez@bevotunes.com";
                dbUser11.Email = "c.hernandez@bevotunes.com";
                dbUser11.PhoneNumber = "(936) 778-4526";
                dbUser11.FirstName = "Christopher";
                dbUser11.LastName = "Hernandez";
                dbUser11.Address = "888 Poplar St";
                dbUser11.ZipCode = "77002";

                await userManager.UpdateAsync(dbUser11);

                if (await userManager.IsInRoleAsync(dbUser11, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser11, "Employee");
                }
            }


            strEmail = "s.lopez@bevotunes.com";

            AppUser employee12 = new AppUser()
            {
                UserName = "s.lopez@bevotunes.com",
                Email = "s.lopez@bevotunes.com",
                PhoneNumber = "(281) 349-7743",
                FirstName = "Stephanie",
                LastName = "Lopez",
                Address = "999 Cypress Rd",
                ZipCode = "75201"
            };

            AppUser dbUser12 = await userManager.FindByEmailAsync("s.lopez@bevotunes.com");

            if (dbUser12 == null)
            {
                IdentityResult result12 = await userManager.CreateAsync(employee12, "Active3");

                if (result12.Succeeded == false)
                {
                    String errors12 = "";

                    foreach (IdentityError error in result12.Errors)
                    {
                        errors12 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (s.lopez@bevotunes.com): " + errors12);
                }

                dbUser12 = await userManager.FindByEmailAsync("s.lopez@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser12, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser12.UserName = "s.lopez@bevotunes.com";
                dbUser12.Email = "s.lopez@bevotunes.com";
                dbUser12.PhoneNumber = "(281) 349-7743";
                dbUser12.FirstName = "Stephanie";
                dbUser12.LastName = "Lopez";
                dbUser12.Address = "999 Cypress Rd";
                dbUser12.ZipCode = "75201";

                await userManager.UpdateAsync(dbUser12);

                if (await userManager.IsInRoleAsync(dbUser12, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser12, "Employee");
                }
            }


            strEmail = "a.gonzalez@bevotunes.com";

            AppUser employee13 = new AppUser()
            {
                UserName = "a.gonzalez@bevotunes.com",
                Email = "a.gonzalez@bevotunes.com",
                PhoneNumber = "(972) 660-1835",
                FirstName = "Andrew",
                LastName = "Gonzalez",
                Address = "111 Redwood Ave",
                ZipCode = "78205"
            };

            AppUser dbUser13 = await userManager.FindByEmailAsync("a.gonzalez@bevotunes.com");

            if (dbUser13 == null)
            {
                IdentityResult result13 = await userManager.CreateAsync(employee13, "System4");

                if (result13.Succeeded == false)
                {
                    String errors13 = "";

                    foreach (IdentityError error in result13.Errors)
                    {
                        errors13 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (a.gonzalez@bevotunes.com): " + errors13);
                }

                dbUser13 = await userManager.FindByEmailAsync("a.gonzalez@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser13, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser13.UserName = "a.gonzalez@bevotunes.com";
                dbUser13.Email = "a.gonzalez@bevotunes.com";
                dbUser13.PhoneNumber = "(972) 660-1835";
                dbUser13.FirstName = "Andrew";
                dbUser13.LastName = "Gonzalez";
                dbUser13.Address = "111 Redwood Ave";
                dbUser13.ZipCode = "78205";

                await userManager.UpdateAsync(dbUser13);

                if (await userManager.IsInRoleAsync(dbUser13, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser13, "Employee");
                }
            }


            strEmail = "l.wilson@bevotunes.com";

            AppUser employee14 = new AppUser()
            {
                UserName = "l.wilson@bevotunes.com",
                Email = "l.wilson@bevotunes.com",
                PhoneNumber = "(409) 522-9941",
                FirstName = "Lauren",
                LastName = "Wilson",
                Address = "222 Dogwood Ln",
                ZipCode = "76102"
            };

            AppUser dbUser14 = await userManager.FindByEmailAsync("l.wilson@bevotunes.com");

            if (dbUser14 == null)
            {
                IdentityResult result14 = await userManager.CreateAsync(employee14, "Network5");

                if (result14.Succeeded == false)
                {
                    String errors14 = "";

                    foreach (IdentityError error in result14.Errors)
                    {
                        errors14 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (l.wilson@bevotunes.com): " + errors14);
                }

                dbUser14 = await userManager.FindByEmailAsync("l.wilson@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser14, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser14.UserName = "l.wilson@bevotunes.com";
                dbUser14.Email = "l.wilson@bevotunes.com";
                dbUser14.PhoneNumber = "(409) 522-9941";
                dbUser14.FirstName = "Lauren";
                dbUser14.LastName = "Wilson";
                dbUser14.Address = "222 Dogwood Ln";
                dbUser14.ZipCode = "76102";

                await userManager.UpdateAsync(dbUser14);

                if (await userManager.IsInRoleAsync(dbUser14, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser14, "Employee");
                }
            }


            strEmail = "j.anderson@bevotunes.com";

            AppUser employee15 = new AppUser()
            {
                UserName = "j.anderson@bevotunes.com",
                Email = "j.anderson@bevotunes.com",
                PhoneNumber = "(830) 415-6278",
                FirstName = "Joshua",
                LastName = "Anderson",
                Address = "333 Magnolia St",
                ZipCode = "90001"
            };

            AppUser dbUser15 = await userManager.FindByEmailAsync("j.anderson@bevotunes.com");

            if (dbUser15 == null)
            {
                IdentityResult result15 = await userManager.CreateAsync(employee15, "Service6");

                if (result15.Succeeded == false)
                {
                    String errors15 = "";

                    foreach (IdentityError error in result15.Errors)
                    {
                        errors15 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (j.anderson@bevotunes.com): " + errors15);
                }

                dbUser15 = await userManager.FindByEmailAsync("j.anderson@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser15, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser15.UserName = "j.anderson@bevotunes.com";
                dbUser15.Email = "j.anderson@bevotunes.com";
                dbUser15.PhoneNumber = "(830) 415-6278";
                dbUser15.FirstName = "Joshua";
                dbUser15.LastName = "Anderson";
                dbUser15.Address = "333 Magnolia St";
                dbUser15.ZipCode = "90001";

                await userManager.UpdateAsync(dbUser15);

                if (await userManager.IsInRoleAsync(dbUser15, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser15, "Employee");
                }
            }


            strEmail = "n.thomas@bevotunes.com";

            AppUser employee16 = new AppUser()
            {
                UserName = "n.thomas@bevotunes.com",
                Email = "n.thomas@bevotunes.com",
                PhoneNumber = "(325) 738-5602",
                FirstName = "Nicole",
                LastName = "Thomas",
                Address = "444 Juniper Dr",
                ZipCode = "94102"
            };

            AppUser dbUser16 = await userManager.FindByEmailAsync("n.thomas@bevotunes.com");

            if (dbUser16 == null)
            {
                IdentityResult result16 = await userManager.CreateAsync(employee16, "User77");

                if (result16.Succeeded == false)
                {
                    String errors16 = "";

                    foreach (IdentityError error in result16.Errors)
                    {
                        errors16 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (n.thomas@bevotunes.com): " + errors16);
                }

                dbUser16 = await userManager.FindByEmailAsync("n.thomas@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser16, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser16.UserName = "n.thomas@bevotunes.com";
                dbUser16.Email = "n.thomas@bevotunes.com";
                dbUser16.PhoneNumber = "(325) 738-5602";
                dbUser16.FirstName = "Nicole";
                dbUser16.LastName = "Thomas";
                dbUser16.Address = "444 Juniper Dr";
                dbUser16.ZipCode = "94102";

                await userManager.UpdateAsync(dbUser16);

                if (await userManager.IsInRoleAsync(dbUser16, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser16, "Employee");
                }
            }


            strEmail = "r.taylor@bevotunes.com";

            AppUser employee17 = new AppUser()
            {
                UserName = "r.taylor@bevotunes.com",
                Email = "r.taylor@bevotunes.com",
                PhoneNumber = "(915) 684-2294",
                FirstName = "Ryan",
                LastName = "Taylor",
                Address = "555 Hickory St",
                ZipCode = "10001"
            };

            AppUser dbUser17 = await userManager.FindByEmailAsync("r.taylor@bevotunes.com");

            if (dbUser17 == null)
            {
                IdentityResult result17 = await userManager.CreateAsync(employee17, "Client81");

                if (result17.Succeeded == false)
                {
                    String errors17 = "";

                    foreach (IdentityError error in result17.Errors)
                    {
                        errors17 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (r.taylor@bevotunes.com): " + errors17);
                }

                dbUser17 = await userManager.FindByEmailAsync("r.taylor@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser17, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser17.UserName = "r.taylor@bevotunes.com";
                dbUser17.Email = "r.taylor@bevotunes.com";
                dbUser17.PhoneNumber = "(915) 684-2294";
                dbUser17.FirstName = "Ryan";
                dbUser17.LastName = "Taylor";
                dbUser17.Address = "555 Hickory St";
                dbUser17.ZipCode = "10001";

                await userManager.UpdateAsync(dbUser17);

                if (await userManager.IsInRoleAsync(dbUser17, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser17, "Employee");
                }
            }


            strEmail = "m.moore@bevotunes.com";

            AppUser employee18 = new AppUser()
            {
                UserName = "m.moore@bevotunes.com",
                Email = "m.moore@bevotunes.com",
                PhoneNumber = "(210) 953-4471",
                FirstName = "Megan",
                LastName = "Moore",
                Address = "666 Alder Rd",
                ZipCode = "60601"
            };

            AppUser dbUser18 = await userManager.FindByEmailAsync("m.moore@bevotunes.com");

            if (dbUser18 == null)
            {
                IdentityResult result18 = await userManager.CreateAsync(employee18, "AccountSong");

                if (result18.Succeeded == false)
                {
                    String errors18 = "";

                    foreach (IdentityError error in result18.Errors)
                    {
                        errors18 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (m.moore@bevotunes.com): " + errors18);
                }

                dbUser18 = await userManager.FindByEmailAsync("m.moore@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser18, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser18.UserName = "m.moore@bevotunes.com";
                dbUser18.Email = "m.moore@bevotunes.com";
                dbUser18.PhoneNumber = "(210) 953-4471";
                dbUser18.FirstName = "Megan";
                dbUser18.LastName = "Moore";
                dbUser18.Address = "666 Alder Rd";
                dbUser18.ZipCode = "60601";

                await userManager.UpdateAsync(dbUser18);

                if (await userManager.IsInRoleAsync(dbUser18, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser18, "Employee");
                }
            }


            strEmail = "b.jackson@bevotunes.com";

            AppUser employee19 = new AppUser()
            {
                UserName = "b.jackson@bevotunes.com",
                Email = "b.jackson@bevotunes.com",
                PhoneNumber = "(469) 318-7905",
                FirstName = "Brandon",
                LastName = "Jackson",
                Address = "777 Sycamore St",
                ZipCode = "33101"
            };

            AppUser dbUser19 = await userManager.FindByEmailAsync("b.jackson@bevotunes.com");

            if (dbUser19 == null)
            {
                IdentityResult result19 = await userManager.CreateAsync(employee19, "Manage1");

                if (result19.Succeeded == false)
                {
                    String errors19 = "";

                    foreach (IdentityError error in result19.Errors)
                    {
                        errors19 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (b.jackson@bevotunes.com): " + errors19);
                }

                dbUser19 = await userManager.FindByEmailAsync("b.jackson@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser19, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser19.UserName = "b.jackson@bevotunes.com";
                dbUser19.Email = "b.jackson@bevotunes.com";
                dbUser19.PhoneNumber = "(469) 318-7905";
                dbUser19.FirstName = "Brandon";
                dbUser19.LastName = "Jackson";
                dbUser19.Address = "777 Sycamore St";
                dbUser19.ZipCode = "33101";

                await userManager.UpdateAsync(dbUser19);

                if (await userManager.IsInRoleAsync(dbUser19, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser19, "Employee");
                }
            }


            strEmail = "r.martin@bevotunes.com";

            AppUser employee20 = new AppUser()
            {
                UserName = "r.martin@bevotunes.com",
                Email = "r.martin@bevotunes.com",
                PhoneNumber = "(254) 842-6619",
                FirstName = "Rachel",
                LastName = "Martin",
                Address = "888 Cottonwood Ave",
                ZipCode = "2108"
            };

            AppUser dbUser20 = await userManager.FindByEmailAsync("r.martin@bevotunes.com");

            if (dbUser20 == null)
            {
                IdentityResult result20 = await userManager.CreateAsync(employee20, "SecurePass");

                if (result20.Succeeded == false)
                {
                    String errors20 = "";

                    foreach (IdentityError error in result20.Errors)
                    {
                        errors20 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating employee (r.martin@bevotunes.com): " + errors20);
                }

                dbUser20 = await userManager.FindByEmailAsync("r.martin@bevotunes.com");
                await userManager.AddToRoleAsync(dbUser20, "Employee");
                intUsersAdded += 1;
            }
            else
            {
                dbUser20.UserName = "r.martin@bevotunes.com";
                dbUser20.Email = "r.martin@bevotunes.com";
                dbUser20.PhoneNumber = "(254) 842-6619";
                dbUser20.FirstName = "Rachel";
                dbUser20.LastName = "Martin";
                dbUser20.Address = "888 Cottonwood Ave";
                dbUser20.ZipCode = "2108";

                await userManager.UpdateAsync(dbUser20);

                if (await userManager.IsInRoleAsync(dbUser20, "Employee") == false)
                {
                    await userManager.AddToRoleAsync(dbUser20, "Employee");
                }
            }


            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                String msg = "Employees Added: " + intUsersAdded +
                             "; Error on Email: " + strEmail;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
