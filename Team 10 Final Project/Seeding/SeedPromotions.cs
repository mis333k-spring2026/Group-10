using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Team10FinalProject.Seeding
{

    public static class PromotionSeeder
    {
        public static void SeedAllPromotions(AppDbContext db)
        {
            Int32 intPromotionsAdded = 0;
            String strPromotionFlag = "Begin";

            List<Promotion> Promotions = new List<Promotion>();


            Promotion p1 = new Promotion()
            {
                PromotionType = "Featured",
                PromotionStatus = true,
                DiscountAmount = null
            };


            p1.Artist = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Hacker");
            if (p1.Artist == null)
            {
                throw new InvalidOperationException("Artist not found: Bee Hacker");
            }


            Promotions.Add(p1);


            Promotion p2 = new Promotion()
            {
                PromotionType = "Featured",
                PromotionStatus = false,
                DiscountAmount = null
            };


            p2.Album = db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze");
            if (p2.Album == null)
            {
                throw new InvalidOperationException("Album not found: Code Freeze");
            }


            Promotions.Add(p2);


            Promotion p3 = new Promotion()
            {
                PromotionType = "Featured",
                PromotionStatus = false,
                DiscountAmount = null
            };


            p3.Song = db.Songs.FirstOrDefault(s => s.SongName == "Without Me");
            if (p3.Song == null)
            {
                throw new InvalidOperationException("Song not found: Without Me");
            }


            Promotions.Add(p3);


            Promotion p4 = new Promotion()
            {
                PromotionType = "Discount",
                PromotionStatus = true,
                DiscountAmount = 1.00m
            };


            p4.Song = db.Songs.FirstOrDefault(s => s.SongName == "Another One Bites The Dust - Remastered 2011");
            if (p4.Song == null)
            {
                throw new InvalidOperationException("Song not found: Another One Bites The Dust - Remastered 2011");
            }


            Promotions.Add(p4);


            Promotion p5 = new Promotion()
            {
                PromotionType = "Discount",
                PromotionStatus = true,
                DiscountAmount = 1.50m
            };


            p5.Song = db.Songs.FirstOrDefault(s => s.SongName == "JSON Cipher");
            if (p5.Song == null)
            {
                throw new InvalidOperationException("Song not found: JSON Cipher");
            }


            Promotions.Add(p5);


            Promotion p6 = new Promotion()
            {
                PromotionType = "Discount",
                PromotionStatus = true,
                DiscountAmount = 4.75m
            };


            p6.Album = db.Albums.FirstOrDefault(a => a.AlbumName == "Everybody Loves Ice Prince");
            if (p6.Album == null)
            {
                throw new InvalidOperationException("Album not found: Everybody Loves Ice Prince");
            }


            Promotions.Add(p6);


            Promotion p7 = new Promotion()
            {
                PromotionType = "Discount",
                PromotionStatus = true,
                DiscountAmount = 5.25m
            };


            p7.Album = db.Albums.FirstOrDefault(a => a.AlbumName == "One of Wun");
            if (p7.Album == null)
            {
                throw new InvalidOperationException("Album not found: One of Wun");
            }


            Promotions.Add(p7);


            Promotion p8 = new Promotion()
            {
                PromotionType = "Discount",
                PromotionStatus = false,
                DiscountAmount = 10.00m
            };


            p8.Song = db.Songs.FirstOrDefault(s => s.SongName == "SQL Anthem");
            if (p8.Song == null)
            {
                throw new InvalidOperationException("Song not found: SQL Anthem");
            }


            Promotions.Add(p8);


            Promotion p9 = new Promotion()
            {
                PromotionType = "Discount",
                PromotionStatus = false,
                DiscountAmount = 10.00m
            };


            p9.Album = db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody");
            if (p9.Album == null)
            {
                throw new InvalidOperationException("Album not found: Refactor Rhapsody");
            }


            Promotions.Add(p9);


            try
            {
                foreach (Promotion promotionToAdd in Promotions)
                {
                    if (promotionToAdd.Song != null)
                    {
                        strPromotionFlag = promotionToAdd.Song.SongName;
                    }
                    else if (promotionToAdd.Album != null)
                    {
                        strPromotionFlag = promotionToAdd.Album.AlbumName;
                    }
                    else if (promotionToAdd.Artist != null)
                    {
                        strPromotionFlag = promotionToAdd.Artist.ArtistName;
                    }

                    Promotion dbPromotion = db.Promotions
                        .Include(p => p.Song)
                        .Include(p => p.Album)
                        .Include(p => p.Artist)
                        .FirstOrDefault(p =>
                            p.PromotionType == promotionToAdd.PromotionType &&
                            ((p.Song != null && promotionToAdd.Song != null && p.Song.SongName == promotionToAdd.Song.SongName) ||
                             (p.Album != null && promotionToAdd.Album != null && p.Album.AlbumName == promotionToAdd.Album.AlbumName) ||
                             (p.Artist != null && promotionToAdd.Artist != null && p.Artist.ArtistName == promotionToAdd.Artist.ArtistName)));

                    if (dbPromotion == null)
                    {
                        db.Promotions.Add(promotionToAdd);
                    }
                    else
                    {
                        dbPromotion.PromotionType = promotionToAdd.PromotionType;
                        dbPromotion.DiscountAmount = promotionToAdd.DiscountAmount;
                        dbPromotion.PromotionStatus = promotionToAdd.PromotionStatus;
                        dbPromotion.Song = promotionToAdd.Song;
                        dbPromotion.Album = promotionToAdd.Album;
                        dbPromotion.Artist = promotionToAdd.Artist;

                        db.Update(dbPromotion);
                    }

                    db.SaveChanges();
                    intPromotionsAdded += 1;
                }
            }
            catch (Exception ex)
            {
                String msg = "Promotions Added: " + intPromotionsAdded +
                             "; Error on Promotion: " + strPromotionFlag;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
