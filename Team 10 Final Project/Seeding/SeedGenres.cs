using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Team10FinalProject.Seeding
{

    public static class GenreSeeder
    {
        public static void SeedAllGenres(AppDbContext db)
        {
            Int32 intGenresAdded = 0;
            String strGenreName = "Begin";

            List<Genre> Genres = new List<Genre>();


            Genre g1 = new Genre()
            {
                GenreName = "pop"
            };

            Genres.Add(g1);


            Genre g2 = new Genre()
            {
                GenreName = "hip-hop"
            };

            Genres.Add(g2);


            Genre g3 = new Genre()
            {
                GenreName = "arabic"
            };

            Genres.Add(g3);


            Genre g4 = new Genre()
            {
                GenreName = "brazilian"
            };

            Genres.Add(g4);


            Genre g5 = new Genre()
            {
                GenreName = "electronic"
            };

            Genres.Add(g5);


            Genre g6 = new Genre()
            {
                GenreName = "gaming"
            };

            Genres.Add(g6);


            Genre g7 = new Genre()
            {
                GenreName = "latin"
            };

            Genres.Add(g7);


            Genre g8 = new Genre()
            {
                GenreName = "rock"
            };

            Genres.Add(g8);


            Genre g9 = new Genre()
            {
                GenreName = "reggae"
            };

            Genres.Add(g9);


            Genre g10 = new Genre()
            {
                GenreName = "r&b"
            };

            Genres.Add(g10);


            Genre g11 = new Genre()
            {
                GenreName = "afrobeats"
            };

            Genres.Add(g11);


            Genre g12 = new Genre()
            {
                GenreName = "ambient"
            };

            Genres.Add(g12);


            Genre g13 = new Genre()
            {
                GenreName = "soca"
            };

            Genres.Add(g13);


            Genre g14 = new Genre()
            {
                GenreName = "lofi"
            };

            Genres.Add(g14);


            Genre g15 = new Genre()
            {
                GenreName = "world"
            };

            Genres.Add(g15);


            Genre g16 = new Genre()
            {
                GenreName = "classroom"
            };

            Genres.Add(g16);


            try
            {
                foreach (Genre genreToAdd in Genres)
                {
                    strGenreName = genreToAdd.GenreName;

                    Genre dbGenre = db.Genres
                        .FirstOrDefault(g => g.GenreName == genreToAdd.GenreName);

                    if (dbGenre == null)
                    {
                        db.Genres.Add(genreToAdd);
                    }
                    else
                    {
                        dbGenre.GenreName = genreToAdd.GenreName;
                        db.Update(dbGenre);
                    }

                    db.SaveChanges();
                    intGenresAdded += 1;
                }
            }
            catch (Exception ex)
            {
                String msg = "Genres Added: " + intGenresAdded +
                             "; Error on Genre: " + strGenreName;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
