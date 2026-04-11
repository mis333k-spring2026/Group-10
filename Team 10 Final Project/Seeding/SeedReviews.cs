using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Team10FinalProject.Seeding
{

    public static class ReviewSeeder
    {
        public static void SeedAllReviews(AppDbContext db)
        {
            Int32 intReviewsAdded = 0;
            String strItemName = "Begin";

            List<Review> Reviews = new List<Review>();


            Review r1 = new Review()
            {
                Rating = 5,
                ReviewText = "Big hook, playful delivery, and a beat that still lands; a fun throwback single.",
                Status = true
            };

            AppUser reviewer1 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Christopher Baker");

            if (reviewer1 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Christopher Baker");
            }

            r1.ReviewerID = reviewer1.Id;


            AppUser approver1 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Emily Johnson");

            if (approver1 == null)
            {
                throw new InvalidOperationException("Approver not found: Emily Johnson");
            }

            r1.ApproverID = approver1.Id;


            Song song1 = db.Songs.FirstOrDefault(s => s.SongName == "Ice Ice Baby");
            Album album1 = db.Albums.FirstOrDefault(a => a.AlbumName == "Ice Ice Baby");
            Artist artist1 = db.Artists.FirstOrDefault(a => a.ArtistName == "Ice Ice Baby");

            if (song1 != null)
            {
                r1.SongID = song1.SongID;
            }
            else if (album1 != null)
            {
                r1.AlbumID = album1.AlbumID;
            }
            else if (artist1 != null)
            {
                r1.ArtistID = artist1.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Ice Ice Baby");
            }

            Reviews.Add(r1);


            Review r2 = new Review()
            {
                Rating = 5,
                ReviewText = "Energetic remix with punchy beats; a solid update that keeps the groove fresh.",
                Status = true
            };

            AppUser reviewer2 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Christopher Baker");

            if (reviewer2 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Christopher Baker");
            }

            r2.ReviewerID = reviewer2.Id;


            AppUser approver2 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "John Smith");

            if (approver2 == null)
            {
                throw new InvalidOperationException("Approver not found: John Smith");
            }

            r2.ApproverID = approver2.Id;


            Song song2 = db.Songs.FirstOrDefault(s => s.SongName == "Bootstrap Remix");
            Album album2 = db.Albums.FirstOrDefault(a => a.AlbumName == "Bootstrap Remix");
            Artist artist2 = db.Artists.FirstOrDefault(a => a.ArtistName == "Bootstrap Remix");

            if (song2 != null)
            {
                r2.SongID = song2.SongID;
            }
            else if (album2 != null)
            {
                r2.AlbumID = album2.AlbumID;
            }
            else if (artist2 != null)
            {
                r2.ArtistID = artist2.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Bootstrap Remix");
            }

            Reviews.Add(r2);


            Review r3 = new Review()
            {
                Rating = 3,
                ReviewText = "Catchy and recognizable, even if it leans more on nostalgia than depth.",
                Status = true
            };

            AppUser reviewer3 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

            if (reviewer3 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Clent Tucker");
            }

            r3.ReviewerID = reviewer3.Id;


            AppUser approver3 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Michael Williams");

            if (approver3 == null)
            {
                throw new InvalidOperationException("Approver not found: Michael Williams");
            }

            r3.ApproverID = approver3.Id;


            Song song3 = db.Songs.FirstOrDefault(s => s.SongName == "Ice Ice Baby");
            Album album3 = db.Albums.FirstOrDefault(a => a.AlbumName == "Ice Ice Baby");
            Artist artist3 = db.Artists.FirstOrDefault(a => a.ArtistName == "Ice Ice Baby");

            if (song3 != null)
            {
                r3.SongID = song3.SongID;
            }
            else if (album3 != null)
            {
                r3.AlbumID = album3.AlbumID;
            }
            else if (artist3 != null)
            {
                r3.ArtistID = artist3.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Ice Ice Baby");
            }

            Reviews.Add(r3);


            Review r4 = new Review()
            {
                Rating = 4,
                ReviewText = "Dark trap energy and cold delivery make this track feel gritty and relentless.",
                Status = false
            };

            AppUser reviewer4 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Margaret Garcia");

            if (reviewer4 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Margaret Garcia");
            }

            r4.ReviewerID = reviewer4.Id;


            AppUser approver4 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Stephanie Lopez");

            if (approver4 == null)
            {
                throw new InvalidOperationException("Approver not found: Stephanie Lopez");
            }

            r4.ApproverID = approver4.Id;


            Song song4 = db.Songs.FirstOrDefault(s => s.SongName == "No Heart");
            Album album4 = db.Albums.FirstOrDefault(a => a.AlbumName == "No Heart");
            Artist artist4 = db.Artists.FirstOrDefault(a => a.ArtistName == "No Heart");

            if (song4 != null)
            {
                r4.SongID = song4.SongID;
            }
            else if (album4 != null)
            {
                r4.AlbumID = album4.AlbumID;
            }
            else if (artist4 != null)
            {
                r4.ArtistID = artist4.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: No Heart");
            }

            Reviews.Add(r4);


            Review r5 = new Review()
            {
                Rating = 4,
                ReviewText = "Club-ready production and an easy chorus make this one reliably entertaining.",
                Status = true
            };

            AppUser reviewer5 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

            if (reviewer5 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Olivier Saint-Jean");
            }

            r5.ReviewerID = reviewer5.Id;


            AppUser approver5 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Sarah Brown");

            if (approver5 == null)
            {
                throw new InvalidOperationException("Approver not found: Sarah Brown");
            }

            r5.ApproverID = approver5.Id;


            Song song5 = db.Songs.FirstOrDefault(s => s.SongName == "Hot In Herre");
            Album album5 = db.Albums.FirstOrDefault(a => a.AlbumName == "Hot In Herre");
            Artist artist5 = db.Artists.FirstOrDefault(a => a.ArtistName == "Hot In Herre");

            if (song5 != null)
            {
                r5.SongID = song5.SongID;
            }
            else if (album5 != null)
            {
                r5.AlbumID = album5.AlbumID;
            }
            else if (artist5 != null)
            {
                r5.ArtistID = artist5.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Hot In Herre");
            }

            Reviews.Add(r5);


            Review r6 = new Review()
            {
                Rating = 4,
                ReviewText = "Catchy hook and confident verses; a defining trap anthem of its era.",
                Status = true
            };

            AppUser reviewer6 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

            if (reviewer6 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Olivier Saint-Jean");
            }

            r6.ReviewerID = reviewer6.Id;


            AppUser approver6 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Lauren Wilson");

            if (approver6 == null)
            {
                throw new InvalidOperationException("Approver not found: Lauren Wilson");
            }

            r6.ApproverID = approver6.Id;


            Song song6 = db.Songs.FirstOrDefault(s => s.SongName == "Bad and Boujee (feat. Lil Uzi Vert)");
            Album album6 = db.Albums.FirstOrDefault(a => a.AlbumName == "Bad and Boujee (feat. Lil Uzi Vert)");
            Artist artist6 = db.Artists.FirstOrDefault(a => a.ArtistName == "Bad and Boujee (feat. Lil Uzi Vert)");

            if (song6 != null)
            {
                r6.SongID = song6.SongID;
            }
            else if (album6 != null)
            {
                r6.AlbumID = album6.AlbumID;
            }
            else if (artist6 != null)
            {
                r6.ArtistID = artist6.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Bad and Boujee (feat. Lil Uzi Vert)");
            }

            Reviews.Add(r6);


            Review r7 = new Review()
            {
                Rating = 4,
                ReviewText = "Iconic bassline and haunting groove; one of pop’s most unforgettable tracks.",
                Status = true
            };

            AppUser reviewer7 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

            if (reviewer7 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Clent Tucker");
            }

            r7.ReviewerID = reviewer7.Id;


            AppUser approver7 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Ashley Davis");

            if (approver7 == null)
            {
                throw new InvalidOperationException("Approver not found: Ashley Davis");
            }

            r7.ApproverID = approver7.Id;


            Song song7 = db.Songs.FirstOrDefault(s => s.SongName == "Billie Jean");
            Album album7 = db.Albums.FirstOrDefault(a => a.AlbumName == "Billie Jean");
            Artist artist7 = db.Artists.FirstOrDefault(a => a.ArtistName == "Billie Jean");

            if (song7 != null)
            {
                r7.SongID = song7.SongID;
            }
            else if (album7 != null)
            {
                r7.AlbumID = album7.AlbumID;
            }
            else if (artist7 != null)
            {
                r7.ArtistID = artist7.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Billie Jean");
            }

            Reviews.Add(r7);


            Review r8 = new Review()
            {
                Rating = 5,
                ReviewText = "Sharp lyrics and playful attitude; Eminem at his most entertaining.",
                Status = true
            };

            AppUser reviewer8 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

            if (reviewer8 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Olivier Saint-Jean");
            }

            r8.ReviewerID = reviewer8.Id;


            AppUser approver8 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Lauren Wilson");

            if (approver8 == null)
            {
                throw new InvalidOperationException("Approver not found: Lauren Wilson");
            }

            r8.ApproverID = approver8.Id;


            Song song8 = db.Songs.FirstOrDefault(s => s.SongName == "Without Me");
            Album album8 = db.Albums.FirstOrDefault(a => a.AlbumName == "Without Me");
            Artist artist8 = db.Artists.FirstOrDefault(a => a.ArtistName == "Without Me");

            if (song8 != null)
            {
                r8.SongID = song8.SongID;
            }
            else if (album8 != null)
            {
                r8.AlbumID = album8.AlbumID;
            }
            else if (artist8 != null)
            {
                r8.ArtistID = artist8.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Without Me");
            }

            Reviews.Add(r8);


            Review r9 = new Review()
            {
                Rating = 4,
                ReviewText = "High-energy production packed with bold beats and flashy collaborations.",
                Status = false
            };

            AppUser reviewer9 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Olivier Saint-Jean");

            if (reviewer9 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Olivier Saint-Jean");
            }

            r9.ReviewerID = reviewer9.Id;


            AppUser approver9 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Daniel Miller");

            if (approver9 == null)
            {
                throw new InvalidOperationException("Approver not found: Daniel Miller");
            }

            r9.ApproverID = approver9.Id;


            Song song9 = db.Songs.FirstOrDefault(s => s.SongName == "Shock Value");
            Album album9 = db.Albums.FirstOrDefault(a => a.AlbumName == "Shock Value");
            Artist artist9 = db.Artists.FirstOrDefault(a => a.ArtistName == "Shock Value");

            if (song9 != null)
            {
                r9.SongID = song9.SongID;
            }
            else if (album9 != null)
            {
                r9.AlbumID = album9.AlbumID;
            }
            else if (artist9 != null)
            {
                r9.ArtistID = artist9.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Shock Value");
            }

            Reviews.Add(r9);


            Review r10 = new Review()
            {
                Rating = 4,
                ReviewText = "Fast-paced and catchy; the back-and-forth delivery keeps the song moving the whole time.",
                Status = false
            };

            AppUser reviewer10 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Margaret Garcia");

            if (reviewer10 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Margaret Garcia");
            }

            r10.ReviewerID = reviewer10.Id;


            Song song10 = db.Songs.FirstOrDefault(s => s.SongName == "Sprinter");
            Album album10 = db.Albums.FirstOrDefault(a => a.AlbumName == "Sprinter");
            Artist artist10 = db.Artists.FirstOrDefault(a => a.ArtistName == "Sprinter");

            if (song10 != null)
            {
                r10.SongID = song10.SongID;
            }
            else if (album10 != null)
            {
                r10.AlbumID = album10.AlbumID;
            }
            else if (artist10 != null)
            {
                r10.ArtistID = artist10.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Sprinter");
            }

            Reviews.Add(r10);


            Review r11 = new Review()
            {
                Rating = 5,
                ReviewText = "Warm groove, strong rhythm, and an easy chorus make this one an instant repeat.",
                Status = false
            };

            AppUser reviewer11 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

            if (reviewer11 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Clent Tucker");
            }

            r11.ReviewerID = reviewer11.Id;


            Song song11 = db.Songs.FirstOrDefault(s => s.SongName == "Could You Be Loved");
            Album album11 = db.Albums.FirstOrDefault(a => a.AlbumName == "Could You Be Loved");
            Artist artist11 = db.Artists.FirstOrDefault(a => a.ArtistName == "Could You Be Loved");

            if (song11 != null)
            {
                r11.SongID = song11.SongID;
            }
            else if (album11 != null)
            {
                r11.AlbumID = album11.AlbumID;
            }
            else if (artist11 != null)
            {
                r11.ArtistID = artist11.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Could You Be Loved");
            }

            Reviews.Add(r11);


            Review r12 = new Review()
            {
                Rating = 2,
                ReviewText = "The hook is memorable, but the track feels repetitive after a few listens.",
                Status = false
            };

            AppUser reviewer12 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "Clent Tucker");

            if (reviewer12 == null)
            {
                throw new InvalidOperationException("Reviewer not found: Clent Tucker");
            }

            r12.ReviewerID = reviewer12.Id;


            AppUser approver12 = db.Users
                .FirstOrDefault(u => (u.FirstName + " " + u.LastName) == "David Jones");

            if (approver12 == null)
            {
                throw new InvalidOperationException("Approver not found: David Jones");
            }

            r12.ApproverID = approver12.Id;


            Song song12 = db.Songs.FirstOrDefault(s => s.SongName == "Hot In Herre");
            Album album12 = db.Albums.FirstOrDefault(a => a.AlbumName == "Hot In Herre");
            Artist artist12 = db.Artists.FirstOrDefault(a => a.ArtistName == "Hot In Herre");

            if (song12 != null)
            {
                r12.SongID = song12.SongID;
            }
            else if (album12 != null)
            {
                r12.AlbumID = album12.AlbumID;
            }
            else if (artist12 != null)
            {
                r12.ArtistID = artist12.ArtistID;
            }
            else
            {
                throw new InvalidOperationException("Review item not found: Hot In Herre");
            }

            Reviews.Add(r12);


            try
            {
                foreach (Review reviewToAdd in Reviews)
                {
                    strItemName = reviewToAdd.SongID != null ? db.Songs.First(s => s.SongID == reviewToAdd.SongID).SongName :
                                  reviewToAdd.AlbumID != null ? db.Albums.First(a => a.AlbumID == reviewToAdd.AlbumID).AlbumName :
                                  db.Artists.First(a => a.ArtistID == reviewToAdd.ArtistID).ArtistName;

                    Review dbReview = db.Reviews
                        .FirstOrDefault(r =>
                            r.ReviewerID == reviewToAdd.ReviewerID &&
                            r.SongID == reviewToAdd.SongID &&
                            r.AlbumID == reviewToAdd.AlbumID &&
                            r.ArtistID == reviewToAdd.ArtistID);

                    if (dbReview == null)
                    {
                        db.Reviews.Add(reviewToAdd);
                    }
                    else
                    {
                        dbReview.Rating = reviewToAdd.Rating;
                        dbReview.ReviewText = reviewToAdd.ReviewText;
                        dbReview.Status = reviewToAdd.Status;
                        dbReview.ApproverID = reviewToAdd.ApproverID;

                        db.Update(dbReview);
                    }

                    db.SaveChanges();
                    intReviewsAdded += 1;
                }
            }
            catch (Exception ex)
            {
                String msg = "Reviews Added: " + intReviewsAdded +
                             "; Error on Item: " + strItemName;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
