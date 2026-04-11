using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team10FinalProject.Seeding
{

    public static class CustomerSeeder
    {
        public static async Task SeedAllCustomers(UserManager<AppUser> userManager, AppDbContext db)
        {
            Int32 intUsersAdded = 0;
            String strEmail = "Begin";


            strEmail = "cbaker@example.com";

            AppUser customer1 = new AppUser()
            {
                UserName = "cbaker@example.com",
                Email = "cbaker@example.com",
                PhoneNumber = "5725458641",
                FirstName = "Christopher",
                LastName = "Baker",
                Address = "1898 Schurz Alley",
                ZipCode = "78701"
            };

            AppUser dbUser1 = await userManager.FindByEmailAsync("cbaker@example.com");

            if (dbUser1 == null)
            {
                IdentityResult result1 = await userManager.CreateAsync(customer1, "musiclover");

                if (result1.Succeeded == false)
                {
                    String errors1 = "";

                    foreach (IdentityError error in result1.Errors)
                    {
                        errors1 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (cbaker@example.com): " + errors1);
                }

                dbUser1 = await userManager.FindByEmailAsync("cbaker@example.com");
                await userManager.AddToRoleAsync(dbUser1, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser1.UserName = "cbaker@example.com";
                dbUser1.Email = "cbaker@example.com";
                dbUser1.PhoneNumber = "5725458641";
                dbUser1.FirstName = "Christopher";
                dbUser1.LastName = "Baker";
                dbUser1.Address = "1898 Schurz Alley";
                dbUser1.ZipCode = "78701";

                await userManager.UpdateAsync(dbUser1);

                if (await userManager.IsInRoleAsync(dbUser1, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser1, "Customer");
                }
            }


            strEmail = "banker@longhorn.net";

            AppUser customer2 = new AppUser()
            {
                UserName = "banker@longhorn.net",
                Email = "banker@longhorn.net",
                PhoneNumber = "9867048435",
                FirstName = "Michelle",
                LastName = "Banks",
                Address = "97 Elmside Pass",
                ZipCode = "78702"
            };

            AppUser dbUser2 = await userManager.FindByEmailAsync("banker@longhorn.net");

            if (dbUser2 == null)
            {
                IdentityResult result2 = await userManager.CreateAsync(customer2, "potato");

                if (result2.Succeeded == false)
                {
                    String errors2 = "";

                    foreach (IdentityError error in result2.Errors)
                    {
                        errors2 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (banker@longhorn.net): " + errors2);
                }

                dbUser2 = await userManager.FindByEmailAsync("banker@longhorn.net");
                await userManager.AddToRoleAsync(dbUser2, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser2.UserName = "banker@longhorn.net";
                dbUser2.Email = "banker@longhorn.net";
                dbUser2.PhoneNumber = "9867048435";
                dbUser2.FirstName = "Michelle";
                dbUser2.LastName = "Banks";
                dbUser2.Address = "97 Elmside Pass";
                dbUser2.ZipCode = "78702";

                await userManager.UpdateAsync(dbUser2);

                if (await userManager.IsInRoleAsync(dbUser2, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser2, "Customer");
                }
            }


            strEmail = "franco@example.com";

            AppUser customer3 = new AppUser()
            {
                UserName = "franco@example.com",
                Email = "franco@example.com",
                PhoneNumber = "6836109514",
                FirstName = "Franco",
                LastName = "Broccolo",
                Address = "88 Crowley Circle",
                ZipCode = "78703"
            };

            AppUser dbUser3 = await userManager.FindByEmailAsync("franco@example.com");

            if (dbUser3 == null)
            {
                IdentityResult result3 = await userManager.CreateAsync(customer3, "painting");

                if (result3.Succeeded == false)
                {
                    String errors3 = "";

                    foreach (IdentityError error in result3.Errors)
                    {
                        errors3 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (franco@example.com): " + errors3);
                }

                dbUser3 = await userManager.FindByEmailAsync("franco@example.com");
                await userManager.AddToRoleAsync(dbUser3, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser3.UserName = "franco@example.com";
                dbUser3.Email = "franco@example.com";
                dbUser3.PhoneNumber = "6836109514";
                dbUser3.FirstName = "Franco";
                dbUser3.LastName = "Broccolo";
                dbUser3.Address = "88 Crowley Circle";
                dbUser3.ZipCode = "78703";

                await userManager.UpdateAsync(dbUser3);

                if (await userManager.IsInRoleAsync(dbUser3, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser3, "Customer");
                }
            }


            strEmail = "wchang@example.com";

            AppUser customer4 = new AppUser()
            {
                UserName = "wchang@example.com",
                Email = "wchang@example.com",
                PhoneNumber = "7070911071",
                FirstName = "Wendy",
                LastName = "Chang",
                Address = "56560 Sage Junction",
                ZipCode = "78704"
            };

            AppUser dbUser4 = await userManager.FindByEmailAsync("wchang@example.com");

            if (dbUser4 == null)
            {
                IdentityResult result4 = await userManager.CreateAsync(customer4, "texas1");

                if (result4.Succeeded == false)
                {
                    String errors4 = "";

                    foreach (IdentityError error in result4.Errors)
                    {
                        errors4 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (wchang@example.com): " + errors4);
                }

                dbUser4 = await userManager.FindByEmailAsync("wchang@example.com");
                await userManager.AddToRoleAsync(dbUser4, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser4.UserName = "wchang@example.com";
                dbUser4.Email = "wchang@example.com";
                dbUser4.PhoneNumber = "7070911071";
                dbUser4.FirstName = "Wendy";
                dbUser4.LastName = "Chang";
                dbUser4.Address = "56560 Sage Junction";
                dbUser4.ZipCode = "78704";

                await userManager.UpdateAsync(dbUser4);

                if (await userManager.IsInRoleAsync(dbUser4, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser4, "Customer");
                }
            }


            strEmail = "limchou@gogle.com";

            AppUser customer5 = new AppUser()
            {
                UserName = "limchou@gogle.com",
                Email = "limchou@gogle.com",
                PhoneNumber = "1488907687",
                FirstName = "Lim",
                LastName = "Chou",
                Address = "60 Lunder Point",
                ZipCode = "78705"
            };

            AppUser dbUser5 = await userManager.FindByEmailAsync("limchou@gogle.com");

            if (dbUser5 == null)
            {
                IdentityResult result5 = await userManager.CreateAsync(customer5, "Anchorage");

                if (result5.Succeeded == false)
                {
                    String errors5 = "";

                    foreach (IdentityError error in result5.Errors)
                    {
                        errors5 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (limchou@gogle.com): " + errors5);
                }

                dbUser5 = await userManager.FindByEmailAsync("limchou@gogle.com");
                await userManager.AddToRoleAsync(dbUser5, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser5.UserName = "limchou@gogle.com";
                dbUser5.Email = "limchou@gogle.com";
                dbUser5.PhoneNumber = "1488907687";
                dbUser5.FirstName = "Lim";
                dbUser5.LastName = "Chou";
                dbUser5.Address = "60 Lunder Point";
                dbUser5.ZipCode = "78705";

                await userManager.UpdateAsync(dbUser5);

                if (await userManager.IsInRoleAsync(dbUser5, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser5, "Customer");
                }
            }


            strEmail = "shdixon@aoll.com";

            AppUser customer6 = new AppUser()
            {
                UserName = "shdixon@aoll.com",
                Email = "shdixon@aoll.com",
                PhoneNumber = "6899701824",
                FirstName = "Shan",
                LastName = "Dixon",
                Address = "9448 Pleasure Avenue",
                ZipCode = "78717"
            };

            AppUser dbUser6 = await userManager.FindByEmailAsync("shdixon@aoll.com");

            if (dbUser6 == null)
            {
                IdentityResult result6 = await userManager.CreateAsync(customer6, "aggies");

                if (result6.Succeeded == false)
                {
                    String errors6 = "";

                    foreach (IdentityError error in result6.Errors)
                    {
                        errors6 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (shdixon@aoll.com): " + errors6);
                }

                dbUser6 = await userManager.FindByEmailAsync("shdixon@aoll.com");
                await userManager.AddToRoleAsync(dbUser6, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser6.UserName = "shdixon@aoll.com";
                dbUser6.Email = "shdixon@aoll.com";
                dbUser6.PhoneNumber = "6899701824";
                dbUser6.FirstName = "Shan";
                dbUser6.LastName = "Dixon";
                dbUser6.Address = "9448 Pleasure Avenue";
                dbUser6.ZipCode = "78717";

                await userManager.UpdateAsync(dbUser6);

                if (await userManager.IsInRoleAsync(dbUser6, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser6, "Customer");
                }
            }


            strEmail = "j.b.evans@aheca.org";

            AppUser customer7 = new AppUser()
            {
                UserName = "j.b.evans@aheca.org",
                Email = "j.b.evans@aheca.org",
                PhoneNumber = "9986825917",
                FirstName = "Jim Bob",
                LastName = "Evans",
                Address = "51 Emmet Parkway",
                ZipCode = "78723"
            };

            AppUser dbUser7 = await userManager.FindByEmailAsync("j.b.evans@aheca.org");

            if (dbUser7 == null)
            {
                IdentityResult result7 = await userManager.CreateAsync(customer7, "hampton1");

                if (result7.Succeeded == false)
                {
                    String errors7 = "";

                    foreach (IdentityError error in result7.Errors)
                    {
                        errors7 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (j.b.evans@aheca.org): " + errors7);
                }

                dbUser7 = await userManager.FindByEmailAsync("j.b.evans@aheca.org");
                await userManager.AddToRoleAsync(dbUser7, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser7.UserName = "j.b.evans@aheca.org";
                dbUser7.Email = "j.b.evans@aheca.org";
                dbUser7.PhoneNumber = "9986825917";
                dbUser7.FirstName = "Jim Bob";
                dbUser7.LastName = "Evans";
                dbUser7.Address = "51 Emmet Parkway";
                dbUser7.ZipCode = "78723";

                await userManager.UpdateAsync(dbUser7);

                if (await userManager.IsInRoleAsync(dbUser7, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser7, "Customer");
                }
            }


            strEmail = "feeley@penguin.org";

            AppUser customer8 = new AppUser()
            {
                UserName = "feeley@penguin.org",
                Email = "feeley@penguin.org",
                PhoneNumber = "3464121966",
                FirstName = "Lou Ann",
                LastName = "Feeley",
                Address = "65 Darwin Crossing",
                ZipCode = "78726"
            };

            AppUser dbUser8 = await userManager.FindByEmailAsync("feeley@penguin.org");

            if (dbUser8 == null)
            {
                IdentityResult result8 = await userManager.CreateAsync(customer8, "longhorns");

                if (result8.Succeeded == false)
                {
                    String errors8 = "";

                    foreach (IdentityError error in result8.Errors)
                    {
                        errors8 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (feeley@penguin.org): " + errors8);
                }

                dbUser8 = await userManager.FindByEmailAsync("feeley@penguin.org");
                await userManager.AddToRoleAsync(dbUser8, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser8.UserName = "feeley@penguin.org";
                dbUser8.Email = "feeley@penguin.org";
                dbUser8.PhoneNumber = "3464121966";
                dbUser8.FirstName = "Lou Ann";
                dbUser8.LastName = "Feeley";
                dbUser8.Address = "65 Darwin Crossing";
                dbUser8.ZipCode = "78726";

                await userManager.UpdateAsync(dbUser8);

                if (await userManager.IsInRoleAsync(dbUser8, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser8, "Customer");
                }
            }


            strEmail = "tfreeley@ci.us";

            AppUser customer9 = new AppUser()
            {
                UserName = "tfreeley@ci.us",
                Email = "tfreeley@ci.us",
                PhoneNumber = "6581357270",
                FirstName = "Tesa",
                LastName = "Freeley",
                Address = "7352 Loftsgordon Court",
                ZipCode = "78727"
            };

            AppUser dbUser9 = await userManager.FindByEmailAsync("tfreeley@ci.us");

            if (dbUser9 == null)
            {
                IdentityResult result9 = await userManager.CreateAsync(customer9, "mustangs");

                if (result9.Succeeded == false)
                {
                    String errors9 = "";

                    foreach (IdentityError error in result9.Errors)
                    {
                        errors9 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (tfreeley@ci.us): " + errors9);
                }

                dbUser9 = await userManager.FindByEmailAsync("tfreeley@ci.us");
                await userManager.AddToRoleAsync(dbUser9, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser9.UserName = "tfreeley@ci.us";
                dbUser9.Email = "tfreeley@ci.us";
                dbUser9.PhoneNumber = "6581357270";
                dbUser9.FirstName = "Tesa";
                dbUser9.LastName = "Freeley";
                dbUser9.Address = "7352 Loftsgordon Court";
                dbUser9.ZipCode = "78727";

                await userManager.UpdateAsync(dbUser9);

                if (await userManager.IsInRoleAsync(dbUser9, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser9, "Customer");
                }
            }


            strEmail = "mgarcia@gogle.com";

            AppUser customer10 = new AppUser()
            {
                UserName = "mgarcia@gogle.com",
                Email = "mgarcia@gogle.com",
                PhoneNumber = "3767347949",
                FirstName = "Margaret",
                LastName = "Garcia",
                Address = "7 International Road",
                ZipCode = "78728"
            };

            AppUser dbUser10 = await userManager.FindByEmailAsync("mgarcia@gogle.com");

            if (dbUser10 == null)
            {
                IdentityResult result10 = await userManager.CreateAsync(customer10, "onetime");

                if (result10.Succeeded == false)
                {
                    String errors10 = "";

                    foreach (IdentityError error in result10.Errors)
                    {
                        errors10 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (mgarcia@gogle.com): " + errors10);
                }

                dbUser10 = await userManager.FindByEmailAsync("mgarcia@gogle.com");
                await userManager.AddToRoleAsync(dbUser10, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser10.UserName = "mgarcia@gogle.com";
                dbUser10.Email = "mgarcia@gogle.com";
                dbUser10.PhoneNumber = "3767347949";
                dbUser10.FirstName = "Margaret";
                dbUser10.LastName = "Garcia";
                dbUser10.Address = "7 International Road";
                dbUser10.ZipCode = "78728";

                await userManager.UpdateAsync(dbUser10);

                if (await userManager.IsInRoleAsync(dbUser10, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser10, "Customer");
                }
            }


            strEmail = "chaley@thug.com";

            AppUser customer11 = new AppUser()
            {
                UserName = "chaley@thug.com",
                Email = "chaley@thug.com",
                PhoneNumber = "2198604221",
                FirstName = "Charles",
                LastName = "Haley",
                Address = "8 Warrior Trail",
                ZipCode = "78729"
            };

            AppUser dbUser11 = await userManager.FindByEmailAsync("chaley@thug.com");

            if (dbUser11 == null)
            {
                IdentityResult result11 = await userManager.CreateAsync(customer11, "pepperoni");

                if (result11.Succeeded == false)
                {
                    String errors11 = "";

                    foreach (IdentityError error in result11.Errors)
                    {
                        errors11 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (chaley@thug.com): " + errors11);
                }

                dbUser11 = await userManager.FindByEmailAsync("chaley@thug.com");
                await userManager.AddToRoleAsync(dbUser11, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser11.UserName = "chaley@thug.com";
                dbUser11.Email = "chaley@thug.com";
                dbUser11.PhoneNumber = "2198604221";
                dbUser11.FirstName = "Charles";
                dbUser11.LastName = "Haley";
                dbUser11.Address = "8 Warrior Trail";
                dbUser11.ZipCode = "78729";

                await userManager.UpdateAsync(dbUser11);

                if (await userManager.IsInRoleAsync(dbUser11, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser11, "Customer");
                }
            }


            strEmail = "jeffh@sonic.com";

            AppUser customer12 = new AppUser()
            {
                UserName = "jeffh@sonic.com",
                Email = "jeffh@sonic.com",
                PhoneNumber = "1222185888",
                FirstName = "Jeffrey",
                LastName = "Hampton",
                Address = "9107 Lighthouse Bay Road",
                ZipCode = "78731"
            };

            AppUser dbUser12 = await userManager.FindByEmailAsync("jeffh@sonic.com");

            if (dbUser12 == null)
            {
                IdentityResult result12 = await userManager.CreateAsync(customer12, "raiders");

                if (result12.Succeeded == false)
                {
                    String errors12 = "";

                    foreach (IdentityError error in result12.Errors)
                    {
                        errors12 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (jeffh@sonic.com): " + errors12);
                }

                dbUser12 = await userManager.FindByEmailAsync("jeffh@sonic.com");
                await userManager.AddToRoleAsync(dbUser12, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser12.UserName = "jeffh@sonic.com";
                dbUser12.Email = "jeffh@sonic.com";
                dbUser12.PhoneNumber = "1222185888";
                dbUser12.FirstName = "Jeffrey";
                dbUser12.LastName = "Hampton";
                dbUser12.Address = "9107 Lighthouse Bay Road";
                dbUser12.ZipCode = "78731";

                await userManager.UpdateAsync(dbUser12);

                if (await userManager.IsInRoleAsync(dbUser12, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser12, "Customer");
                }
            }


            strEmail = "wjhearniii@umich.org";

            AppUser customer13 = new AppUser()
            {
                UserName = "wjhearniii@umich.org",
                Email = "wjhearniii@umich.org",
                PhoneNumber = "5123071976",
                FirstName = "John",
                LastName = "Hearn",
                Address = "59784 Pierstorff Center",
                ZipCode = "78733"
            };

            AppUser dbUser13 = await userManager.FindByEmailAsync("wjhearniii@umich.org");

            if (dbUser13 == null)
            {
                IdentityResult result13 = await userManager.CreateAsync(customer13, "jhearn22");

                if (result13.Succeeded == false)
                {
                    String errors13 = "";

                    foreach (IdentityError error in result13.Errors)
                    {
                        errors13 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (wjhearniii@umich.org): " + errors13);
                }

                dbUser13 = await userManager.FindByEmailAsync("wjhearniii@umich.org");
                await userManager.AddToRoleAsync(dbUser13, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser13.UserName = "wjhearniii@umich.org";
                dbUser13.Email = "wjhearniii@umich.org";
                dbUser13.PhoneNumber = "5123071976";
                dbUser13.FirstName = "John";
                dbUser13.LastName = "Hearn";
                dbUser13.Address = "59784 Pierstorff Center";
                dbUser13.ZipCode = "78733";

                await userManager.UpdateAsync(dbUser13);

                if (await userManager.IsInRoleAsync(dbUser13, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser13, "Customer");
                }
            }


            strEmail = "ahick@yaho.com";

            AppUser customer14 = new AppUser()
            {
                UserName = "ahick@yaho.com",
                Email = "ahick@yaho.com",
                PhoneNumber = "1211949601",
                FirstName = "Anthony",
                LastName = "Hicks",
                Address = "932 Monica Way",
                ZipCode = "78734"
            };

            AppUser dbUser14 = await userManager.FindByEmailAsync("ahick@yaho.com");

            if (dbUser14 == null)
            {
                IdentityResult result14 = await userManager.CreateAsync(customer14, "hickhickup");

                if (result14.Succeeded == false)
                {
                    String errors14 = "";

                    foreach (IdentityError error in result14.Errors)
                    {
                        errors14 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (ahick@yaho.com): " + errors14);
                }

                dbUser14 = await userManager.FindByEmailAsync("ahick@yaho.com");
                await userManager.AddToRoleAsync(dbUser14, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser14.UserName = "ahick@yaho.com";
                dbUser14.Email = "ahick@yaho.com";
                dbUser14.PhoneNumber = "1211949601";
                dbUser14.FirstName = "Anthony";
                dbUser14.LastName = "Hicks";
                dbUser14.Address = "932 Monica Way";
                dbUser14.ZipCode = "78734";

                await userManager.UpdateAsync(dbUser14);

                if (await userManager.IsInRoleAsync(dbUser14, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser14, "Customer");
                }
            }


            strEmail = "ingram@jack.com";

            AppUser customer15 = new AppUser()
            {
                UserName = "ingram@jack.com",
                Email = "ingram@jack.com",
                PhoneNumber = "1372121569",
                FirstName = "Brad",
                LastName = "Ingram",
                Address = "4 Lukken Court",
                ZipCode = "78735"
            };

            AppUser dbUser15 = await userManager.FindByEmailAsync("ingram@jack.com");

            if (dbUser15 == null)
            {
                IdentityResult result15 = await userManager.CreateAsync(customer15, "ingram2015");

                if (result15.Succeeded == false)
                {
                    String errors15 = "";

                    foreach (IdentityError error in result15.Errors)
                    {
                        errors15 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (ingram@jack.com): " + errors15);
                }

                dbUser15 = await userManager.FindByEmailAsync("ingram@jack.com");
                await userManager.AddToRoleAsync(dbUser15, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser15.UserName = "ingram@jack.com";
                dbUser15.Email = "ingram@jack.com";
                dbUser15.PhoneNumber = "1372121569";
                dbUser15.FirstName = "Brad";
                dbUser15.LastName = "Ingram";
                dbUser15.Address = "4 Lukken Court";
                dbUser15.ZipCode = "78735";

                await userManager.UpdateAsync(dbUser15);

                if (await userManager.IsInRoleAsync(dbUser15, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser15, "Customer");
                }
            }


            strEmail = "toddj@yourmom.com";

            AppUser customer16 = new AppUser()
            {
                UserName = "toddj@yourmom.com",
                Email = "toddj@yourmom.com",
                PhoneNumber = "8543163836",
                FirstName = "Todd",
                LastName = "Jacobs",
                Address = "7 Susan Junction",
                ZipCode = "78736"
            };

            AppUser dbUser16 = await userManager.FindByEmailAsync("toddj@yourmom.com");

            if (dbUser16 == null)
            {
                IdentityResult result16 = await userManager.CreateAsync(customer16, "toddy25");

                if (result16.Succeeded == false)
                {
                    String errors16 = "";

                    foreach (IdentityError error in result16.Errors)
                    {
                        errors16 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (toddj@yourmom.com): " + errors16);
                }

                dbUser16 = await userManager.FindByEmailAsync("toddj@yourmom.com");
                await userManager.AddToRoleAsync(dbUser16, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser16.UserName = "toddj@yourmom.com";
                dbUser16.Email = "toddj@yourmom.com";
                dbUser16.PhoneNumber = "8543163836";
                dbUser16.FirstName = "Todd";
                dbUser16.LastName = "Jacobs";
                dbUser16.Address = "7 Susan Junction";
                dbUser16.ZipCode = "78736";

                await userManager.UpdateAsync(dbUser16);

                if (await userManager.IsInRoleAsync(dbUser16, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser16, "Customer");
                }
            }


            strEmail = "thequeen@aska.net";

            AppUser customer17 = new AppUser()
            {
                UserName = "thequeen@aska.net",
                Email = "thequeen@aska.net",
                PhoneNumber = "3214163359",
                FirstName = "Victoria",
                LastName = "Lawrence",
                Address = "669 Oak Junction",
                ZipCode = "78737"
            };

            AppUser dbUser17 = await userManager.FindByEmailAsync("thequeen@aska.net");

            if (dbUser17 == null)
            {
                IdentityResult result17 = await userManager.CreateAsync(customer17, "something");

                if (result17.Succeeded == false)
                {
                    String errors17 = "";

                    foreach (IdentityError error in result17.Errors)
                    {
                        errors17 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (thequeen@aska.net): " + errors17);
                }

                dbUser17 = await userManager.FindByEmailAsync("thequeen@aska.net");
                await userManager.AddToRoleAsync(dbUser17, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser17.UserName = "thequeen@aska.net";
                dbUser17.Email = "thequeen@aska.net";
                dbUser17.PhoneNumber = "3214163359";
                dbUser17.FirstName = "Victoria";
                dbUser17.LastName = "Lawrence";
                dbUser17.Address = "669 Oak Junction";
                dbUser17.ZipCode = "78737";

                await userManager.UpdateAsync(dbUser17);

                if (await userManager.IsInRoleAsync(dbUser17, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser17, "Customer");
                }
            }


            strEmail = "linebacker@gogle.com";

            AppUser customer18 = new AppUser()
            {
                UserName = "linebacker@gogle.com",
                Email = "linebacker@gogle.com",
                PhoneNumber = "2505265350",
                FirstName = "Erik",
                LastName = "Lineback",
                Address = "099 Luster Point",
                ZipCode = "78738"
            };

            AppUser dbUser18 = await userManager.FindByEmailAsync("linebacker@gogle.com");

            if (dbUser18 == null)
            {
                IdentityResult result18 = await userManager.CreateAsync(customer18, "Password1");

                if (result18.Succeeded == false)
                {
                    String errors18 = "";

                    foreach (IdentityError error in result18.Errors)
                    {
                        errors18 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (linebacker@gogle.com): " + errors18);
                }

                dbUser18 = await userManager.FindByEmailAsync("linebacker@gogle.com");
                await userManager.AddToRoleAsync(dbUser18, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser18.UserName = "linebacker@gogle.com";
                dbUser18.Email = "linebacker@gogle.com";
                dbUser18.PhoneNumber = "2505265350";
                dbUser18.FirstName = "Erik";
                dbUser18.LastName = "Lineback";
                dbUser18.Address = "099 Luster Point";
                dbUser18.ZipCode = "78738";

                await userManager.UpdateAsync(dbUser18);

                if (await userManager.IsInRoleAsync(dbUser18, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser18, "Customer");
                }
            }


            strEmail = "elowe@scare.net";

            AppUser customer19 = new AppUser()
            {
                UserName = "elowe@scare.net",
                Email = "elowe@scare.net",
                PhoneNumber = "4070619503",
                FirstName = "Ernest",
                LastName = "Lowe",
                Address = "35473 Hansons Hill",
                ZipCode = "78741"
            };

            AppUser dbUser19 = await userManager.FindByEmailAsync("elowe@scare.net");

            if (dbUser19 == null)
            {
                IdentityResult result19 = await userManager.CreateAsync(customer19, "aclfest2017");

                if (result19.Succeeded == false)
                {
                    String errors19 = "";

                    foreach (IdentityError error in result19.Errors)
                    {
                        errors19 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (elowe@scare.net): " + errors19);
                }

                dbUser19 = await userManager.FindByEmailAsync("elowe@scare.net");
                await userManager.AddToRoleAsync(dbUser19, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser19.UserName = "elowe@scare.net";
                dbUser19.Email = "elowe@scare.net";
                dbUser19.PhoneNumber = "4070619503";
                dbUser19.FirstName = "Ernest";
                dbUser19.LastName = "Lowe";
                dbUser19.Address = "35473 Hansons Hill";
                dbUser19.ZipCode = "78741";

                await userManager.UpdateAsync(dbUser19);

                if (await userManager.IsInRoleAsync(dbUser19, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser19, "Customer");
                }
            }


            strEmail = "cluce@gogle.com";

            AppUser customer20 = new AppUser()
            {
                UserName = "cluce@gogle.com",
                Email = "cluce@gogle.com",
                PhoneNumber = "7358436110",
                FirstName = "Chuck",
                LastName = "Luce",
                Address = "4 Emmet Junction",
                ZipCode = "78744"
            };

            AppUser dbUser20 = await userManager.FindByEmailAsync("cluce@gogle.com");

            if (dbUser20 == null)
            {
                IdentityResult result20 = await userManager.CreateAsync(customer20, "nothinggood");

                if (result20.Succeeded == false)
                {
                    String errors20 = "";

                    foreach (IdentityError error in result20.Errors)
                    {
                        errors20 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (cluce@gogle.com): " + errors20);
                }

                dbUser20 = await userManager.FindByEmailAsync("cluce@gogle.com");
                await userManager.AddToRoleAsync(dbUser20, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser20.UserName = "cluce@gogle.com";
                dbUser20.Email = "cluce@gogle.com";
                dbUser20.PhoneNumber = "7358436110";
                dbUser20.FirstName = "Chuck";
                dbUser20.LastName = "Luce";
                dbUser20.Address = "4 Emmet Junction";
                dbUser20.ZipCode = "78744";

                await userManager.UpdateAsync(dbUser20);

                if (await userManager.IsInRoleAsync(dbUser20, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser20, "Customer");
                }
            }


            strEmail = "mackcloud@g.com";

            AppUser customer21 = new AppUser()
            {
                UserName = "mackcloud@g.com",
                Email = "mackcloud@g.com",
                PhoneNumber = "7240178229",
                FirstName = "Jennifer",
                LastName = "MacLeod",
                Address = "3 Orin Road",
                ZipCode = "78745"
            };

            AppUser dbUser21 = await userManager.FindByEmailAsync("mackcloud@g.com");

            if (dbUser21 == null)
            {
                IdentityResult result21 = await userManager.CreateAsync(customer21, "whatever");

                if (result21.Succeeded == false)
                {
                    String errors21 = "";

                    foreach (IdentityError error in result21.Errors)
                    {
                        errors21 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (mackcloud@g.com): " + errors21);
                }

                dbUser21 = await userManager.FindByEmailAsync("mackcloud@g.com");
                await userManager.AddToRoleAsync(dbUser21, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser21.UserName = "mackcloud@g.com";
                dbUser21.Email = "mackcloud@g.com";
                dbUser21.PhoneNumber = "7240178229";
                dbUser21.FirstName = "Jennifer";
                dbUser21.LastName = "MacLeod";
                dbUser21.Address = "3 Orin Road";
                dbUser21.ZipCode = "78745";

                await userManager.UpdateAsync(dbUser21);

                if (await userManager.IsInRoleAsync(dbUser21, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser21, "Customer");
                }
            }


            strEmail = "cmartin@beets.com";

            AppUser customer22 = new AppUser()
            {
                UserName = "cmartin@beets.com",
                Email = "cmartin@beets.com",
                PhoneNumber = "2495200223",
                FirstName = "Elizabeth",
                LastName = "Markham",
                Address = "8171 Commercial Crossing",
                ZipCode = "78746"
            };

            AppUser dbUser22 = await userManager.FindByEmailAsync("cmartin@beets.com");

            if (dbUser22 == null)
            {
                IdentityResult result22 = await userManager.CreateAsync(customer22, "snowsnow");

                if (result22.Succeeded == false)
                {
                    String errors22 = "";

                    foreach (IdentityError error in result22.Errors)
                    {
                        errors22 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (cmartin@beets.com): " + errors22);
                }

                dbUser22 = await userManager.FindByEmailAsync("cmartin@beets.com");
                await userManager.AddToRoleAsync(dbUser22, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser22.UserName = "cmartin@beets.com";
                dbUser22.Email = "cmartin@beets.com";
                dbUser22.PhoneNumber = "2495200223";
                dbUser22.FirstName = "Elizabeth";
                dbUser22.LastName = "Markham";
                dbUser22.Address = "8171 Commercial Crossing";
                dbUser22.ZipCode = "78746";

                await userManager.UpdateAsync(dbUser22);

                if (await userManager.IsInRoleAsync(dbUser22, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser22, "Customer");
                }
            }


            strEmail = "clarence@yoho.com";

            AppUser customer23 = new AppUser()
            {
                UserName = "clarence@yoho.com",
                Email = "clarence@yoho.com",
                PhoneNumber = "4086179161",
                FirstName = "Clarence",
                LastName = "Martin",
                Address = "96 Anthes Place",
                ZipCode = "78748"
            };

            AppUser dbUser23 = await userManager.FindByEmailAsync("clarence@yoho.com");

            if (dbUser23 == null)
            {
                IdentityResult result23 = await userManager.CreateAsync(customer23, "whocares");

                if (result23.Succeeded == false)
                {
                    String errors23 = "";

                    foreach (IdentityError error in result23.Errors)
                    {
                        errors23 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (clarence@yoho.com): " + errors23);
                }

                dbUser23 = await userManager.FindByEmailAsync("clarence@yoho.com");
                await userManager.AddToRoleAsync(dbUser23, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser23.UserName = "clarence@yoho.com";
                dbUser23.Email = "clarence@yoho.com";
                dbUser23.PhoneNumber = "4086179161";
                dbUser23.FirstName = "Clarence";
                dbUser23.LastName = "Martin";
                dbUser23.Address = "96 Anthes Place";
                dbUser23.ZipCode = "78748";

                await userManager.UpdateAsync(dbUser23);

                if (await userManager.IsInRoleAsync(dbUser23, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser23, "Customer");
                }
            }


            strEmail = "gregmartinez@dr.com";

            AppUser customer24 = new AppUser()
            {
                UserName = "gregmartinez@dr.com",
                Email = "gregmartinez@dr.com",
                PhoneNumber = "9371927523",
                FirstName = "Gregory",
                LastName = "Martinez",
                Address = "10 Northridge Plaza",
                ZipCode = "78749"
            };

            AppUser dbUser24 = await userManager.FindByEmailAsync("gregmartinez@dr.com");

            if (dbUser24 == null)
            {
                IdentityResult result24 = await userManager.CreateAsync(customer24, "xcellent");

                if (result24.Succeeded == false)
                {
                    String errors24 = "";

                    foreach (IdentityError error in result24.Errors)
                    {
                        errors24 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (gregmartinez@dr.com): " + errors24);
                }

                dbUser24 = await userManager.FindByEmailAsync("gregmartinez@dr.com");
                await userManager.AddToRoleAsync(dbUser24, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser24.UserName = "gregmartinez@dr.com";
                dbUser24.Email = "gregmartinez@dr.com";
                dbUser24.PhoneNumber = "9371927523";
                dbUser24.FirstName = "Gregory";
                dbUser24.LastName = "Martinez";
                dbUser24.Address = "10 Northridge Plaza";
                dbUser24.ZipCode = "78749";

                await userManager.UpdateAsync(dbUser24);

                if (await userManager.IsInRoleAsync(dbUser24, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser24, "Customer");
                }
            }


            strEmail = "cmiller@bob.com";

            AppUser customer25 = new AppUser()
            {
                UserName = "cmiller@bob.com",
                Email = "cmiller@bob.com",
                PhoneNumber = "5954063857",
                FirstName = "Charles",
                LastName = "Miller",
                Address = "87683 Schmedeman Circle",
                ZipCode = "78750"
            };

            AppUser dbUser25 = await userManager.FindByEmailAsync("cmiller@bob.com");

            if (dbUser25 == null)
            {
                IdentityResult result25 = await userManager.CreateAsync(customer25, "mydogspot");

                if (result25.Succeeded == false)
                {
                    String errors25 = "";

                    foreach (IdentityError error in result25.Errors)
                    {
                        errors25 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (cmiller@bob.com): " + errors25);
                }

                dbUser25 = await userManager.FindByEmailAsync("cmiller@bob.com");
                await userManager.AddToRoleAsync(dbUser25, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser25.UserName = "cmiller@bob.com";
                dbUser25.Email = "cmiller@bob.com";
                dbUser25.PhoneNumber = "5954063857";
                dbUser25.FirstName = "Charles";
                dbUser25.LastName = "Miller";
                dbUser25.Address = "87683 Schmedeman Circle";
                dbUser25.ZipCode = "78750";

                await userManager.UpdateAsync(dbUser25);

                if (await userManager.IsInRoleAsync(dbUser25, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser25, "Customer");
                }
            }


            strEmail = "knelson@aoll.com";

            AppUser customer26 = new AppUser()
            {
                UserName = "knelson@aoll.com",
                Email = "knelson@aoll.com",
                PhoneNumber = "8929209512",
                FirstName = "Kelly",
                LastName = "Nelson",
                Address = "3244 Ludington Court",
                ZipCode = "77002"
            };

            AppUser dbUser26 = await userManager.FindByEmailAsync("knelson@aoll.com");

            if (dbUser26 == null)
            {
                IdentityResult result26 = await userManager.CreateAsync(customer26, "spotmydog");

                if (result26.Succeeded == false)
                {
                    String errors26 = "";

                    foreach (IdentityError error in result26.Errors)
                    {
                        errors26 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (knelson@aoll.com): " + errors26);
                }

                dbUser26 = await userManager.FindByEmailAsync("knelson@aoll.com");
                await userManager.AddToRoleAsync(dbUser26, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser26.UserName = "knelson@aoll.com";
                dbUser26.Email = "knelson@aoll.com";
                dbUser26.PhoneNumber = "8929209512";
                dbUser26.FirstName = "Kelly";
                dbUser26.LastName = "Nelson";
                dbUser26.Address = "3244 Ludington Court";
                dbUser26.ZipCode = "77002";

                await userManager.UpdateAsync(dbUser26);

                if (await userManager.IsInRoleAsync(dbUser26, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser26, "Customer");
                }
            }


            strEmail = "joewin@factor.com";

            AppUser customer27 = new AppUser()
            {
                UserName = "joewin@factor.com",
                Email = "joewin@factor.com",
                PhoneNumber = "9226301774",
                FirstName = "Joe",
                LastName = "Nguyen",
                Address = "4780 Talisman Court",
                ZipCode = "77005"
            };

            AppUser dbUser27 = await userManager.FindByEmailAsync("joewin@factor.com");

            if (dbUser27 == null)
            {
                IdentityResult result27 = await userManager.CreateAsync(customer27, "joejoejoe");

                if (result27.Succeeded == false)
                {
                    String errors27 = "";

                    foreach (IdentityError error in result27.Errors)
                    {
                        errors27 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (joewin@factor.com): " + errors27);
                }

                dbUser27 = await userManager.FindByEmailAsync("joewin@factor.com");
                await userManager.AddToRoleAsync(dbUser27, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser27.UserName = "joewin@factor.com";
                dbUser27.Email = "joewin@factor.com";
                dbUser27.PhoneNumber = "9226301774";
                dbUser27.FirstName = "Joe";
                dbUser27.LastName = "Nguyen";
                dbUser27.Address = "4780 Talisman Court";
                dbUser27.ZipCode = "77005";

                await userManager.UpdateAsync(dbUser27);

                if (await userManager.IsInRoleAsync(dbUser27, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser27, "Customer");
                }
            }


            strEmail = "orielly@fox.cnn";

            AppUser customer28 = new AppUser()
            {
                UserName = "orielly@fox.cnn",
                Email = "orielly@fox.cnn",
                PhoneNumber = "2537646912",
                FirstName = "Bill",
                LastName = "O'Reilly",
                Address = "4154 Delladonna Plaza",
                ZipCode = "75201"
            };

            AppUser dbUser28 = await userManager.FindByEmailAsync("orielly@fox.cnn");

            if (dbUser28 == null)
            {
                IdentityResult result28 = await userManager.CreateAsync(customer28, "billyboy");

                if (result28.Succeeded == false)
                {
                    String errors28 = "";

                    foreach (IdentityError error in result28.Errors)
                    {
                        errors28 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (orielly@fox.cnn): " + errors28);
                }

                dbUser28 = await userManager.FindByEmailAsync("orielly@fox.cnn");
                await userManager.AddToRoleAsync(dbUser28, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser28.UserName = "orielly@fox.cnn";
                dbUser28.Email = "orielly@fox.cnn";
                dbUser28.PhoneNumber = "2537646912";
                dbUser28.FirstName = "Bill";
                dbUser28.LastName = "O'Reilly";
                dbUser28.Address = "4154 Delladonna Plaza";
                dbUser28.ZipCode = "75201";

                await userManager.UpdateAsync(dbUser28);

                if (await userManager.IsInRoleAsync(dbUser28, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser28, "Customer");
                }
            }


            strEmail = "ankaisrad@gogle.com";

            AppUser customer29 = new AppUser()
            {
                UserName = "ankaisrad@gogle.com",
                Email = "ankaisrad@gogle.com",
                PhoneNumber = "2182889379",
                FirstName = "Anka",
                LastName = "Radkovich",
                Address = "72361 Bayside Drive",
                ZipCode = "75204"
            };

            AppUser dbUser29 = await userManager.FindByEmailAsync("ankaisrad@gogle.com");

            if (dbUser29 == null)
            {
                IdentityResult result29 = await userManager.CreateAsync(customer29, "radgirl");

                if (result29.Succeeded == false)
                {
                    String errors29 = "";

                    foreach (IdentityError error in result29.Errors)
                    {
                        errors29 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (ankaisrad@gogle.com): " + errors29);
                }

                dbUser29 = await userManager.FindByEmailAsync("ankaisrad@gogle.com");
                await userManager.AddToRoleAsync(dbUser29, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser29.UserName = "ankaisrad@gogle.com";
                dbUser29.Email = "ankaisrad@gogle.com";
                dbUser29.PhoneNumber = "2182889379";
                dbUser29.FirstName = "Anka";
                dbUser29.LastName = "Radkovich";
                dbUser29.Address = "72361 Bayside Drive";
                dbUser29.ZipCode = "75204";

                await userManager.UpdateAsync(dbUser29);

                if (await userManager.IsInRoleAsync(dbUser29, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser29, "Customer");
                }
            }


            strEmail = "megrhodes@co.uk";

            AppUser customer30 = new AppUser()
            {
                UserName = "megrhodes@co.uk",
                Email = "megrhodes@co.uk",
                PhoneNumber = "9532396075",
                FirstName = "Megan",
                LastName = "Rhodes",
                Address = "76875 Hoffman Point",
                ZipCode = "78205"
            };

            AppUser dbUser30 = await userManager.FindByEmailAsync("megrhodes@co.uk");

            if (dbUser30 == null)
            {
                IdentityResult result30 = await userManager.CreateAsync(customer30, "meganr34");

                if (result30.Succeeded == false)
                {
                    String errors30 = "";

                    foreach (IdentityError error in result30.Errors)
                    {
                        errors30 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (megrhodes@co.uk): " + errors30);
                }

                dbUser30 = await userManager.FindByEmailAsync("megrhodes@co.uk");
                await userManager.AddToRoleAsync(dbUser30, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser30.UserName = "megrhodes@co.uk";
                dbUser30.Email = "megrhodes@co.uk";
                dbUser30.PhoneNumber = "9532396075";
                dbUser30.FirstName = "Megan";
                dbUser30.LastName = "Rhodes";
                dbUser30.Address = "76875 Hoffman Point";
                dbUser30.ZipCode = "78205";

                await userManager.UpdateAsync(dbUser30);

                if (await userManager.IsInRoleAsync(dbUser30, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser30, "Customer");
                }
            }


            strEmail = "erynrice@aoll.com";

            AppUser customer31 = new AppUser()
            {
                UserName = "erynrice@aoll.com",
                Email = "erynrice@aoll.com",
                PhoneNumber = "7303815953",
                FirstName = "Eryn",
                LastName = "Rice",
                Address = "048 Elmside Park",
                ZipCode = "78209"
            };

            AppUser dbUser31 = await userManager.FindByEmailAsync("erynrice@aoll.com");

            if (dbUser31 == null)
            {
                IdentityResult result31 = await userManager.CreateAsync(customer31, "ricearoni");

                if (result31.Succeeded == false)
                {
                    String errors31 = "";

                    foreach (IdentityError error in result31.Errors)
                    {
                        errors31 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (erynrice@aoll.com): " + errors31);
                }

                dbUser31 = await userManager.FindByEmailAsync("erynrice@aoll.com");
                await userManager.AddToRoleAsync(dbUser31, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser31.UserName = "erynrice@aoll.com";
                dbUser31.Email = "erynrice@aoll.com";
                dbUser31.PhoneNumber = "7303815953";
                dbUser31.FirstName = "Eryn";
                dbUser31.LastName = "Rice";
                dbUser31.Address = "048 Elmside Park";
                dbUser31.ZipCode = "78209";

                await userManager.UpdateAsync(dbUser31);

                if (await userManager.IsInRoleAsync(dbUser31, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser31, "Customer");
                }
            }


            strEmail = "jorge@noclue.com";

            AppUser customer32 = new AppUser()
            {
                UserName = "jorge@noclue.com",
                Email = "jorge@noclue.com",
                PhoneNumber = "3677322422",
                FirstName = "Jorge",
                LastName = "Rodriguez",
                Address = "01 Browning Pass",
                ZipCode = "76102"
            };

            AppUser dbUser32 = await userManager.FindByEmailAsync("jorge@noclue.com");

            if (dbUser32 == null)
            {
                IdentityResult result32 = await userManager.CreateAsync(customer32, "alaskaboy");

                if (result32.Succeeded == false)
                {
                    String errors32 = "";

                    foreach (IdentityError error in result32.Errors)
                    {
                        errors32 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (jorge@noclue.com): " + errors32);
                }

                dbUser32 = await userManager.FindByEmailAsync("jorge@noclue.com");
                await userManager.AddToRoleAsync(dbUser32, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser32.UserName = "jorge@noclue.com";
                dbUser32.Email = "jorge@noclue.com";
                dbUser32.PhoneNumber = "3677322422";
                dbUser32.FirstName = "Jorge";
                dbUser32.LastName = "Rodriguez";
                dbUser32.Address = "01 Browning Pass";
                dbUser32.ZipCode = "76102";

                await userManager.UpdateAsync(dbUser32);

                if (await userManager.IsInRoleAsync(dbUser32, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser32, "Customer");
                }
            }


            strEmail = "mrrogers@day.com";

            AppUser customer33 = new AppUser()
            {
                UserName = "mrrogers@day.com",
                Email = "mrrogers@day.com",
                PhoneNumber = "3911705385",
                FirstName = "Allen",
                LastName = "Rogers",
                Address = "844 Anderson Alley",
                ZipCode = "75024"
            };

            AppUser dbUser33 = await userManager.FindByEmailAsync("mrrogers@day.com");

            if (dbUser33 == null)
            {
                IdentityResult result33 = await userManager.CreateAsync(customer33, "bunnyhop");

                if (result33.Succeeded == false)
                {
                    String errors33 = "";

                    foreach (IdentityError error in result33.Errors)
                    {
                        errors33 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (mrrogers@day.com): " + errors33);
                }

                dbUser33 = await userManager.FindByEmailAsync("mrrogers@day.com");
                await userManager.AddToRoleAsync(dbUser33, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser33.UserName = "mrrogers@day.com";
                dbUser33.Email = "mrrogers@day.com";
                dbUser33.PhoneNumber = "3911705385";
                dbUser33.FirstName = "Allen";
                dbUser33.LastName = "Rogers";
                dbUser33.Address = "844 Anderson Alley";
                dbUser33.ZipCode = "75024";

                await userManager.UpdateAsync(dbUser33);

                if (await userManager.IsInRoleAsync(dbUser33, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser33, "Customer");
                }
            }


            strEmail = "stjean@athome.com";

            AppUser customer34 = new AppUser()
            {
                UserName = "stjean@athome.com",
                Email = "stjean@athome.com",
                PhoneNumber = "7351610920",
                FirstName = "Olivier",
                LastName = "Saint-Jean",
                Address = "1891 Docker Point",
                ZipCode = "79901"
            };

            AppUser dbUser34 = await userManager.FindByEmailAsync("stjean@athome.com");

            if (dbUser34 == null)
            {
                IdentityResult result34 = await userManager.CreateAsync(customer34, "dustydusty");

                if (result34.Succeeded == false)
                {
                    String errors34 = "";

                    foreach (IdentityError error in result34.Errors)
                    {
                        errors34 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (stjean@athome.com): " + errors34);
                }

                dbUser34 = await userManager.FindByEmailAsync("stjean@athome.com");
                await userManager.AddToRoleAsync(dbUser34, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser34.UserName = "stjean@athome.com";
                dbUser34.Email = "stjean@athome.com";
                dbUser34.PhoneNumber = "7351610920";
                dbUser34.FirstName = "Olivier";
                dbUser34.LastName = "Saint-Jean";
                dbUser34.Address = "1891 Docker Point";
                dbUser34.ZipCode = "79901";

                await userManager.UpdateAsync(dbUser34);

                if (await userManager.IsInRoleAsync(dbUser34, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser34, "Customer");
                }
            }


            strEmail = "saunders@pen.com";

            AppUser customer35 = new AppUser()
            {
                UserName = "saunders@pen.com",
                Email = "saunders@pen.com",
                PhoneNumber = "5269661692",
                FirstName = "Sarah",
                LastName = "Saunders",
                Address = "1469 Upham Road",
                ZipCode = "78401"
            };

            AppUser dbUser35 = await userManager.FindByEmailAsync("saunders@pen.com");

            if (dbUser35 == null)
            {
                IdentityResult result35 = await userManager.CreateAsync(customer35, "jrod2017");

                if (result35.Succeeded == false)
                {
                    String errors35 = "";

                    foreach (IdentityError error in result35.Errors)
                    {
                        errors35 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (saunders@pen.com): " + errors35);
                }

                dbUser35 = await userManager.FindByEmailAsync("saunders@pen.com");
                await userManager.AddToRoleAsync(dbUser35, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser35.UserName = "saunders@pen.com";
                dbUser35.Email = "saunders@pen.com";
                dbUser35.PhoneNumber = "5269661692";
                dbUser35.FirstName = "Sarah";
                dbUser35.LastName = "Saunders";
                dbUser35.Address = "1469 Upham Road";
                dbUser35.ZipCode = "78401";

                await userManager.UpdateAsync(dbUser35);

                if (await userManager.IsInRoleAsync(dbUser35, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser35, "Customer");
                }
            }


            strEmail = "willsheff@email.com";

            AppUser customer36 = new AppUser()
            {
                UserName = "willsheff@email.com",
                Email = "willsheff@email.com",
                PhoneNumber = "1875727246",
                FirstName = "William",
                LastName = "Sewell",
                Address = "1672 Oak Valley Circle",
                ZipCode = "90001"
            };

            AppUser dbUser36 = await userManager.FindByEmailAsync("willsheff@email.com");

            if (dbUser36 == null)
            {
                IdentityResult result36 = await userManager.CreateAsync(customer36, "martin1234");

                if (result36.Succeeded == false)
                {
                    String errors36 = "";

                    foreach (IdentityError error in result36.Errors)
                    {
                        errors36 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (willsheff@email.com): " + errors36);
                }

                dbUser36 = await userManager.FindByEmailAsync("willsheff@email.com");
                await userManager.AddToRoleAsync(dbUser36, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser36.UserName = "willsheff@email.com";
                dbUser36.Email = "willsheff@email.com";
                dbUser36.PhoneNumber = "1875727246";
                dbUser36.FirstName = "William";
                dbUser36.LastName = "Sewell";
                dbUser36.Address = "1672 Oak Valley Circle";
                dbUser36.ZipCode = "90001";

                await userManager.UpdateAsync(dbUser36);

                if (await userManager.IsInRoleAsync(dbUser36, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser36, "Customer");
                }
            }


            strEmail = "sheffiled@gogle.com";

            AppUser customer37 = new AppUser()
            {
                UserName = "sheffiled@gogle.com",
                Email = "sheffiled@gogle.com",
                PhoneNumber = "1394323615",
                FirstName = "Martin",
                LastName = "Sheffield",
                Address = "816 Kennedy Place",
                ZipCode = "90017"
            };

            AppUser dbUser37 = await userManager.FindByEmailAsync("sheffiled@gogle.com");

            if (dbUser37 == null)
            {
                IdentityResult result37 = await userManager.CreateAsync(customer37, "penguin12");

                if (result37.Succeeded == false)
                {
                    String errors37 = "";

                    foreach (IdentityError error in result37.Errors)
                    {
                        errors37 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (sheffiled@gogle.com): " + errors37);
                }

                dbUser37 = await userManager.FindByEmailAsync("sheffiled@gogle.com");
                await userManager.AddToRoleAsync(dbUser37, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser37.UserName = "sheffiled@gogle.com";
                dbUser37.Email = "sheffiled@gogle.com";
                dbUser37.PhoneNumber = "1394323615";
                dbUser37.FirstName = "Martin";
                dbUser37.LastName = "Sheffield";
                dbUser37.Address = "816 Kennedy Place";
                dbUser37.ZipCode = "90017";

                await userManager.UpdateAsync(dbUser37);

                if (await userManager.IsInRoleAsync(dbUser37, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser37, "Customer");
                }
            }


            strEmail = "johnsmith187@aoll.com";

            AppUser customer38 = new AppUser()
            {
                UserName = "johnsmith187@aoll.com",
                Email = "johnsmith187@aoll.com",
                PhoneNumber = "6645937874",
                FirstName = "John",
                LastName = "Smith",
                Address = "0745 Golf Road",
                ZipCode = "94102"
            };

            AppUser dbUser38 = await userManager.FindByEmailAsync("johnsmith187@aoll.com");

            if (dbUser38 == null)
            {
                IdentityResult result38 = await userManager.CreateAsync(customer38, "rogerthat");

                if (result38.Succeeded == false)
                {
                    String errors38 = "";

                    foreach (IdentityError error in result38.Errors)
                    {
                        errors38 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (johnsmith187@aoll.com): " + errors38);
                }

                dbUser38 = await userManager.FindByEmailAsync("johnsmith187@aoll.com");
                await userManager.AddToRoleAsync(dbUser38, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser38.UserName = "johnsmith187@aoll.com";
                dbUser38.Email = "johnsmith187@aoll.com";
                dbUser38.PhoneNumber = "6645937874";
                dbUser38.FirstName = "John";
                dbUser38.LastName = "Smith";
                dbUser38.Address = "0745 Golf Road";
                dbUser38.ZipCode = "94102";

                await userManager.UpdateAsync(dbUser38);

                if (await userManager.IsInRoleAsync(dbUser38, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser38, "Customer");
                }
            }


            strEmail = "dustroud@mail.com";

            AppUser customer39 = new AppUser()
            {
                UserName = "dustroud@mail.com",
                Email = "dustroud@mail.com",
                PhoneNumber = "6470254680",
                FirstName = "Dustin",
                LastName = "Stroud",
                Address = "505 Dexter Plaza",
                ZipCode = "92101"
            };

            AppUser dbUser39 = await userManager.FindByEmailAsync("dustroud@mail.com");

            if (dbUser39 == null)
            {
                IdentityResult result39 = await userManager.CreateAsync(customer39, "smitty444");

                if (result39.Succeeded == false)
                {
                    String errors39 = "";

                    foreach (IdentityError error in result39.Errors)
                    {
                        errors39 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (dustroud@mail.com): " + errors39);
                }

                dbUser39 = await userManager.FindByEmailAsync("dustroud@mail.com");
                await userManager.AddToRoleAsync(dbUser39, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser39.UserName = "dustroud@mail.com";
                dbUser39.Email = "dustroud@mail.com";
                dbUser39.PhoneNumber = "6470254680";
                dbUser39.FirstName = "Dustin";
                dbUser39.LastName = "Stroud";
                dbUser39.Address = "505 Dexter Plaza";
                dbUser39.ZipCode = "92101";

                await userManager.UpdateAsync(dbUser39);

                if (await userManager.IsInRoleAsync(dbUser39, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser39, "Customer");
                }
            }


            strEmail = "estuart@anchor.net";

            AppUser customer40 = new AppUser()
            {
                UserName = "estuart@anchor.net",
                Email = "estuart@anchor.net",
                PhoneNumber = "7701621022",
                FirstName = "Eric",
                LastName = "Stuart",
                Address = "585 Claremont Drive",
                ZipCode = "95814"
            };

            AppUser dbUser40 = await userManager.FindByEmailAsync("estuart@anchor.net");

            if (dbUser40 == null)
            {
                IdentityResult result40 = await userManager.CreateAsync(customer40, "stewball");

                if (result40.Succeeded == false)
                {
                    String errors40 = "";

                    foreach (IdentityError error in result40.Errors)
                    {
                        errors40 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (estuart@anchor.net): " + errors40);
                }

                dbUser40 = await userManager.FindByEmailAsync("estuart@anchor.net");
                await userManager.AddToRoleAsync(dbUser40, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser40.UserName = "estuart@anchor.net";
                dbUser40.Email = "estuart@anchor.net";
                dbUser40.PhoneNumber = "7701621022";
                dbUser40.FirstName = "Eric";
                dbUser40.LastName = "Stuart";
                dbUser40.Address = "585 Claremont Drive";
                dbUser40.ZipCode = "95814";

                await userManager.UpdateAsync(dbUser40);

                if (await userManager.IsInRoleAsync(dbUser40, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser40, "Customer");
                }
            }


            strEmail = "peterstump@noclue.com";

            AppUser customer41 = new AppUser()
            {
                UserName = "peterstump@noclue.com",
                Email = "peterstump@noclue.com",
                PhoneNumber = "2181960061",
                FirstName = "Peter",
                LastName = "Stump",
                Address = "89035 Welch Circle",
                ZipCode = "10001"
            };

            AppUser dbUser41 = await userManager.FindByEmailAsync("peterstump@noclue.com");

            if (dbUser41 == null)
            {
                IdentityResult result41 = await userManager.CreateAsync(customer41, "slowwind");

                if (result41.Succeeded == false)
                {
                    String errors41 = "";

                    foreach (IdentityError error in result41.Errors)
                    {
                        errors41 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (peterstump@noclue.com): " + errors41);
                }

                dbUser41 = await userManager.FindByEmailAsync("peterstump@noclue.com");
                await userManager.AddToRoleAsync(dbUser41, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser41.UserName = "peterstump@noclue.com";
                dbUser41.Email = "peterstump@noclue.com";
                dbUser41.PhoneNumber = "2181960061";
                dbUser41.FirstName = "Peter";
                dbUser41.LastName = "Stump";
                dbUser41.Address = "89035 Welch Circle";
                dbUser41.ZipCode = "10001";

                await userManager.UpdateAsync(dbUser41);

                if (await userManager.IsInRoleAsync(dbUser41, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser41, "Customer");
                }
            }


            strEmail = "jtanner@mustang.net";

            AppUser customer42 = new AppUser()
            {
                UserName = "jtanner@mustang.net",
                Email = "jtanner@mustang.net",
                PhoneNumber = "9908469499",
                FirstName = "Jeremy",
                LastName = "Tanner",
                Address = "4 Stang Trail",
                ZipCode = "10019"
            };

            AppUser dbUser42 = await userManager.FindByEmailAsync("jtanner@mustang.net");

            if (dbUser42 == null)
            {
                IdentityResult result42 = await userManager.CreateAsync(customer42, "tanner5454");

                if (result42.Succeeded == false)
                {
                    String errors42 = "";

                    foreach (IdentityError error in result42.Errors)
                    {
                        errors42 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (jtanner@mustang.net): " + errors42);
                }

                dbUser42 = await userManager.FindByEmailAsync("jtanner@mustang.net");
                await userManager.AddToRoleAsync(dbUser42, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser42.UserName = "jtanner@mustang.net";
                dbUser42.Email = "jtanner@mustang.net";
                dbUser42.PhoneNumber = "9908469499";
                dbUser42.FirstName = "Jeremy";
                dbUser42.LastName = "Tanner";
                dbUser42.Address = "4 Stang Trail";
                dbUser42.ZipCode = "10019";

                await userManager.UpdateAsync(dbUser42);

                if (await userManager.IsInRoleAsync(dbUser42, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser42, "Customer");
                }
            }


            strEmail = "taylordjay@aoll.com";

            AppUser customer43 = new AppUser()
            {
                UserName = "taylordjay@aoll.com",
                Email = "taylordjay@aoll.com",
                PhoneNumber = "7011918647",
                FirstName = "Allison",
                LastName = "Taylor",
                Address = "726 Twin Pines Avenue",
                ZipCode = "60601"
            };

            AppUser dbUser43 = await userManager.FindByEmailAsync("taylordjay@aoll.com");

            if (dbUser43 == null)
            {
                IdentityResult result43 = await userManager.CreateAsync(customer43, "allyrally");

                if (result43.Succeeded == false)
                {
                    String errors43 = "";

                    foreach (IdentityError error in result43.Errors)
                    {
                        errors43 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (taylordjay@aoll.com): " + errors43);
                }

                dbUser43 = await userManager.FindByEmailAsync("taylordjay@aoll.com");
                await userManager.AddToRoleAsync(dbUser43, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser43.UserName = "taylordjay@aoll.com";
                dbUser43.Email = "taylordjay@aoll.com";
                dbUser43.PhoneNumber = "7011918647";
                dbUser43.FirstName = "Allison";
                dbUser43.LastName = "Taylor";
                dbUser43.Address = "726 Twin Pines Avenue";
                dbUser43.ZipCode = "60601";

                await userManager.UpdateAsync(dbUser43);

                if (await userManager.IsInRoleAsync(dbUser43, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser43, "Customer");
                }
            }


            strEmail = "rtaylor@gogle.com";

            AppUser customer44 = new AppUser()
            {
                UserName = "rtaylor@gogle.com",
                Email = "rtaylor@gogle.com",
                PhoneNumber = "8937910053",
                FirstName = "Rachel",
                LastName = "Taylor",
                Address = "06605 Sugar Drive",
                ZipCode = "60611"
            };

            AppUser dbUser44 = await userManager.FindByEmailAsync("rtaylor@gogle.com");

            if (dbUser44 == null)
            {
                IdentityResult result44 = await userManager.CreateAsync(customer44, "taylorbaylor");

                if (result44.Succeeded == false)
                {
                    String errors44 = "";

                    foreach (IdentityError error in result44.Errors)
                    {
                        errors44 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (rtaylor@gogle.com): " + errors44);
                }

                dbUser44 = await userManager.FindByEmailAsync("rtaylor@gogle.com");
                await userManager.AddToRoleAsync(dbUser44, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser44.UserName = "rtaylor@gogle.com";
                dbUser44.Email = "rtaylor@gogle.com";
                dbUser44.PhoneNumber = "8937910053";
                dbUser44.FirstName = "Rachel";
                dbUser44.LastName = "Taylor";
                dbUser44.Address = "06605 Sugar Drive";
                dbUser44.ZipCode = "60611";

                await userManager.UpdateAsync(dbUser44);

                if (await userManager.IsInRoleAsync(dbUser44, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser44, "Customer");
                }
            }


            strEmail = "teefrank@noclue.com";

            AppUser customer45 = new AppUser()
            {
                UserName = "teefrank@noclue.com",
                Email = "teefrank@noclue.com",
                PhoneNumber = "6394568913",
                FirstName = "Frank",
                LastName = "Tee",
                Address = "3567 Dawn Plaza",
                ZipCode = "33101"
            };

            AppUser dbUser45 = await userManager.FindByEmailAsync("teefrank@noclue.com");

            if (dbUser45 == null)
            {
                IdentityResult result45 = await userManager.CreateAsync(customer45, "teeoff22");

                if (result45.Succeeded == false)
                {
                    String errors45 = "";

                    foreach (IdentityError error in result45.Errors)
                    {
                        errors45 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (teefrank@noclue.com): " + errors45);
                }

                dbUser45 = await userManager.FindByEmailAsync("teefrank@noclue.com");
                await userManager.AddToRoleAsync(dbUser45, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser45.UserName = "teefrank@noclue.com";
                dbUser45.Email = "teefrank@noclue.com";
                dbUser45.PhoneNumber = "6394568913";
                dbUser45.FirstName = "Frank";
                dbUser45.LastName = "Tee";
                dbUser45.Address = "3567 Dawn Plaza";
                dbUser45.ZipCode = "33101";

                await userManager.UpdateAsync(dbUser45);

                if (await userManager.IsInRoleAsync(dbUser45, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser45, "Customer");
                }
            }


            strEmail = "ctucker@alphabet.co";

            AppUser customer46 = new AppUser()
            {
                UserName = "ctucker@alphabet.co",
                Email = "ctucker@alphabet.co",
                PhoneNumber = "2676838676",
                FirstName = "Clent",
                LastName = "Tucker",
                Address = "704 Northland Alley",
                ZipCode = "32801"
            };

            AppUser dbUser46 = await userManager.FindByEmailAsync("ctucker@alphabet.co");

            if (dbUser46 == null)
            {
                IdentityResult result46 = await userManager.CreateAsync(customer46, "tucksack1");

                if (result46.Succeeded == false)
                {
                    String errors46 = "";

                    foreach (IdentityError error in result46.Errors)
                    {
                        errors46 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (ctucker@alphabet.co): " + errors46);
                }

                dbUser46 = await userManager.FindByEmailAsync("ctucker@alphabet.co");
                await userManager.AddToRoleAsync(dbUser46, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser46.UserName = "ctucker@alphabet.co";
                dbUser46.Email = "ctucker@alphabet.co";
                dbUser46.PhoneNumber = "2676838676";
                dbUser46.FirstName = "Clent";
                dbUser46.LastName = "Tucker";
                dbUser46.Address = "704 Northland Alley";
                dbUser46.ZipCode = "32801";

                await userManager.UpdateAsync(dbUser46);

                if (await userManager.IsInRoleAsync(dbUser46, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser46, "Customer");
                }
            }


            strEmail = "avelasco@yoho.com";

            AppUser customer47 = new AppUser()
            {
                UserName = "avelasco@yoho.com",
                Email = "avelasco@yoho.com",
                PhoneNumber = "3452909754",
                FirstName = "Allen",
                LastName = "Velasco",
                Address = "72 Harbort Point",
                ZipCode = "30303"
            };

            AppUser dbUser47 = await userManager.FindByEmailAsync("avelasco@yoho.com");

            if (dbUser47 == null)
            {
                IdentityResult result47 = await userManager.CreateAsync(customer47, "meow88");

                if (result47.Succeeded == false)
                {
                    String errors47 = "";

                    foreach (IdentityError error in result47.Errors)
                    {
                        errors47 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (avelasco@yoho.com): " + errors47);
                }

                dbUser47 = await userManager.FindByEmailAsync("avelasco@yoho.com");
                await userManager.AddToRoleAsync(dbUser47, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser47.UserName = "avelasco@yoho.com";
                dbUser47.Email = "avelasco@yoho.com";
                dbUser47.PhoneNumber = "3452909754";
                dbUser47.FirstName = "Allen";
                dbUser47.LastName = "Velasco";
                dbUser47.Address = "72 Harbort Point";
                dbUser47.ZipCode = "30303";

                await userManager.UpdateAsync(dbUser47);

                if (await userManager.IsInRoleAsync(dbUser47, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser47, "Customer");
                }
            }


            strEmail = "vinovino@grapes.com";

            AppUser customer48 = new AppUser()
            {
                UserName = "vinovino@grapes.com",
                Email = "vinovino@grapes.com",
                PhoneNumber = "8567089194",
                FirstName = "Janet",
                LastName = "Vino",
                Address = "1 Oak Valley Place",
                ZipCode = "98101"
            };

            AppUser dbUser48 = await userManager.FindByEmailAsync("vinovino@grapes.com");

            if (dbUser48 == null)
            {
                IdentityResult result48 = await userManager.CreateAsync(customer48, "vinovino");

                if (result48.Succeeded == false)
                {
                    String errors48 = "";

                    foreach (IdentityError error in result48.Errors)
                    {
                        errors48 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (vinovino@grapes.com): " + errors48);
                }

                dbUser48 = await userManager.FindByEmailAsync("vinovino@grapes.com");
                await userManager.AddToRoleAsync(dbUser48, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser48.UserName = "vinovino@grapes.com";
                dbUser48.Email = "vinovino@grapes.com";
                dbUser48.PhoneNumber = "8567089194";
                dbUser48.FirstName = "Janet";
                dbUser48.LastName = "Vino";
                dbUser48.Address = "1 Oak Valley Place";
                dbUser48.ZipCode = "98101";

                await userManager.UpdateAsync(dbUser48);

                if (await userManager.IsInRoleAsync(dbUser48, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser48, "Customer");
                }
            }


            strEmail = "westj@pioneer.net";

            AppUser customer49 = new AppUser()
            {
                UserName = "westj@pioneer.net",
                Email = "westj@pioneer.net",
                PhoneNumber = "6260784394",
                FirstName = "Jake",
                LastName = "West",
                Address = "48743 Banding Parkway",
                ZipCode = "80202"
            };

            AppUser dbUser49 = await userManager.FindByEmailAsync("westj@pioneer.net");

            if (dbUser49 == null)
            {
                IdentityResult result49 = await userManager.CreateAsync(customer49, "gowest");

                if (result49.Succeeded == false)
                {
                    String errors49 = "";

                    foreach (IdentityError error in result49.Errors)
                    {
                        errors49 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (westj@pioneer.net): " + errors49);
                }

                dbUser49 = await userManager.FindByEmailAsync("westj@pioneer.net");
                await userManager.AddToRoleAsync(dbUser49, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser49.UserName = "westj@pioneer.net";
                dbUser49.Email = "westj@pioneer.net";
                dbUser49.PhoneNumber = "6260784394";
                dbUser49.FirstName = "Jake";
                dbUser49.LastName = "West";
                dbUser49.Address = "48743 Banding Parkway";
                dbUser49.ZipCode = "80202";

                await userManager.UpdateAsync(dbUser49);

                if (await userManager.IsInRoleAsync(dbUser49, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser49, "Customer");
                }
            }


            strEmail = "winner@hootmail.com";

            AppUser customer50 = new AppUser()
            {
                UserName = "winner@hootmail.com",
                Email = "winner@hootmail.com",
                PhoneNumber = "3733971174",
                FirstName = "Louis",
                LastName = "Winthorpe",
                Address = "96850 Summit Crossing",
                ZipCode = "2108"
            };

            AppUser dbUser50 = await userManager.FindByEmailAsync("winner@hootmail.com");

            if (dbUser50 == null)
            {
                IdentityResult result50 = await userManager.CreateAsync(customer50, "louielouie");

                if (result50.Succeeded == false)
                {
                    String errors50 = "";

                    foreach (IdentityError error in result50.Errors)
                    {
                        errors50 += error.Description + "; ";
                    }

                    throw new InvalidOperationException("Error creating customer (winner@hootmail.com): " + errors50);
                }

                dbUser50 = await userManager.FindByEmailAsync("winner@hootmail.com");
                await userManager.AddToRoleAsync(dbUser50, "Customer");
                intUsersAdded += 1;
            }
            else
            {
                dbUser50.UserName = "winner@hootmail.com";
                dbUser50.Email = "winner@hootmail.com";
                dbUser50.PhoneNumber = "3733971174";
                dbUser50.FirstName = "Louis";
                dbUser50.LastName = "Winthorpe";
                dbUser50.Address = "96850 Summit Crossing";
                dbUser50.ZipCode = "2108";

                await userManager.UpdateAsync(dbUser50);

                if (await userManager.IsInRoleAsync(dbUser50, "Customer") == false)
                {
                    await userManager.AddToRoleAsync(dbUser50, "Customer");
                }
            }


            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                String msg = "Customers Added: " + intUsersAdded +
                             "; Error on Email: " + strEmail;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
