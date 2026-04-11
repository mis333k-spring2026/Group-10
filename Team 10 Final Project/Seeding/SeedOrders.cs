using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Team10FinalProject.Seeding
{

    public static class OrderSeeder
    {
        public static void SeedAllOrders(AppDbContext db)
        {
            Int32 intOrdersAdded = 0;
            String strOrderFlag = "Begin";

            try
            {

                strOrderFlag = "Order Number 212000";

                AppUser customer1 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Michelle Banks");

                if (customer1 == null)
                {
                    throw new InvalidOperationException("Customer not found: Michelle Banks");
                }

                AppUser? friend1 = null;

                Card? card1 = db.Cards.FirstOrDefault(c => c.CardNumber == "4011798411664850");
                if (card1 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 4011798411664850");
                }


                Order dbOrder1 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212000);

                if (dbOrder1 == null)
                {
                    dbOrder1 = new Order()
                    {
                        OrderNumber = 212000,
                        OrderDate = DateTime.Now,
                        Status = false,
                        CustomerID = customer1.Id,
                        FriendID = friend1 != null ? friend1.Id : null,
                        CardID = card1.CardID
                    };

                    db.Orders.Add(dbOrder1);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder1.OrderNumber = 212000;
                    dbOrder1.OrderDate = DateTime.Now;
                    dbOrder1.Status = false;
                    dbOrder1.CustomerID = customer1.Id;
                    dbOrder1.FriendID = friend1 != null ? friend1.Id : null;
                    dbOrder1.CardID = card1.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder1.OrderID));
                    db.Update(dbOrder1);
                    db.SaveChanges();
                }


                OrderDetail od_1_1 = new OrderDetail()
                {
                    OrderID = dbOrder1.OrderID,
                    Price = 3.00m
                };

                Song? song_1_1 = db.Songs.FirstOrDefault(s => s.SongName == "Not Like Us");
                if (song_1_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Not Like Us");
                }
                od_1_1.SongID = song_1_1.SongID;

                db.OrderDetails.Add(od_1_1);

                OrderDetail od_1_2 = new OrderDetail()
                {
                    OrderID = dbOrder1.OrderID,
                    Price = 17.00m
                };

                Album? album_1_2 = db.Albums.FirstOrDefault(a => a.AlbumName == "Nellyville");
                if (album_1_2 == null)
                {
                    throw new InvalidOperationException("Album not found: Nellyville");
                }
                od_1_2.AlbumID = album_1_2.AlbumID;

                db.OrderDetails.Add(od_1_2);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212001";

                AppUser customer2 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Christopher Baker");

                if (customer2 == null)
                {
                    throw new InvalidOperationException("Customer not found: Christopher Baker");
                }

                AppUser? friend2 = null;

                Card? card2 = db.Cards.FirstOrDefault(c => c.CardNumber == "5402487911641970");
                if (card2 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5402487911641970");
                }


                Order dbOrder2 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212001);

                if (dbOrder2 == null)
                {
                    dbOrder2 = new Order()
                    {
                        OrderNumber = 212001,
                        OrderDate = DateTime.Parse("2026-02-23 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer2.Id,
                        FriendID = friend2 != null ? friend2.Id : null,
                        CardID = card2.CardID
                    };

                    db.Orders.Add(dbOrder2);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder2.OrderNumber = 212001;
                    dbOrder2.OrderDate = DateTime.Parse("2026-02-23 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder2.Status = false;
                    dbOrder2.CustomerID = customer2.Id;
                    dbOrder2.FriendID = friend2 != null ? friend2.Id : null;
                    dbOrder2.CardID = card2.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder2.OrderID));
                    db.Update(dbOrder2);
                    db.SaveChanges();
                }


                OrderDetail od_2_1 = new OrderDetail()
                {
                    OrderID = dbOrder2.OrderID,
                    Price = 2.00m
                };

                Song? song_2_1 = db.Songs.FirstOrDefault(s => s.SongName == "Bootstrap Remix");
                if (song_2_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Bootstrap Remix");
                }
                od_2_1.SongID = song_2_1.SongID;

                db.OrderDetails.Add(od_2_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212002";

                AppUser customer3 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Christopher Baker");

                if (customer3 == null)
                {
                    throw new InvalidOperationException("Customer not found: Christopher Baker");
                }

                AppUser? friend3 = null;

                Card? card3 = db.Cards.FirstOrDefault(c => c.CardNumber == "5402487911641970");
                if (card3 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5402487911641970");
                }


                Order dbOrder3 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212002);

                if (dbOrder3 == null)
                {
                    dbOrder3 = new Order()
                    {
                        OrderNumber = 212002,
                        OrderDate = DateTime.Parse("2026-02-24 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer3.Id,
                        FriendID = friend3 != null ? friend3.Id : null,
                        CardID = card3.CardID
                    };

                    db.Orders.Add(dbOrder3);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder3.OrderNumber = 212002;
                    dbOrder3.OrderDate = DateTime.Parse("2026-02-24 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder3.Status = false;
                    dbOrder3.CustomerID = customer3.Id;
                    dbOrder3.FriendID = friend3 != null ? friend3.Id : null;
                    dbOrder3.CardID = card3.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder3.OrderID));
                    db.Update(dbOrder3);
                    db.SaveChanges();
                }


                OrderDetail od_3_1 = new OrderDetail()
                {
                    OrderID = dbOrder3.OrderID,
                    Price = 2.00m
                };

                Song? song_3_1 = db.Songs.FirstOrDefault(s => s.SongName == "Ice Ice Baby");
                if (song_3_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Ice Ice Baby");
                }
                od_3_1.SongID = song_3_1.SongID;

                db.OrderDetails.Add(od_3_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212003";

                AppUser customer4 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Eric Stuart");

                if (customer4 == null)
                {
                    throw new InvalidOperationException("Customer not found: Eric Stuart");
                }

                AppUser? friend4 = null;

                Card? card4 = db.Cards.FirstOrDefault(c => c.CardNumber == "5489761548972350");
                if (card4 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5489761548972350");
                }


                Order dbOrder4 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212003);

                if (dbOrder4 == null)
                {
                    dbOrder4 = new Order()
                    {
                        OrderNumber = 212003,
                        OrderDate = DateTime.Now,
                        Status = false,
                        CustomerID = customer4.Id,
                        FriendID = friend4 != null ? friend4.Id : null,
                        CardID = card4.CardID
                    };

                    db.Orders.Add(dbOrder4);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder4.OrderNumber = 212003;
                    dbOrder4.OrderDate = DateTime.Now;
                    dbOrder4.Status = false;
                    dbOrder4.CustomerID = customer4.Id;
                    dbOrder4.FriendID = friend4 != null ? friend4.Id : null;
                    dbOrder4.CardID = card4.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder4.OrderID));
                    db.Update(dbOrder4);
                    db.SaveChanges();
                }


                OrderDetail od_4_1 = new OrderDetail()
                {
                    OrderID = dbOrder4.OrderID,
                    Price = 2.00m
                };

                Song? song_4_1 = db.Songs.FirstOrDefault(s => s.SongName == "Moonlight");
                if (song_4_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Moonlight");
                }
                od_4_1.SongID = song_4_1.SongID;

                db.OrderDetails.Add(od_4_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212004";

                AppUser customer5 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

                if (customer5 == null)
                {
                    throw new InvalidOperationException("Customer not found: Olivier Saint-Jean");
                }

                AppUser? friend5 = null;

                Card? card5 = db.Cards.FirstOrDefault(c => c.CardNumber == "5469290013187490");
                if (card5 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5469290013187490");
                }


                friend5 = db.Users.FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Louis Winthorpe");
                if (friend5 == null)
                {
                    throw new InvalidOperationException("Gift recipient not found: Louis Winthorpe");
                }

                Order dbOrder5 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212004);

                if (dbOrder5 == null)
                {
                    dbOrder5 = new Order()
                    {
                        OrderNumber = 212004,
                        OrderDate = DateTime.Parse("2026-02-24 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer5.Id,
                        FriendID = friend5 != null ? friend5.Id : null,
                        CardID = card5.CardID
                    };

                    db.Orders.Add(dbOrder5);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder5.OrderNumber = 212004;
                    dbOrder5.OrderDate = DateTime.Parse("2026-02-24 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder5.Status = false;
                    dbOrder5.CustomerID = customer5.Id;
                    dbOrder5.FriendID = friend5 != null ? friend5.Id : null;
                    dbOrder5.CardID = card5.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder5.OrderID));
                    db.Update(dbOrder5);
                    db.SaveChanges();
                }


                OrderDetail od_5_1 = new OrderDetail()
                {
                    OrderID = dbOrder5.OrderID,
                    Price = 3.00m
                };

                Song? song_5_1 = db.Songs.FirstOrDefault(s => s.SongName == "Hot In Herre");
                if (song_5_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Hot In Herre");
                }
                od_5_1.SongID = song_5_1.SongID;

                db.OrderDetails.Add(od_5_1);

                OrderDetail od_5_2 = new OrderDetail()
                {
                    OrderID = dbOrder5.OrderID,
                    Price = 15.00m
                };

                Album? album_5_2 = db.Albums.FirstOrDefault(a => a.AlbumName == "Shock Value");
                if (album_5_2 == null)
                {
                    throw new InvalidOperationException("Album not found: Shock Value");
                }
                od_5_2.AlbumID = album_5_2.AlbumID;

                db.OrderDetails.Add(od_5_2);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212005";

                AppUser customer6 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "John Hearn");

                if (customer6 == null)
                {
                    throw new InvalidOperationException("Customer not found: John Hearn");
                }

                AppUser? friend6 = null;

                Card? card6 = db.Cards.FirstOrDefault(c => c.CardNumber == "865146254978453");
                if (card6 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 865146254978453");
                }


                Order dbOrder6 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212005);

                if (dbOrder6 == null)
                {
                    dbOrder6 = new Order()
                    {
                        OrderNumber = 212005,
                        OrderDate = DateTime.Now,
                        Status = false,
                        CustomerID = customer6.Id,
                        FriendID = friend6 != null ? friend6.Id : null,
                        CardID = card6.CardID
                    };

                    db.Orders.Add(dbOrder6);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder6.OrderNumber = 212005;
                    dbOrder6.OrderDate = DateTime.Now;
                    dbOrder6.Status = false;
                    dbOrder6.CustomerID = customer6.Id;
                    dbOrder6.FriendID = friend6 != null ? friend6.Id : null;
                    dbOrder6.CardID = card6.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder6.OrderID));
                    db.Update(dbOrder6);
                    db.SaveChanges();
                }


                OrderDetail od_6_1 = new OrderDetail()
                {
                    OrderID = dbOrder6.OrderID,
                    Price = 1.00m
                };

                Song? song_6_1 = db.Songs.FirstOrDefault(s => s.SongName == "The Box");
                if (song_6_1 == null)
                {
                    throw new InvalidOperationException("Song not found: The Box");
                }
                od_6_1.SongID = song_6_1.SongID;

                db.OrderDetails.Add(od_6_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212006";

                AppUser customer7 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

                if (customer7 == null)
                {
                    throw new InvalidOperationException("Customer not found: Clent Tucker");
                }

                AppUser? friend7 = null;

                Card? card7 = db.Cards.FirstOrDefault(c => c.CardNumber == "561479481465379");
                if (card7 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 561479481465379");
                }


                friend7 = db.Users.FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");
                if (friend7 == null)
                {
                    throw new InvalidOperationException("Gift recipient not found: Olivier Saint-Jean");
                }

                Order dbOrder7 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212006);

                if (dbOrder7 == null)
                {
                    dbOrder7 = new Order()
                    {
                        OrderNumber = 212006,
                        OrderDate = DateTime.Parse("2026-02-25 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer7.Id,
                        FriendID = friend7 != null ? friend7.Id : null,
                        CardID = card7.CardID
                    };

                    db.Orders.Add(dbOrder7);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder7.OrderNumber = 212006;
                    dbOrder7.OrderDate = DateTime.Parse("2026-02-25 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder7.Status = false;
                    dbOrder7.CustomerID = customer7.Id;
                    dbOrder7.FriendID = friend7 != null ? friend7.Id : null;
                    dbOrder7.CardID = card7.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder7.OrderID));
                    db.Update(dbOrder7);
                    db.SaveChanges();
                }


                OrderDetail od_7_1 = new OrderDetail()
                {
                    OrderID = dbOrder7.OrderID,
                    Price = 2.00m
                };

                Song? song_7_1 = db.Songs.FirstOrDefault(s => s.SongName == "Billie Jean");
                if (song_7_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Billie Jean");
                }
                od_7_1.SongID = song_7_1.SongID;

                db.OrderDetails.Add(od_7_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212007";

                AppUser customer8 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

                if (customer8 == null)
                {
                    throw new InvalidOperationException("Customer not found: Olivier Saint-Jean");
                }

                AppUser? friend8 = null;

                Card? card8 = db.Cards.FirstOrDefault(c => c.CardNumber == "5469290013187490");
                if (card8 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5469290013187490");
                }


                Order dbOrder8 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212007);

                if (dbOrder8 == null)
                {
                    dbOrder8 = new Order()
                    {
                        OrderNumber = 212007,
                        OrderDate = DateTime.Parse("2026-02-25 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer8.Id,
                        FriendID = friend8 != null ? friend8.Id : null,
                        CardID = card8.CardID
                    };

                    db.Orders.Add(dbOrder8);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder8.OrderNumber = 212007;
                    dbOrder8.OrderDate = DateTime.Parse("2026-02-25 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder8.Status = false;
                    dbOrder8.CustomerID = customer8.Id;
                    dbOrder8.FriendID = friend8 != null ? friend8.Id : null;
                    dbOrder8.CardID = card8.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder8.OrderID));
                    db.Update(dbOrder8);
                    db.SaveChanges();
                }


                OrderDetail od_8_1 = new OrderDetail()
                {
                    OrderID = dbOrder8.OrderID,
                    Price = 5.00m
                };

                Song? song_8_1 = db.Songs.FirstOrDefault(s => s.SongName == "Without Me");
                if (song_8_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Without Me");
                }
                od_8_1.SongID = song_8_1.SongID;

                db.OrderDetails.Add(od_8_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212008";

                AppUser customer9 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Christopher Baker");

                if (customer9 == null)
                {
                    throw new InvalidOperationException("Customer not found: Christopher Baker");
                }

                AppUser? friend9 = null;

                Card? card9 = db.Cards.FirstOrDefault(c => c.CardNumber == "5402487911641970");
                if (card9 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5402487911641970");
                }


                Order dbOrder9 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212008);

                if (dbOrder9 == null)
                {
                    dbOrder9 = new Order()
                    {
                        OrderNumber = 212008,
                        OrderDate = DateTime.Parse("2026-02-25 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer9.Id,
                        FriendID = friend9 != null ? friend9.Id : null,
                        CardID = card9.CardID
                    };

                    db.Orders.Add(dbOrder9);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder9.OrderNumber = 212008;
                    dbOrder9.OrderDate = DateTime.Parse("2026-02-25 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder9.Status = false;
                    dbOrder9.CustomerID = customer9.Id;
                    dbOrder9.FriendID = friend9 != null ? friend9.Id : null;
                    dbOrder9.CardID = card9.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder9.OrderID));
                    db.Update(dbOrder9);
                    db.SaveChanges();
                }


                OrderDetail od_9_1 = new OrderDetail()
                {
                    OrderID = dbOrder9.OrderID,
                    Price = 3.00m
                };

                Song? song_9_1 = db.Songs.FirstOrDefault(s => s.SongName == "Not Like Us");
                if (song_9_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Not Like Us");
                }
                od_9_1.SongID = song_9_1.SongID;

                db.OrderDetails.Add(od_9_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212009";

                AppUser customer10 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Tesa Freeley");

                if (customer10 == null)
                {
                    throw new InvalidOperationException("Customer not found: Tesa Freeley");
                }

                AppUser? friend10 = null;

                Card? card10 = db.Cards.FirstOrDefault(c => c.CardNumber == "6767489513462640");
                if (card10 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 6767489513462640");
                }


                Order dbOrder10 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212009);

                if (dbOrder10 == null)
                {
                    dbOrder10 = new Order()
                    {
                        OrderNumber = 212009,
                        OrderDate = DateTime.Now,
                        Status = false,
                        CustomerID = customer10.Id,
                        FriendID = friend10 != null ? friend10.Id : null,
                        CardID = card10.CardID
                    };

                    db.Orders.Add(dbOrder10);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder10.OrderNumber = 212009;
                    dbOrder10.OrderDate = DateTime.Now;
                    dbOrder10.Status = false;
                    dbOrder10.CustomerID = customer10.Id;
                    dbOrder10.FriendID = friend10 != null ? friend10.Id : null;
                    dbOrder10.CardID = card10.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder10.OrderID));
                    db.Update(dbOrder10);
                    db.SaveChanges();
                }


                OrderDetail od_10_1 = new OrderDetail()
                {
                    OrderID = dbOrder10.OrderID,
                    Price = 2.00m
                };

                Song? song_10_1 = db.Songs.FirstOrDefault(s => s.SongName == "Around the World");
                if (song_10_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Around the World");
                }
                od_10_1.SongID = song_10_1.SongID;

                db.OrderDetails.Add(od_10_1);

                OrderDetail od_10_2 = new OrderDetail()
                {
                    OrderID = dbOrder10.OrderID,
                    Price = 14.00m
                };

                Album? album_10_2 = db.Albums.FirstOrDefault(a => a.AlbumName == "Harder Than Ever");
                if (album_10_2 == null)
                {
                    throw new InvalidOperationException("Album not found: Harder Than Ever");
                }
                od_10_2.AlbumID = album_10_2.AlbumID;

                db.OrderDetails.Add(od_10_2);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212010";

                AppUser customer11 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

                if (customer11 == null)
                {
                    throw new InvalidOperationException("Customer not found: Clent Tucker");
                }

                AppUser? friend11 = null;

                Card? card11 = db.Cards.FirstOrDefault(c => c.CardNumber == "561479481465379");
                if (card11 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 561479481465379");
                }


                Order dbOrder11 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212010);

                if (dbOrder11 == null)
                {
                    dbOrder11 = new Order()
                    {
                        OrderNumber = 212010,
                        OrderDate = DateTime.Parse("2026-02-26 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer11.Id,
                        FriendID = friend11 != null ? friend11.Id : null,
                        CardID = card11.CardID
                    };

                    db.Orders.Add(dbOrder11);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder11.OrderNumber = 212010;
                    dbOrder11.OrderDate = DateTime.Parse("2026-02-26 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder11.Status = false;
                    dbOrder11.CustomerID = customer11.Id;
                    dbOrder11.FriendID = friend11 != null ? friend11.Id : null;
                    dbOrder11.CardID = card11.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder11.OrderID));
                    db.Update(dbOrder11);
                    db.SaveChanges();
                }


                OrderDetail od_11_1 = new OrderDetail()
                {
                    OrderID = dbOrder11.OrderID,
                    Price = 5.00m
                };

                Song? song_11_1 = db.Songs.FirstOrDefault(s => s.SongName == "Another One Bites The Dust - Remastered 2011");
                if (song_11_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Another One Bites The Dust - Remastered 2011");
                }
                od_11_1.SongID = song_11_1.SongID;

                db.OrderDetails.Add(od_11_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212011";

                AppUser customer12 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Margaret Garcia");

                if (customer12 == null)
                {
                    throw new InvalidOperationException("Customer not found: Margaret Garcia");
                }

                AppUser? friend12 = null;

                Card? card12 = db.Cards.FirstOrDefault(c => c.CardNumber == "4040646714659780");
                if (card12 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 4040646714659780");
                }


                Order dbOrder12 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212011);

                if (dbOrder12 == null)
                {
                    dbOrder12 = new Order()
                    {
                        OrderNumber = 212011,
                        OrderDate = DateTime.Parse("2026-02-26 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer12.Id,
                        FriendID = friend12 != null ? friend12.Id : null,
                        CardID = card12.CardID
                    };

                    db.Orders.Add(dbOrder12);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder12.OrderNumber = 212011;
                    dbOrder12.OrderDate = DateTime.Parse("2026-02-26 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder12.Status = false;
                    dbOrder12.CustomerID = customer12.Id;
                    dbOrder12.FriendID = friend12 != null ? friend12.Id : null;
                    dbOrder12.CardID = card12.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder12.OrderID));
                    db.Update(dbOrder12);
                    db.SaveChanges();
                }


                OrderDetail od_12_1 = new OrderDetail()
                {
                    OrderID = dbOrder12.OrderID,
                    Price = 1.00m
                };

                Song? song_12_1 = db.Songs.FirstOrDefault(s => s.SongName == "No Heart");
                if (song_12_1 == null)
                {
                    throw new InvalidOperationException("Song not found: No Heart");
                }
                od_12_1.SongID = song_12_1.SongID;

                db.OrderDetails.Add(od_12_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212012";

                AppUser customer13 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

                if (customer13 == null)
                {
                    throw new InvalidOperationException("Customer not found: Olivier Saint-Jean");
                }

                AppUser? friend13 = null;

                Card? card13 = db.Cards.FirstOrDefault(c => c.CardNumber == "5469290013187490");
                if (card13 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5469290013187490");
                }


                Order dbOrder13 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212012);

                if (dbOrder13 == null)
                {
                    dbOrder13 = new Order()
                    {
                        OrderNumber = 212012,
                        OrderDate = DateTime.Parse("2026-02-26 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer13.Id,
                        FriendID = friend13 != null ? friend13.Id : null,
                        CardID = card13.CardID
                    };

                    db.Orders.Add(dbOrder13);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder13.OrderNumber = 212012;
                    dbOrder13.OrderDate = DateTime.Parse("2026-02-26 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder13.Status = false;
                    dbOrder13.CustomerID = customer13.Id;
                    dbOrder13.FriendID = friend13 != null ? friend13.Id : null;
                    dbOrder13.CardID = card13.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder13.OrderID));
                    db.Update(dbOrder13);
                    db.SaveChanges();
                }


                OrderDetail od_13_1 = new OrderDetail()
                {
                    OrderID = dbOrder13.OrderID,
                    Price = 1.00m
                };

                Song? song_13_1 = db.Songs.FirstOrDefault(s => s.SongName == "Bad and Boujee (feat. Lil Uzi Vert)");
                if (song_13_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Bad and Boujee (feat. Lil Uzi Vert)");
                }
                od_13_1.SongID = song_13_1.SongID;

                db.OrderDetails.Add(od_13_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212013";

                AppUser customer14 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Jennifer MacLeod");

                if (customer14 == null)
                {
                    throw new InvalidOperationException("Customer not found: Jennifer MacLeod");
                }

                AppUser? friend14 = null;

                Card? card14 = db.Cards.FirstOrDefault(c => c.CardNumber == "4584794615342670");
                if (card14 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 4584794615342670");
                }


                Order dbOrder14 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212013);

                if (dbOrder14 == null)
                {
                    dbOrder14 = new Order()
                    {
                        OrderNumber = 212013,
                        OrderDate = DateTime.Now,
                        Status = false,
                        CustomerID = customer14.Id,
                        FriendID = friend14 != null ? friend14.Id : null,
                        CardID = card14.CardID
                    };

                    db.Orders.Add(dbOrder14);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder14.OrderNumber = 212013;
                    dbOrder14.OrderDate = DateTime.Now;
                    dbOrder14.Status = false;
                    dbOrder14.CustomerID = customer14.Id;
                    dbOrder14.FriendID = friend14 != null ? friend14.Id : null;
                    dbOrder14.CardID = card14.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder14.OrderID));
                    db.Update(dbOrder14);
                    db.SaveChanges();
                }


                OrderDetail od_14_1 = new OrderDetail()
                {
                    OrderID = dbOrder14.OrderID,
                    Price = 2.00m
                };

                Song? song_14_1 = db.Songs.FirstOrDefault(s => s.SongName == "Me Porto Bonito");
                if (song_14_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Me Porto Bonito");
                }
                od_14_1.SongID = song_14_1.SongID;

                db.OrderDetails.Add(od_14_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212014";

                AppUser customer15 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

                if (customer15 == null)
                {
                    throw new InvalidOperationException("Customer not found: Olivier Saint-Jean");
                }

                AppUser? friend15 = null;

                Card? card15 = db.Cards.FirstOrDefault(c => c.CardNumber == "5469290013187490");
                if (card15 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5469290013187490");
                }


                Order dbOrder15 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212014);

                if (dbOrder15 == null)
                {
                    dbOrder15 = new Order()
                    {
                        OrderNumber = 212014,
                        OrderDate = DateTime.Parse("2026-02-27 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer15.Id,
                        FriendID = friend15 != null ? friend15.Id : null,
                        CardID = card15.CardID
                    };

                    db.Orders.Add(dbOrder15);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder15.OrderNumber = 212014;
                    dbOrder15.OrderDate = DateTime.Parse("2026-02-27 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder15.Status = false;
                    dbOrder15.CustomerID = customer15.Id;
                    dbOrder15.FriendID = friend15 != null ? friend15.Id : null;
                    dbOrder15.CardID = card15.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder15.OrderID));
                    db.Update(dbOrder15);
                    db.SaveChanges();
                }


                OrderDetail od_15_1 = new OrderDetail()
                {
                    OrderID = dbOrder15.OrderID,
                    Price = 15.00m
                };

                Album? album_15_1 = db.Albums.FirstOrDefault(a => a.AlbumName == "Still Rollin");
                if (album_15_1 == null)
                {
                    throw new InvalidOperationException("Album not found: Still Rollin");
                }
                od_15_1.AlbumID = album_15_1.AlbumID;

                db.OrderDetails.Add(od_15_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212015";

                AppUser customer16 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Margaret Garcia");

                if (customer16 == null)
                {
                    throw new InvalidOperationException("Customer not found: Margaret Garcia");
                }

                AppUser? friend16 = null;

                Card? card16 = db.Cards.FirstOrDefault(c => c.CardNumber == "4040646714659780");
                if (card16 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 4040646714659780");
                }


                Order dbOrder16 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212015);

                if (dbOrder16 == null)
                {
                    dbOrder16 = new Order()
                    {
                        OrderNumber = 212015,
                        OrderDate = DateTime.Parse("2026-02-27 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer16.Id,
                        FriendID = friend16 != null ? friend16.Id : null,
                        CardID = card16.CardID
                    };

                    db.Orders.Add(dbOrder16);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder16.OrderNumber = 212015;
                    dbOrder16.OrderDate = DateTime.Parse("2026-02-27 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder16.Status = false;
                    dbOrder16.CustomerID = customer16.Id;
                    dbOrder16.FriendID = friend16 != null ? friend16.Id : null;
                    dbOrder16.CardID = card16.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder16.OrderID));
                    db.Update(dbOrder16);
                    db.SaveChanges();
                }


                OrderDetail od_16_1 = new OrderDetail()
                {
                    OrderID = dbOrder16.OrderID,
                    Price = 5.00m
                };

                Song? song_16_1 = db.Songs.FirstOrDefault(s => s.SongName == "Sprinter");
                if (song_16_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Sprinter");
                }
                od_16_1.SongID = song_16_1.SongID;

                db.OrderDetails.Add(od_16_1);

                OrderDetail od_16_2 = new OrderDetail()
                {
                    OrderID = dbOrder16.OrderID,
                    Price = 3.00m
                };

                Song? song_16_2 = db.Songs.FirstOrDefault(s => s.SongName == "GOSSIP");
                if (song_16_2 == null)
                {
                    throw new InvalidOperationException("Song not found: GOSSIP");
                }
                od_16_2.SongID = song_16_2.SongID;

                db.OrderDetails.Add(od_16_2);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212016";

                AppUser customer17 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

                if (customer17 == null)
                {
                    throw new InvalidOperationException("Customer not found: Clent Tucker");
                }

                AppUser? friend17 = null;

                Card? card17 = db.Cards.FirstOrDefault(c => c.CardNumber == "561479481465379");
                if (card17 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 561479481465379");
                }


                Order dbOrder17 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212016);

                if (dbOrder17 == null)
                {
                    dbOrder17 = new Order()
                    {
                        OrderNumber = 212016,
                        OrderDate = DateTime.Parse("2026-02-27 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer17.Id,
                        FriendID = friend17 != null ? friend17.Id : null,
                        CardID = card17.CardID
                    };

                    db.Orders.Add(dbOrder17);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder17.OrderNumber = 212016;
                    dbOrder17.OrderDate = DateTime.Parse("2026-02-27 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder17.Status = false;
                    dbOrder17.CustomerID = customer17.Id;
                    dbOrder17.FriendID = friend17 != null ? friend17.Id : null;
                    dbOrder17.CardID = card17.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder17.OrderID));
                    db.Update(dbOrder17);
                    db.SaveChanges();
                }


                OrderDetail od_17_1 = new OrderDetail()
                {
                    OrderID = dbOrder17.OrderID,
                    Price = 1.00m
                };

                Song? song_17_1 = db.Songs.FirstOrDefault(s => s.SongName == "Could You Be Loved");
                if (song_17_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Could You Be Loved");
                }
                od_17_1.SongID = song_17_1.SongID;

                db.OrderDetails.Add(od_17_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212017";

                AppUser customer18 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

                if (customer18 == null)
                {
                    throw new InvalidOperationException("Customer not found: Clent Tucker");
                }

                AppUser? friend18 = null;

                Card? card18 = db.Cards.FirstOrDefault(c => c.CardNumber == "561479481465379");
                if (card18 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 561479481465379");
                }


                Order dbOrder18 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212017);

                if (dbOrder18 == null)
                {
                    dbOrder18 = new Order()
                    {
                        OrderNumber = 212017,
                        OrderDate = DateTime.Parse("2026-02-28 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer18.Id,
                        FriendID = friend18 != null ? friend18.Id : null,
                        CardID = card18.CardID
                    };

                    db.Orders.Add(dbOrder18);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder18.OrderNumber = 212017;
                    dbOrder18.OrderDate = DateTime.Parse("2026-02-28 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder18.Status = false;
                    dbOrder18.CustomerID = customer18.Id;
                    dbOrder18.FriendID = friend18 != null ? friend18.Id : null;
                    dbOrder18.CardID = card18.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder18.OrderID));
                    db.Update(dbOrder18);
                    db.SaveChanges();
                }


                OrderDetail od_18_1 = new OrderDetail()
                {
                    OrderID = dbOrder18.OrderID,
                    Price = 4.00m
                };

                Song? song_18_1 = db.Songs.FirstOrDefault(s => s.SongName == "Check Yo Self - Remix");
                if (song_18_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Check Yo Self - Remix");
                }
                od_18_1.SongID = song_18_1.SongID;

                db.OrderDetails.Add(od_18_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212018";

                AppUser customer19 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Christopher Baker");

                if (customer19 == null)
                {
                    throw new InvalidOperationException("Customer not found: Christopher Baker");
                }

                AppUser? friend19 = null;

                Card? card19 = db.Cards.FirstOrDefault(c => c.CardNumber == "5402487911641970");
                if (card19 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5402487911641970");
                }


                Order dbOrder19 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212018);

                if (dbOrder19 == null)
                {
                    dbOrder19 = new Order()
                    {
                        OrderNumber = 212018,
                        OrderDate = DateTime.Parse("2026-02-28 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer19.Id,
                        FriendID = friend19 != null ? friend19.Id : null,
                        CardID = card19.CardID
                    };

                    db.Orders.Add(dbOrder19);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder19.OrderNumber = 212018;
                    dbOrder19.OrderDate = DateTime.Parse("2026-02-28 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder19.Status = false;
                    dbOrder19.CustomerID = customer19.Id;
                    dbOrder19.FriendID = friend19 != null ? friend19.Id : null;
                    dbOrder19.CardID = card19.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder19.OrderID));
                    db.Update(dbOrder19);
                    db.SaveChanges();
                }


                OrderDetail od_19_1 = new OrderDetail()
                {
                    OrderID = dbOrder19.OrderID,
                    Price = 1.00m
                };

                Song? song_19_1 = db.Songs.FirstOrDefault(s => s.SongName == "Hypnotize - 2014 Remaster");
                if (song_19_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Hypnotize - 2014 Remaster");
                }
                od_19_1.SongID = song_19_1.SongID;

                db.OrderDetails.Add(od_19_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212019";

                AppUser customer20 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Margaret Garcia");

                if (customer20 == null)
                {
                    throw new InvalidOperationException("Customer not found: Margaret Garcia");
                }

                AppUser? friend20 = null;

                Card? card20 = db.Cards.FirstOrDefault(c => c.CardNumber == "4040646714659780");
                if (card20 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 4040646714659780");
                }


                Order dbOrder20 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212019);

                if (dbOrder20 == null)
                {
                    dbOrder20 = new Order()
                    {
                        OrderNumber = 212019,
                        OrderDate = DateTime.Parse("2026-02-28 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer20.Id,
                        FriendID = friend20 != null ? friend20.Id : null,
                        CardID = card20.CardID
                    };

                    db.Orders.Add(dbOrder20);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder20.OrderNumber = 212019;
                    dbOrder20.OrderDate = DateTime.Parse("2026-02-28 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder20.Status = false;
                    dbOrder20.CustomerID = customer20.Id;
                    dbOrder20.FriendID = friend20 != null ? friend20.Id : null;
                    dbOrder20.CardID = card20.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder20.OrderID));
                    db.Update(dbOrder20);
                    db.SaveChanges();
                }


                OrderDetail od_20_1 = new OrderDetail()
                {
                    OrderID = dbOrder20.OrderID,
                    Price = 22.00m
                };

                Album? album_20_1 = db.Albums.FirstOrDefault(a => a.AlbumName == "The Trinity");
                if (album_20_1 == null)
                {
                    throw new InvalidOperationException("Album not found: The Trinity");
                }
                od_20_1.AlbumID = album_20_1.AlbumID;

                db.OrderDetails.Add(od_20_1);

                OrderDetail od_20_2 = new OrderDetail()
                {
                    OrderID = dbOrder20.OrderID,
                    Price = 3.00m
                };

                Song? song_20_2 = db.Songs.FirstOrDefault(s => s.SongName == "Still Think About You");
                if (song_20_2 == null)
                {
                    throw new InvalidOperationException("Song not found: Still Think About You");
                }
                od_20_2.SongID = song_20_2.SongID;

                db.OrderDetails.Add(od_20_2);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212020";

                AppUser customer21 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

                if (customer21 == null)
                {
                    throw new InvalidOperationException("Customer not found: Olivier Saint-Jean");
                }

                AppUser? friend21 = null;

                Card? card21 = db.Cards.FirstOrDefault(c => c.CardNumber == "5469290013187490");
                if (card21 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5469290013187490");
                }


                friend21 = db.Users.FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Joe Nguyen");
                if (friend21 == null)
                {
                    throw new InvalidOperationException("Gift recipient not found: Joe Nguyen");
                }

                Order dbOrder21 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212020);

                if (dbOrder21 == null)
                {
                    dbOrder21 = new Order()
                    {
                        OrderNumber = 212020,
                        OrderDate = DateTime.Parse("2026-03-01 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer21.Id,
                        FriendID = friend21 != null ? friend21.Id : null,
                        CardID = card21.CardID
                    };

                    db.Orders.Add(dbOrder21);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder21.OrderNumber = 212020;
                    dbOrder21.OrderDate = DateTime.Parse("2026-03-01 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder21.Status = false;
                    dbOrder21.CustomerID = customer21.Id;
                    dbOrder21.FriendID = friend21 != null ? friend21.Id : null;
                    dbOrder21.CardID = card21.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder21.OrderID));
                    db.Update(dbOrder21);
                    db.SaveChanges();
                }


                OrderDetail od_21_1 = new OrderDetail()
                {
                    OrderID = dbOrder21.OrderID,
                    Price = 3.00m
                };

                Song? song_21_1 = db.Songs.FirstOrDefault(s => s.SongName == "Doja");
                if (song_21_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Doja");
                }
                od_21_1.SongID = song_21_1.SongID;

                db.OrderDetails.Add(od_21_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212021";

                AppUser customer22 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

                if (customer22 == null)
                {
                    throw new InvalidOperationException("Customer not found: Olivier Saint-Jean");
                }

                AppUser? friend22 = null;

                Card? card22 = db.Cards.FirstOrDefault(c => c.CardNumber == "5469290013187490");
                if (card22 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5469290013187490");
                }


                Order dbOrder22 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212021);

                if (dbOrder22 == null)
                {
                    dbOrder22 = new Order()
                    {
                        OrderNumber = 212021,
                        OrderDate = DateTime.Parse("2026-03-01 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer22.Id,
                        FriendID = friend22 != null ? friend22.Id : null,
                        CardID = card22.CardID
                    };

                    db.Orders.Add(dbOrder22);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder22.OrderNumber = 212021;
                    dbOrder22.OrderDate = DateTime.Parse("2026-03-01 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder22.Status = false;
                    dbOrder22.CustomerID = customer22.Id;
                    dbOrder22.FriendID = friend22 != null ? friend22.Id : null;
                    dbOrder22.CardID = card22.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder22.OrderID));
                    db.Update(dbOrder22);
                    db.SaveChanges();
                }


                OrderDetail od_22_1 = new OrderDetail()
                {
                    OrderID = dbOrder22.OrderID,
                    Price = 5.00m
                };

                Song? song_22_1 = db.Songs.FirstOrDefault(s => s.SongName == "TESLA BOY (feat. Blaqbonez)");
                if (song_22_1 == null)
                {
                    throw new InvalidOperationException("Song not found: TESLA BOY (feat. Blaqbonez)");
                }
                od_22_1.SongID = song_22_1.SongID;

                db.OrderDetails.Add(od_22_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212022";

                AppUser customer23 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Christopher Baker");

                if (customer23 == null)
                {
                    throw new InvalidOperationException("Customer not found: Christopher Baker");
                }

                AppUser? friend23 = null;

                Card? card23 = db.Cards.FirstOrDefault(c => c.CardNumber == "5402487911641970");
                if (card23 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5402487911641970");
                }


                Order dbOrder23 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212022);

                if (dbOrder23 == null)
                {
                    dbOrder23 = new Order()
                    {
                        OrderNumber = 212022,
                        OrderDate = DateTime.Parse("2026-03-01 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer23.Id,
                        FriendID = friend23 != null ? friend23.Id : null,
                        CardID = card23.CardID
                    };

                    db.Orders.Add(dbOrder23);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder23.OrderNumber = 212022;
                    dbOrder23.OrderDate = DateTime.Parse("2026-03-01 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder23.Status = false;
                    dbOrder23.CustomerID = customer23.Id;
                    dbOrder23.FriendID = friend23 != null ? friend23.Id : null;
                    dbOrder23.CardID = card23.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder23.OrderID));
                    db.Update(dbOrder23);
                    db.SaveChanges();
                }


                OrderDetail od_23_1 = new OrderDetail()
                {
                    OrderID = dbOrder23.OrderID,
                    Price = 3.00m
                };

                Song? song_23_1 = db.Songs.FirstOrDefault(s => s.SongName == "Soca Soca");
                if (song_23_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Soca Soca");
                }
                od_23_1.SongID = song_23_1.SongID;

                db.OrderDetails.Add(od_23_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212023";

                AppUser customer24 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

                if (customer24 == null)
                {
                    throw new InvalidOperationException("Customer not found: Olivier Saint-Jean");
                }

                AppUser? friend24 = null;

                Card? card24 = db.Cards.FirstOrDefault(c => c.CardNumber == "5469290013187490");
                if (card24 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 5469290013187490");
                }


                Order dbOrder24 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212023);

                if (dbOrder24 == null)
                {
                    dbOrder24 = new Order()
                    {
                        OrderNumber = 212023,
                        OrderDate = DateTime.Parse("2026-03-02 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer24.Id,
                        FriendID = friend24 != null ? friend24.Id : null,
                        CardID = card24.CardID
                    };

                    db.Orders.Add(dbOrder24);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder24.OrderNumber = 212023;
                    dbOrder24.OrderDate = DateTime.Parse("2026-03-02 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder24.Status = false;
                    dbOrder24.CustomerID = customer24.Id;
                    dbOrder24.FriendID = friend24 != null ? friend24.Id : null;
                    dbOrder24.CardID = card24.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder24.OrderID));
                    db.Update(dbOrder24);
                    db.SaveChanges();
                }


                OrderDetail od_24_1 = new OrderDetail()
                {
                    OrderID = dbOrder24.OrderID,
                    Price = 11.00m
                };

                Album? album_24_1 = db.Albums.FirstOrDefault(a => a.AlbumName == "Please Excuse Me for Being Antisocial");
                if (album_24_1 == null)
                {
                    throw new InvalidOperationException("Album not found: Please Excuse Me for Being Antisocial");
                }
                od_24_1.AlbumID = album_24_1.AlbumID;

                db.OrderDetails.Add(od_24_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212024";

                AppUser customer25 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Tesa Freeley");

                if (customer25 == null)
                {
                    throw new InvalidOperationException("Customer not found: Tesa Freeley");
                }

                AppUser? friend25 = null;

                Card? card25 = db.Cards.FirstOrDefault(c => c.CardNumber == "6767489513462640");
                if (card25 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 6767489513462640");
                }


                Order dbOrder25 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212024);

                if (dbOrder25 == null)
                {
                    dbOrder25 = new Order()
                    {
                        OrderNumber = 212024,
                        OrderDate = DateTime.Parse("2026-03-04 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer25.Id,
                        FriendID = friend25 != null ? friend25.Id : null,
                        CardID = card25.CardID
                    };

                    db.Orders.Add(dbOrder25);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder25.OrderNumber = 212024;
                    dbOrder25.OrderDate = DateTime.Parse("2026-03-04 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder25.Status = false;
                    dbOrder25.CustomerID = customer25.Id;
                    dbOrder25.FriendID = friend25 != null ? friend25.Id : null;
                    dbOrder25.CardID = card25.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder25.OrderID));
                    db.Update(dbOrder25);
                    db.SaveChanges();
                }


                OrderDetail od_25_1 = new OrderDetail()
                {
                    OrderID = dbOrder25.OrderID,
                    Price = 2.00m
                };

                Song? song_25_1 = db.Songs.FirstOrDefault(s => s.SongName == "C# Debugger");
                if (song_25_1 == null)
                {
                    throw new InvalidOperationException("Song not found: C# Debugger");
                }
                od_25_1.SongID = song_25_1.SongID;

                db.OrderDetails.Add(od_25_1);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212025";

                AppUser customer26 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Wendy Chang");

                if (customer26 == null)
                {
                    throw new InvalidOperationException("Customer not found: Wendy Chang");
                }

                AppUser? friend26 = null;

                Card? card26 = db.Cards.FirstOrDefault(c => c.CardNumber == "6011485978941640");
                if (card26 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 6011485978941640");
                }


                Order dbOrder26 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212025);

                if (dbOrder26 == null)
                {
                    dbOrder26 = new Order()
                    {
                        OrderNumber = 212025,
                        OrderDate = DateTime.Now,
                        Status = false,
                        CustomerID = customer26.Id,
                        FriendID = friend26 != null ? friend26.Id : null,
                        CardID = card26.CardID
                    };

                    db.Orders.Add(dbOrder26);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder26.OrderNumber = 212025;
                    dbOrder26.OrderDate = DateTime.Now;
                    dbOrder26.Status = false;
                    dbOrder26.CustomerID = customer26.Id;
                    dbOrder26.FriendID = friend26 != null ? friend26.Id : null;
                    dbOrder26.CardID = card26.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder26.OrderID));
                    db.Update(dbOrder26);
                    db.SaveChanges();
                }


                OrderDetail od_26_1 = new OrderDetail()
                {
                    OrderID = dbOrder26.OrderID,
                    Price = 23.00m
                };

                Album? album_26_1 = db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours");
                if (album_26_1 == null)
                {
                    throw new InvalidOperationException("Album not found: Office Hours");
                }
                od_26_1.AlbumID = album_26_1.AlbumID;

                db.OrderDetails.Add(od_26_1);

                OrderDetail od_26_2 = new OrderDetail()
                {
                    OrderID = dbOrder26.OrderID,
                    Price = 20.00m
                };

                Album? album_26_2 = db.Albums.FirstOrDefault(a => a.AlbumName == "The Evil Genius");
                if (album_26_2 == null)
                {
                    throw new InvalidOperationException("Album not found: The Evil Genius");
                }
                od_26_2.AlbumID = album_26_2.AlbumID;

                db.OrderDetails.Add(od_26_2);

                db.SaveChanges();
                intOrdersAdded += 1;


                strOrderFlag = "Order Number 212026";

                AppUser customer27 = db.Users
                    .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

                if (customer27 == null)
                {
                    throw new InvalidOperationException("Customer not found: Clent Tucker");
                }

                AppUser? friend27 = null;

                Card? card27 = db.Cards.FirstOrDefault(c => c.CardNumber == "561479481465379");
                if (card27 == null)
                {
                    throw new InvalidOperationException("Card not found in database for card number: 561479481465379");
                }


                Order dbOrder27 = db.Orders
                    .Include(o => o.OrderDetails)
                    .FirstOrDefault(o => o.OrderNumber == 212026);

                if (dbOrder27 == null)
                {
                    dbOrder27 = new Order()
                    {
                        OrderNumber = 212026,
                        OrderDate = DateTime.Parse("2026-03-06 00:00:00", CultureInfo.InvariantCulture),
                        Status = false,
                        CustomerID = customer27.Id,
                        FriendID = friend27 != null ? friend27.Id : null,
                        CardID = card27.CardID
                    };

                    db.Orders.Add(dbOrder27);
                    db.SaveChanges();
                }
                else
                {
                    dbOrder27.OrderNumber = 212026;
                    dbOrder27.OrderDate = DateTime.Parse("2026-03-06 00:00:00", CultureInfo.InvariantCulture);
                    dbOrder27.Status = false;
                    dbOrder27.CustomerID = customer27.Id;
                    dbOrder27.FriendID = friend27 != null ? friend27.Id : null;
                    dbOrder27.CardID = card27.CardID;

                    db.OrderDetails.RemoveRange(db.OrderDetails.Where(od => od.OrderID == dbOrder27.OrderID));
                    db.Update(dbOrder27);
                    db.SaveChanges();
                }


                OrderDetail od_27_1 = new OrderDetail()
                {
                    OrderID = dbOrder27.OrderID,
                    Price = 3.00m
                };

                Song? song_27_1 = db.Songs.FirstOrDefault(s => s.SongName == "Hot In Herre");
                if (song_27_1 == null)
                {
                    throw new InvalidOperationException("Song not found: Hot In Herre");
                }
                od_27_1.SongID = song_27_1.SongID;

                db.OrderDetails.Add(od_27_1);

                OrderDetail od_27_2 = new OrderDetail()
                {
                    OrderID = dbOrder27.OrderID,
                    Price = 3.00m
                };

                Song? song_27_2 = db.Songs.FirstOrDefault(s => s.SongName == "Ice Ice Baby");
                if (song_27_2 == null)
                {
                    throw new InvalidOperationException("Song not found: Ice Ice Baby");
                }
                od_27_2.SongID = song_27_2.SongID;

                db.OrderDetails.Add(od_27_2);

                db.SaveChanges();
                intOrdersAdded += 1;


            }
            catch (Exception ex)
            {
                String msg = "Orders Added: " + intOrdersAdded +
                             "; Error on: " + strOrderFlag;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
