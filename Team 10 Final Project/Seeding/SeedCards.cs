using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Team10FinalProject.Seeding
{

    public static class CardSeeder
    {
        public static void SeedAllCards(AppDbContext db)
        {
            Int32 intCardsAdded = 0;
            String strCardNumber = "Begin";

            List<Card> Cards = new List<Card>();


            AppUser customer1 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Christopher Baker");

            if (customer1 == null)
            {
                throw new InvalidOperationException("Customer not found: Christopher Baker");
            }

            Card c1 = new Card()
            {
                CardNumber = "5402487911641970",
                CardType = "MasterCard",
                CustomerID = customer1.Id
            };

            Cards.Add(c1);


            AppUser customer2 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Margaret Garcia");

            if (customer2 == null)
            {
                throw new InvalidOperationException("Customer not found: Margaret Garcia");
            }

            Card c2 = new Card()
            {
                CardNumber = "4040646714659780",
                CardType = "Visa",
                CustomerID = customer2.Id
            };

            Cards.Add(c2);


            AppUser customer3 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

            if (customer3 == null)
            {
                throw new InvalidOperationException("Customer not found: Clent Tucker");
            }

            Card c3 = new Card()
            {
                CardNumber = "561479481465379",
                CardType = "Amex",
                CustomerID = customer3.Id
            };

            Cards.Add(c3);


            AppUser customer4 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

            if (customer4 == null)
            {
                throw new InvalidOperationException("Customer not found: Olivier Saint-Jean");
            }

            Card c4 = new Card()
            {
                CardNumber = "5469290013187490",
                CardType = "MasterCard",
                CustomerID = customer4.Id
            };

            Cards.Add(c4);


            AppUser customer5 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Wendy Chang");

            if (customer5 == null)
            {
                throw new InvalidOperationException("Customer not found: Wendy Chang");
            }

            Card c5 = new Card()
            {
                CardNumber = "6011485978941640",
                CardType = "Discover",
                CustomerID = customer5.Id
            };

            Cards.Add(c5);


            AppUser customer6 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Jennifer MacLeod");

            if (customer6 == null)
            {
                throw new InvalidOperationException("Customer not found: Jennifer MacLeod");
            }

            Card c6 = new Card()
            {
                CardNumber = "4584794615342670",
                CardType = "Visa",
                CustomerID = customer6.Id
            };

            Cards.Add(c6);


            AppUser customer7 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Tesa Freeley");

            if (customer7 == null)
            {
                throw new InvalidOperationException("Customer not found: Tesa Freeley");
            }

            Card c7 = new Card()
            {
                CardNumber = "6767489513462640",
                CardType = "Discover",
                CustomerID = customer7.Id
            };

            Cards.Add(c7);


            AppUser customer8 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "John Hearn");

            if (customer8 == null)
            {
                throw new InvalidOperationException("Customer not found: John Hearn");
            }

            Card c8 = new Card()
            {
                CardNumber = "865146254978453",
                CardType = "Amex",
                CustomerID = customer8.Id
            };

            Cards.Add(c8);


            AppUser customer9 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Eric Stuart");

            if (customer9 == null)
            {
                throw new InvalidOperationException("Customer not found: Eric Stuart");
            }

            Card c9 = new Card()
            {
                CardNumber = "5489761548972350",
                CardType = "MasterCard",
                CustomerID = customer9.Id
            };

            Cards.Add(c9);


            AppUser customer10 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Michelle Banks");

            if (customer10 == null)
            {
                throw new InvalidOperationException("Customer not found: Michelle Banks");
            }

            Card c10 = new Card()
            {
                CardNumber = "4011798411664850",
                CardType = "Visa",
                CustomerID = customer10.Id
            };

            Cards.Add(c10);


            try
            {
                foreach (Card cardToAdd in Cards)
                {
                    strCardNumber = cardToAdd.CardNumber;

                    Card dbCard = db.Cards
                        .Include(c => c.Customer)
                        .FirstOrDefault(c => c.CardNumber == cardToAdd.CardNumber);

                    if (dbCard == null)
                    {
                        db.Cards.Add(cardToAdd);
                    }
                    else
                    {
                        dbCard.CardNumber = cardToAdd.CardNumber;
                        dbCard.CardType = cardToAdd.CardType;
                        dbCard.CustomerID = cardToAdd.CustomerID;

                        db.Update(dbCard);
                    }

                    db.SaveChanges();
                    intCardsAdded += 1;
                }
            }
            catch (Exception ex)
            {
                String msg = "Cards Added: " + intCardsAdded +
                             "; Error on Card: " + strCardNumber;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
