using Team10FinalProject.DAL;
using Team10FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Team10FinalProject.Seeding
{

    public static class SongSeeder
    {
        public static void SeedAllSongs(AppDbContext db)
        {
            Int32 intSongsAdded = 0;
            String strSongName = "Begin";

            List<Song> Songs = new List<Song>();


            Song s1 = new Song()
            {
                SongName = "Ice Ice Baby",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Vanilla Ice").ArtistID            };

            s1.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Vanilla Ice Is Back! - Hip Hop Classics"));
            s1.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s1.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s1);


            Song s2 = new Song()
            {
                SongName = "Give It To Me",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Timbaland").ArtistID            };

            s2.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Shock Value"));
            s2.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s2.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s2.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s2.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s2);


            Song s3 = new Song()
            {
                SongName = "NISSAN ALTIMA",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Doechii").ArtistID            };

            s3.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Alligator Bites Never Heal"));
            s3.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s3);


            Song s4 = new Song()
            {
                SongName = "Baby (Lil Baby feat. DaBaby)",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Quality Control").ArtistID            };

            s4.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Quality Control: Control The Streets Volume 2"));
            s4.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "La Cumbia De Carmelo"));
            s4.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s4.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s4.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s4.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s4);


            Song s5 = new Song()
            {
                SongName = "Dior",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Shubh").ArtistID            };

            s5.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Still Rollin"));
            s5.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s5.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s5);


            Song s6 = new Song()
            {
                SongName = "Yes Indeed",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Lil Baby").ArtistID            };

            s6.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Harder Than Ever"));
            s6.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s6.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s6.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s6);


            Song s7 = new Song()
            {
                SongName = "Low Down",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Lil Baby").ArtistID            };

            s7.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "My Turn (Deluxe)"));
            s7.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s7);


            Song s8 = new Song()
            {
                SongName = "Se Voce Nao Quer Passa a Vez",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Mc Delux").ArtistID            };

            s8.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Se Voce Nao Quer Passa a Vez"));
            s8.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Please Excuse Me for Being Antisocial"));
            s8.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s8);


            Song s9 = new Song()
            {
                SongName = "Around the World",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Daft Punk").ArtistID            };

            s9.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Homework"));
            s9.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s9.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Beam Me Up"));
            s9.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s9);


            Song s10 = new Song()
            {
                SongName = "Hot In Herre",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Nelly").ArtistID            };

            s10.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Nellyville"));
            s10.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s10.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));
            s10.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s10);


            Song s11 = new Song()
            {
                SongName = "Temperature",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Sean Paul").ArtistID            };

            s11.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "The Trinity"));
            s11.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s11.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s11);


            Song s12 = new Song()
            {
                SongName = "Ela Joga na Hora",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Mc Pogba").ArtistID            };

            s12.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Ela Joga na Hora"));
            s12.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s12.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s12);


            Song s13 = new Song()
            {
                SongName = "Still Think About You",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "A Boogie Wit da Hoodie").ArtistID            };

            s13.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Artist"));
            s13.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s13.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s13.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s13);


            Song s14 = new Song()
            {
                SongName = "Lovin On Me",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jack Harlow").ArtistID            };

            s14.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Lovin On Me"));
            s14.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s14);


            Song s15 = new Song()
            {
                SongName = "Que Se Cuide",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Luis R Conriquez").ArtistID            };

            s15.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Que Se Cuide"));
            s15.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s15.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s15);


            Song s16 = new Song()
            {
                SongName = "Houdini",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Eminem").ArtistID            };

            s16.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Houdini"));
            s16.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s16.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s16.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s16);


            Song s17 = new Song()
            {
                SongName = "Check Yo Self - Remix",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Ice Cube").ArtistID            };

            s17.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bootlegs And B-Sides"));
            s17.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s17.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s17);


            Song s18 = new Song()
            {
                SongName = "Another One Bites The Dust - Remastered 2011",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Queen").ArtistID            };

            s18.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "The Game (Deluxe Remastered Version)"));
            s18.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s18.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s18.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s18.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s18.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s18);


            Song s19 = new Song()
            {
                SongName = "Buffalo Soldier",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bob Marley & The Wailers").ArtistID            };

            s19.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Confrontation"));
            s19.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Body"));
            s19.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s19.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s19);


            Song s20 = new Song()
            {
                SongName = "Bad and Boujee (feat. Lil Uzi Vert)",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Migos").ArtistID            };

            s20.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Culture"));
            s20.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Tu Hablas Espanhol"));
            s20.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s20);


            Song s21 = new Song()
            {
                SongName = "We Paid (feat. 42 Dugg)",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Lil Baby").ArtistID            };

            s21.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "My Turn (Deluxe)"));
            s21.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s21.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s21);


            Song s22 = new Song()
            {
                SongName = "Si Antes Te Hubiera Conocido",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "KAROL G").ArtistID            };

            s22.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Si Antes Te Hubiera Conocido"));
            s22.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s22.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s22);


            Song s23 = new Song()
            {
                SongName = "UK Rap",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dave").ArtistID            };

            s23.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Split Decision"));
            s23.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s23);


            Song s24 = new Song()
            {
                SongName = "Moonlight",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "XXXTENTACION").ArtistID            };

            s24.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "?"));
            s24.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Un Verano Sin Ti"));
            s24.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s24.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s24.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s24);


            Song s25 = new Song()
            {
                SongName = "Billie Jean",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Michael Jackson").ArtistID            };

            s25.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Thriller 25 Super Deluxe Edition"));
            s25.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s25.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s25.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s25);


            Song s26 = new Song()
            {
                SongName = "Coffin",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Lil Yachty").ArtistID            };

            s26.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Lil Boat 3.5"));
            s26.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s26.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s26);


            Song s27 = new Song()
            {
                SongName = "Faz um Vuk Vuk (Teto Espelhado)",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "MC Kevin o Chris").ArtistID            };

            s27.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Faz um Vuk Vuk (Teto Espelhado)"));
            s27.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s27.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s27.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s27.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s27.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s27);


            Song s28 = new Song()
            {
                SongName = "ATLiens",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Outkast").ArtistID            };

            s28.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "ATLiens"));
            s28.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Hey Hou"));
            s28.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s28.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s28);


            Song s29 = new Song()
            {
                SongName = "Sprinter",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dave").ArtistID            };

            s29.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprinter"));
            s29.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s29.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s29);


            Song s30 = new Song()
            {
                SongName = "Could You Be Loved",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bob Marley & The Wailers").ArtistID            };

            s30.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Uprising"));
            s30.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s30.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s30.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s30);


            Song s31 = new Song()
            {
                SongName = "TEFLON DON",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Future").ArtistID            };

            s31.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "MIXTAPE PLUTO"));
            s31.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s31.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s31);


            Song s32 = new Song()
            {
                SongName = "one of wun",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gunna").ArtistID            };

            s32.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "One of Wun"));
            s32.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s32.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Lovin On Me"));
            s32.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s32.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s32);


            Song s33 = new Song()
            {
                SongName = "PERRO NEGRO",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bad Bunny").ArtistID            };

            s33.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "nadie sabe lo que va a pasar manana"));
            s33.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s33.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s33.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s33.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s33);


            Song s34 = new Song()
            {
                SongName = "Me Porto Bonito",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bad Bunny").ArtistID            };

            s34.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Un Verano Sin Ti"));
            s34.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s34.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s34.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s34);


            Song s35 = new Song()
            {
                SongName = "Doja",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Central Cee").ArtistID            };

            s35.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Doja"));
            s35.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s35.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s35.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s35);


            Song s36 = new Song()
            {
                SongName = "Family Affair",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Mary J. Blige").ArtistID            };

            s36.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "No More Drama"));
            s36.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Life After Death (2014 Remastered Edition)"));
            s36.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s36.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s36.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s36);


            Song s37 = new Song()
            {
                SongName = "Without Me",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Eminem").ArtistID            };

            s37.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "The Eminem Show"));
            s37.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s37.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s37.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s37);


            Song s38 = new Song()
            {
                SongName = "No Heart",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "21 Savage").ArtistID            };

            s38.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Savage Mode"));
            s38.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wahala"));
            s38.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s38.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s38.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s38);


            Song s39 = new Song()
            {
                SongName = "The Largest",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "BigXthaPlug").ArtistID            };

            s39.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "The Largest"));
            s39.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s39.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s39);


            Song s40 = new Song()
            {
                SongName = "Hypnotize - 2014 Remaster",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "The Notorious B.I.G.").ArtistID            };

            s40.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Life After Death (2014 Remastered Edition)"));
            s40.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s40.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Quest for Coin II"));
            s40.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s40.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s40);


            Song s41 = new Song()
            {
                SongName = "Still Not a Player (feat. Joe) - Radio Version",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Big Pun").ArtistID            };

            s41.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Capital Punishment"));
            s41.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s41);


            Song s42 = new Song()
            {
                SongName = "Nada",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Cazzu").ArtistID            };

            s42.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Error 93"));
            s42.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "One of Wun"));
            s42.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Artist"));
            s42.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s42.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s42.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s42);


            Song s43 = new Song()
            {
                SongName = "THE SHADE",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Rex Orange County").ArtistID            };

            s43.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "WHO CARES?"));
            s43.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s43.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s43);


            Song s44 = new Song()
            {
                SongName = "Not Like Us",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kendrick Lamar").ArtistID            };

            s44.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Not Like Us"));
            s44.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Shorty"));
            s44.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s44.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s44.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s44);


            Song s45 = new Song()
            {
                SongName = "Neighbors",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "J. Cole").ArtistID            };

            s45.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "4 Your Eyez Only"));
            s45.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s45.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s45);


            Song s46 = new Song()
            {
                SongName = "Kiss",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Prince").ArtistID            };

            s46.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Parade - Music from the Motion Picture Under the Cherry Moon"));
            s46.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s46.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s46);


            Song s47 = new Song()
            {
                SongName = "JUJU (feat. Shallipopi)",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Smur Lee").ArtistID            };

            s47.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "JUJU (feat. Shallipopi)"));
            s47.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s47.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s47);


            Song s48 = new Song()
            {
                SongName = "Drip Too Hard (Lil Baby & Gunna)",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Lil Baby").ArtistID            };

            s48.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Drip Harder"));
            s48.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s48.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s48.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s48);


            Song s49 = new Song()
            {
                SongName = "Insane in the Brain",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Cypress Hill").ArtistID            };

            s49.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Black Sunday"));
            s49.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s49.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s49);


            Song s50 = new Song()
            {
                SongName = "The Box",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Roddy Ricch").ArtistID            };

            s50.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Please Excuse Me for Being Antisocial"));
            s50.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Vanilla Ice Is Back! - Hip Hop Classics"));
            s50.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s50);


            Song s51 = new Song()
            {
                SongName = "Jogadinha do Paqueta",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Mc Rf").ArtistID            };

            s51.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Jogadinha do Paqueta"));
            s51.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s51);


            Song s52 = new Song()
            {
                SongName = "Bumbum granada",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "MC's Zaac").ArtistID            };

            s52.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bumbum granada"));
            s52.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s52);


            Song s53 = new Song()
            {
                SongName = "Tchikita",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jul").ArtistID            };

            s53.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Tchikita"));
            s53.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s53);


            Song s54 = new Song()
            {
                SongName = "Normally (feat. NSG)",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "JAE5").ArtistID            };

            s54.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Normally (feat. NSG)"));
            s54.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s54.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s54);


            Song s55 = new Song()
            {
                SongName = "Peru",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Fireboy DML").ArtistID            };

            s55.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Peru"));
            s55.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Still Rollin"));
            s55.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s55.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s55);


            Song s56 = new Song()
            {
                SongName = "Tu Hablas Espanhol",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Mc Delux").ArtistID            };

            s56.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Tu Hablas Espanhol"));
            s56.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Confrontation"));
            s56.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s56.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s56);


            Song s57 = new Song()
            {
                SongName = "Abo Nokthula (feat. The Exclusive SA, Scotts Maphuma, Kabelo Sings, Bontle Smith, 2woshort & Stompiiey)",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "TNK MusiQ").ArtistID            };

            s57.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Abo Nokthula"));
            s57.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s57.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s57);


            Song s58 = new Song()
            {
                SongName = "Like Dat",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Lil Frosh").ArtistID            };

            s58.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Beyond Infinity"));
            s58.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s58.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s58.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s58);


            Song s59 = new Song()
            {
                SongName = "Champagne Shots",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Saint").ArtistID            };

            s59.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Local Mvp"));
            s59.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s59.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s59.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));
            s59.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s59);


            Song s60 = new Song()
            {
                SongName = "GOSSIP",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Killloane").ArtistID            };

            s60.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "GOSSIP"));
            s60.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s60);


            Song s61 = new Song()
            {
                SongName = "Wahala",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Naira Marley").ArtistID            };

            s61.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wahala"));
            s61.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s61.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s61.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s61);


            Song s62 = new Song()
            {
                SongName = "Born Wit It (Bumpa Riddim)",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alison Hinds").ArtistID            };

            s62.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Born Wit It (Bumpa Riddim)"));
            s62.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s62.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s62);


            Song s63 = new Song()
            {
                SongName = "Soca Soca",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "MC Mazzie").ArtistID            };

            s63.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Soca Soca"));
            s63.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s63.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s63.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s63);


            Song s64 = new Song()
            {
                SongName = "Magician (feat. J Milla & Yung L)",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Ice Prince").ArtistID            };

            s64.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Everybody Loves Ice Prince"));
            s64.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s64);


            Song s65 = new Song()
            {
                SongName = "Caesar",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Inventor Ace").ArtistID            };

            s65.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Caesar"));
            s65.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s65.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s65.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s65);


            Song s66 = new Song()
            {
                SongName = "Mr. Fete",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Machel Montano").ArtistID            };

            s66.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Double M, Vol. 1"));
            s66.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s66.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s66.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s66.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s66);


            Song s67 = new Song()
            {
                SongName = "Shorty",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jerry Di").ArtistID            };

            s67.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Shorty"));
            s67.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s67.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s67.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s67.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s67);


            Song s68 = new Song()
            {
                SongName = "Talibans II",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Burna Boy").ArtistID            };

            s68.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Talibans II"));
            s68.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s68.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s68);


            Song s69 = new Song()
            {
                SongName = "Chaque matin",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Key Largo").ArtistID            };

            s69.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Chaque matin"));
            s69.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s69.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s69.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s69);


            Song s70 = new Song()
            {
                SongName = "TESLA BOY (feat. Blaqbonez)",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "ODUMODUBLVCK").ArtistID            };

            s70.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "EZIOKWU"));
            s70.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s70.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s70);


            Song s71 = new Song()
            {
                SongName = "projection",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "love_eight").ArtistID            };

            s71.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "projection"));
            s71.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s71);


            Song s72 = new Song()
            {
                SongName = "CIEL",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "HOUDI").ArtistID            };

            s72.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "LA FOLIE DES GRANDEURS"));
            s72.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Chaque matin"));
            s72.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s72.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s72);


            Song s73 = new Song()
            {
                SongName = "Chama o Coveiro",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Mc Delux").ArtistID            };

            s73.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Chama o Coveiro"));
            s73.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s73);


            Song s74 = new Song()
            {
                SongName = "Talk Show",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Humble Francis").ArtistID            };

            s74.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Talk Show"));
            s74.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s74.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s74);


            Song s75 = new Song()
            {
                SongName = "Merco Benz",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Key Largo").ArtistID            };

            s75.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "July Key"));
            s75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s75.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s75);


            Song s76 = new Song()
            {
                SongName = "Buga (Lo Lo Lo)",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kizz Daniel").ArtistID            };

            s76.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Buga (Lo Lo Lo)"));
            s76.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s76.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s76.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s76.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s76);


            Song s77 = new Song()
            {
                SongName = "Nunca Estoy",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "C. Tangana").ArtistID            };

            s77.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Nunca Estoy"));
            s77.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Un Verano Sin Ti"));
            s77.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s77.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s77.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s77.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s77);


            Song s78 = new Song()
            {
                SongName = "Rocking",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zinoleesky").ArtistID            };

            s78.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Grit & Lust"));
            s78.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s78);


            Song s79 = new Song()
            {
                SongName = "DJ",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Diam's").ArtistID            };

            s79.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Brut de femme"));
            s79.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s79.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s79.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s79.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s79.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s79);


            Song s80 = new Song()
            {
                SongName = "Iko Iko",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "The Dixie Cups").ArtistID            };

            s80.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "The Very Best of The Dixie Cups: Chapel of Love"));
            s80.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s80.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));
            s80.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s80.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s80);


            Song s81 = new Song()
            {
                SongName = "Hey Hou",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "DJ Guih Da ZO").ArtistID            };

            s81.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Hey Hou"));
            s81.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Un Verano Sin Ti"));
            s81.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s81);


            Song s82 = new Song()
            {
                SongName = "El Hijo De Tuta",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "La Chanchona De Tito Mira").ArtistID            };

            s82.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "La Cumbia De Carmelo"));
            s82.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s82.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s82);


            Song s83 = new Song()
            {
                SongName = "Holiday",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Problem Child").ArtistID            };

            s83.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Holiday"));
            s83.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Que Se Cuide"));
            s83.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s83.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s83.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s83);


            Song s84 = new Song()
            {
                SongName = "REI DO BRASIL",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Seek").ArtistID            };

            s84.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "REI DO BRASIL"));
            s84.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s84.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s84);


            Song s85 = new Song()
            {
                SongName = "Body",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Naira Marley").ArtistID            };

            s85.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Body"));
            s85.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "One of Wun"));
            s85.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s85.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s85);


            Song s86 = new Song()
            {
                SongName = "Mandela",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Mr Eazi").ArtistID            };

            s86.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "The Evil Genius"));
            s86.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s86.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s86);


            Song s87 = new Song()
            {
                SongName = "Do not forget",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Perry Goldfish").ArtistID            };

            s87.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Do not forget"));
            s87.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Tchikita"));
            s87.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s87.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s87);


            Song s88 = new Song()
            {
                SongName = "Jingle Bell",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "MC Teteu").ArtistID            };

            s88.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Jingle Bell"));
            s88.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s88.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s88.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s88.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s88);


            Song s89 = new Song()
            {
                SongName = "Khuphuka",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Royal MusiQ").ArtistID            };

            s89.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Khuphuka"));
            s89.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s89.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s89.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s89.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s89);


            Song s90 = new Song()
            {
                SongName = "Static",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "2JtheRichest").ArtistID            };

            s90.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Static"));
            s90.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s90);


            Song s91 = new Song()
            {
                SongName = "Milki",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Akapellah").ArtistID            };

            s91.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Milki"));
            s91.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s91.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s91.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s91);


            Song s92 = new Song()
            {
                SongName = "Colours",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kid AlpHa").ArtistID            };

            s92.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Colours"));
            s92.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s92.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Quest for Coin II"));
            s92.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s92);


            Song s93 = new Song()
            {
                SongName = "DIABLITA (feat. YOVNGCHIMI)",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Myke Towers").ArtistID            };

            s93.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "LA PANTERA NEGRA"));
            s93.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s93);


            Song s94 = new Song()
            {
                SongName = "Bar Breeze",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Hammocks & Lime").ArtistID            };

            s94.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bar Breeze"));
            s94.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s94.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s94);


            Song s95 = new Song()
            {
                SongName = "Jinja",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Olamide").ArtistID            };

            s95.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unruly"));
            s95.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s95);


            Song s96 = new Song()
            {
                SongName = "Quest For Coin II",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Ezra Collective").ArtistID            };

            s96.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Quest for Coin II"));
            s96.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s96.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s96);


            Song s97 = new Song()
            {
                SongName = "Mood (feat. BNXN)",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Wizkid").ArtistID            };

            s97.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Made In Lagos: Deluxe Edition"));
            s97.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s97.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s97);


            Song s98 = new Song()
            {
                SongName = "Shifting Sands",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "G:sson").ArtistID            };

            s98.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Shifting Sands"));
            s98.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Split Decision"));
            s98.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s98);


            Song s99 = new Song()
            {
                SongName = "Beam Me Up",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Adam Space").ArtistID            };

            s99.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Beam Me Up"));
            s99.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s99);


            Song s100 = new Song()
            {
                SongName = "Call of Duty",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zinoleesky").ArtistID            };

            s100.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Grit & Lust"));
            s100.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Everybody Loves Ice Prince"));
            s100.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s100);


            Song s101 = new Song()
            {
                SongName = "Childhood Fragments",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "LoFi Waiter").ArtistID            };

            s101.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Time Fragments"));
            s101.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s101);


            Song s102 = new Song()
            {
                SongName = "Streatham",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dave").ArtistID            };

            s102.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "PSYCHODRAMA"));
            s102.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s102.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s102);


            Song s103 = new Song()
            {
                SongName = "glow",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "low&slow").ArtistID            };

            s103.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "glow"));
            s103.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Double M, Vol. 1"));
            s103.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s103.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s103.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s103);


            Song s104 = new Song()
            {
                SongName = "spring is coming",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "jaackson").ArtistID            };

            s104.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "spring is coming"));
            s104.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s104.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s104);


            Song s105 = new Song()
            {
                SongName = "Tekky",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Chip").ArtistID            };

            s105.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Tekky"));
            s105.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "The Largest"));
            s105.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s105.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s105.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s105);


            Song s106 = new Song()
            {
                SongName = "Integration Drop",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Hacker").ArtistID            };

            s106.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s106.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s106.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s106);


            Song s107 = new Song()
            {
                SongName = "Commit Ballad",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Tester").ArtistID            };

            s107.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s107.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s107.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s107.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s107);


            Song s108 = new Song()
            {
                SongName = "Section Loop",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Ninja").ArtistID            };

            s108.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s108.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s108.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s108.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s108);


            Song s109 = new Song()
            {
                SongName = "Entity Loop",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Model").ArtistID            };

            s109.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s109.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s109.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s109);


            Song s110 = new Song()
            {
                SongName = "Interface Sprint",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Debugger").ArtistID            };

            s110.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s110.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s110.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s110.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));
            s110.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s110);


            Song s111 = new Song()
            {
                SongName = "Index CacheHit",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Coder").ArtistID            };

            s111.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s111.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s111.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s111.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s111);


            Song s112 = new Song()
            {
                SongName = "UnitTest Nugget",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Mapper").ArtistID            };

            s112.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s112.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s112.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s112.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s112.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s112);


            Song s113 = new Song()
            {
                SongName = "PartialView Webhook",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Hacker").ArtistID            };

            s113.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s113.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s113.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s113.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s113);


            Song s114 = new Song()
            {
                SongName = "Partial Release",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Ninja").ArtistID            };

            s114.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s114.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s114.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s114.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s114.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s114.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s114);


            Song s115 = new Song()
            {
                SongName = "Include Hotfix",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Model").ArtistID            };

            s115.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s115.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s115.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s115.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s115.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s115);


            Song s116 = new Song()
            {
                SongName = "Tuple Token",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Tester").ArtistID            };

            s116.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s116.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s116.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s116.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s116.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s116.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s116);


            Song s117 = new Song()
            {
                SongName = "LeftJoin Endpoint",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Builder").ArtistID            };

            s117.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s117.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s117.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s117.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s117);


            Song s118 = new Song()
            {
                SongName = "RightJoin Warmup",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Dev").ArtistID            };

            s118.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s118.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s118.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s118);


            Song s119 = new Song()
            {
                SongName = "Fixture Loop",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Dev").ArtistID            };

            s119.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s119.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s119);


            Song s120 = new Song()
            {
                SongName = "Scaffold Refactor",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Architect").ArtistID            };

            s120.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s120.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s120.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s120.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s120);


            Song s121 = new Song()
            {
                SongName = "Mock Endpoint",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Hacker").ArtistID            };

            s121.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s121.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s121.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s121.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s121);


            Song s122 = new Song()
            {
                SongName = "View Deploy",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Debugger").ArtistID            };

            s122.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s122.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s122.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s122.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s122);


            Song s123 = new Song()
            {
                SongName = "TempData Sprint",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why View").ArtistID            };

            s123.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s123.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s123);


            Song s124 = new Song()
            {
                SongName = "OrderBy Nugget",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee View").ArtistID            };

            s124.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s124.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s124.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s124);


            Song s125 = new Song()
            {
                SongName = "Filter Standup",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gamma Builder").ArtistID            };

            s125.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s125.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s125.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s125.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s125);


            Song s126 = new Song()
            {
                SongName = "REST Beat",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Hacker").ArtistID            };

            s126.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s126.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s126);


            Song s127 = new Song()
            {
                SongName = "Async Anthem",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee Mapper").ArtistID            };

            s127.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s127.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s127.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s127.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s127.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s127);


            Song s128 = new Song()
            {
                SongName = "Select Jam",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Tester").ArtistID            };

            s128.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s128.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s128.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s128.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s128.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s128);


            Song s129 = new Song()
            {
                SongName = "DbContext Uptime",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Architect").ArtistID            };

            s129.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s129.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s129.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s129.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s129);


            Song s130 = new Song()
            {
                SongName = "Lambda Bop",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Coder").ArtistID            };

            s130.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s130.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s130.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s130);


            Song s131 = new Song()
            {
                SongName = "Dependency Groove",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee View").ArtistID            };

            s131.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s131.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s131.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s131.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s131);


            Song s132 = new Song()
            {
                SongName = "ViewData Webhook",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Architect").ArtistID            };

            s132.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s132.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s132.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s132.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s132.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s132.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s132);


            Song s133 = new Song()
            {
                SongName = "REST Bop",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Coder").ArtistID            };

            s133.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s133.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s133);


            Song s134 = new Song()
            {
                SongName = "MVC Suite",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Coder").ArtistID            };

            s134.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s134.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s134.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s134);


            Song s135 = new Song()
            {
                SongName = "Cascade Overload",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Model").ArtistID            };

            s135.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s135.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s135.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s135);


            Song s136 = new Song()
            {
                SongName = "OuterJoin Standup",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee View").ArtistID            };

            s136.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s136.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s136.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s136.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s136);


            Song s137 = new Song()
            {
                SongName = "Async Exception",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay-Tee Hacker").ArtistID            };

            s137.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s137.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s137.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s137);


            Song s138 = new Song()
            {
                SongName = "InnerJoin Beat",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Builder").ArtistID            };

            s138.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s138.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s138.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s138);


            Song s139 = new Song()
            {
                SongName = "ViewBag Breakpoint",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee Dev").ArtistID            };

            s139.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s139.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s139.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s139.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s139);


            Song s140 = new Song()
            {
                SongName = "Include Cipher",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Model").ArtistID            };

            s140.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s140.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s140.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s140);


            Song s141 = new Song()
            {
                SongName = "Seeding Throughput",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Tester").ArtistID            };

            s141.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s141.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s141.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s141.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s141.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s141.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s141);


            Song s142 = new Song()
            {
                SongName = "Delegate Token",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Coder").ArtistID            };

            s142.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s142.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s142);


            Song s143 = new Song()
            {
                SongName = "OuterJoin Beat",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Hacker").ArtistID            };

            s143.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s143.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));
            s143.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s143);


            Song s144 = new Song()
            {
                SongName = "Section Exception",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Hacker").ArtistID            };

            s144.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s144.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s144);


            Song s145 = new Song()
            {
                SongName = "Include Ballad",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Dev").ArtistID            };

            s145.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s145.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s145);


            Song s146 = new Song()
            {
                SongName = "LINQ Backoff",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee View").ArtistID            };

            s146.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s146.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s146.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s146.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s146.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s146);


            Song s147 = new Song()
            {
                SongName = "DbContext Hotfix",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Mapper").ArtistID            };

            s147.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s147.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s147.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s147.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s147);


            Song s148 = new Song()
            {
                SongName = "Integration Groove",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gamma Coder").ArtistID            };

            s148.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s148.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s148);


            Song s149 = new Song()
            {
                SongName = "InnerJoin Hash",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Architect").ArtistID            };

            s149.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s149.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s149.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s149);


            Song s150 = new Song()
            {
                SongName = "Docker Ballad",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em View").ArtistID            };

            s150.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s150.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s150.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s150);


            Song s151 = new Song()
            {
                SongName = "Merge Breakpoint",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gamma Coder").ArtistID            };

            s151.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s151.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s151.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s151.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s151);


            Song s152 = new Song()
            {
                SongName = "Integration Refactor",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Builder").ArtistID            };

            s152.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s152.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s152.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s152.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s152);


            Song s153 = new Song()
            {
                SongName = "Generic Backoff",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Hacker").ArtistID            };

            s153.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s153.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s153);


            Song s154 = new Song()
            {
                SongName = "Fixture Secret",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Ninja").ArtistID            };

            s154.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s154.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s154.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s154.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s154);


            Song s155 = new Song()
            {
                SongName = "Identity Anthem",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Controller").ArtistID            };

            s155.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s155.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s155.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s155.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s155);


            Song s156 = new Song()
            {
                SongName = "Scaffold Miss",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Model").ArtistID            };

            s156.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s156.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s156.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s156);


            Song s157 = new Song()
            {
                SongName = "Entity Nugget",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Mapper").ArtistID            };

            s157.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s157.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s157.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s157.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s157);


            Song s158 = new Song()
            {
                SongName = "JWT Salt",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Dev").ArtistID            };

            s158.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s158.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s158.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s158.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s158.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s158);


            Song s159 = new Song()
            {
                SongName = "Git Breakpoint",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Coder").ArtistID            };

            s159.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s159.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s159.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s159);


            Song s160 = new Song()
            {
                SongName = "Route Wave",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Model").ArtistID            };

            s160.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s160.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s160.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s160);


            Song s161 = new Song()
            {
                SongName = "PrimaryKey Refactor",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Hacker").ArtistID            };

            s161.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s161.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s161);


            Song s162 = new Song()
            {
                SongName = "Rebase Build",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Controller").ArtistID            };

            s162.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s162.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s162.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s162);


            Song s163 = new Song()
            {
                SongName = "Swagger Sprint",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Debugger").ArtistID            };

            s163.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s163.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s163.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s163.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s163.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s163);


            Song s164 = new Song()
            {
                SongName = "Tuple Bop",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gamma Coder").ArtistID            };

            s164.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s164.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s164);


            Song s165 = new Song()
            {
                SongName = "Include CacheHit",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Tester").ArtistID            };

            s165.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s165.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s165.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s165.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s165.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s165);


            Song s166 = new Song()
            {
                SongName = "Dependency Retry",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Debugger").ArtistID            };

            s166.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s166.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s166.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s166);


            Song s167 = new Song()
            {
                SongName = "OAuth Salt",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Architect").ArtistID            };

            s167.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s167.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s167.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s167);


            Song s168 = new Song()
            {
                SongName = "Task Key",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Hacker").ArtistID            };

            s168.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s168.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s168.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s168.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s168);


            Song s169 = new Song()
            {
                SongName = "UnitTest Debugger",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Architect").ArtistID            };

            s169.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s169.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s169.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s169.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s169.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s169);


            Song s170 = new Song()
            {
                SongName = "IQueryable Build",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Architect").ArtistID            };

            s170.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s170.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s170.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s170.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s170);


            Song s171 = new Song()
            {
                SongName = "Generic Demo",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Hacker").ArtistID            };

            s171.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s171.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s171);


            Song s172 = new Song()
            {
                SongName = "JSON Webhook",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee Builder").ArtistID            };

            s172.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s172.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s172);


            Song s173 = new Song()
            {
                SongName = "JWT Breakpoint",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Hacker").ArtistID            };

            s173.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s173.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s173.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s173.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s173);


            Song s174 = new Song()
            {
                SongName = "Abstract Tuning",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Ninja").ArtistID            };

            s174.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s174.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s174.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s174);


            Song s175 = new Song()
            {
                SongName = "Cascade Wave",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gamma Controller").ArtistID            };

            s175.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s175.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s175.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s175);


            Song s176 = new Song()
            {
                SongName = "DbContext Breakpoint",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Tester").ArtistID            };

            s176.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s176.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s176.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s176.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s176.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s176.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s176);


            Song s177 = new Song()
            {
                SongName = "Lambda Overload",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Ninja").ArtistID            };

            s177.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s177.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s177.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s177);


            Song s178 = new Song()
            {
                SongName = "Swagger Bop",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Mapper").ArtistID            };

            s178.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s178.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s178.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s178.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s178);


            Song s179 = new Song()
            {
                SongName = "Abstract Latency",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Mapper").ArtistID            };

            s179.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s179.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s179.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s179);


            Song s180 = new Song()
            {
                SongName = "JSON Cipher",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gamma Model").ArtistID            };

            s180.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s180.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s180.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s180);


            Song s181 = new Song()
            {
                SongName = "Partial Standup",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em View").ArtistID            };

            s181.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s181.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s181.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s181.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s181);


            Song s182 = new Song()
            {
                SongName = "Docker Bop",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee Dev").ArtistID            };

            s182.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s182.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s182.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s182.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s182.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s182.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s182);


            Song s183 = new Song()
            {
                SongName = "Controller Token",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Builder").ArtistID            };

            s183.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s183.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s183.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s183);


            Song s184 = new Song()
            {
                SongName = "Commit Salt",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay-Tee Mapper").ArtistID            };

            s184.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s184.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s184.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s184.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s184);


            Song s185 = new Song()
            {
                SongName = "Merge Backoff",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Builder").ArtistID            };

            s185.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s185.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s185.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s185.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s185);


            Song s186 = new Song()
            {
                SongName = "Rebase Retrospective",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Controller").ArtistID            };

            s186.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s186.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s186.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s186.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s186);


            Song s187 = new Song()
            {
                SongName = "Tuple Uptime",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Coder").ArtistID            };

            s187.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s187.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s187.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s187);


            Song s188 = new Song()
            {
                SongName = "C# Debugger",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Builder").ArtistID            };

            s188.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s188.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s188.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s188);


            Song s189 = new Song()
            {
                SongName = "PrimaryKey Throttling",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Architect").ArtistID            };

            s189.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s189.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s189.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s189.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s189);


            Song s190 = new Song()
            {
                SongName = "Delegate Cipher",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Coder").ArtistID            };

            s190.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s190.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s190);


            Song s191 = new Song()
            {
                SongName = "Fixture Token",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta View").ArtistID            };

            s191.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s191.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s191.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s191);


            Song s192 = new Song()
            {
                SongName = "SQL Anthem",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee Builder").ArtistID            };

            s192.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s192.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s192.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s192);


            Song s193 = new Song()
            {
                SongName = "Razor Timeout",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Builder").ArtistID            };

            s193.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s193.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s193.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s193);


            Song s194 = new Song()
            {
                SongName = "Route Jam",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Controller").ArtistID            };

            s194.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s194.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s194);


            Song s195 = new Song()
            {
                SongName = "ThenInclude Pipeline",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Builder").ArtistID            };

            s195.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s195.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s195.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s195.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s195);


            Song s196 = new Song()
            {
                SongName = "Scaffold Throttling",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Dev").ArtistID            };

            s196.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s196.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s196.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s196.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s196);


            Song s197 = new Song()
            {
                SongName = "Controller Endpoint",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay-Tee Architect").ArtistID            };

            s197.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s197.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s197.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s197.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s197);


            Song s198 = new Song()
            {
                SongName = "Mock Release",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee Hacker").ArtistID            };

            s198.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s198.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s198.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s198.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s198);


            Song s199 = new Song()
            {
                SongName = "Partial Debugger",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Architect").ArtistID            };

            s199.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s199.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s199);


            Song s200 = new Song()
            {
                SongName = "Lambda Token",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Hacker").ArtistID            };

            s200.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s200.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s200.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s200.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s200);


            Song s201 = new Song()
            {
                SongName = "Scaffold Blues",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Coder").ArtistID            };

            s201.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s201.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s201.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s201.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s201);


            Song s202 = new Song()
            {
                SongName = "RazorPage Bop",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Model").ArtistID            };

            s202.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s202.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s202.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s202.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s202.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s202);


            Song s203 = new Song()
            {
                SongName = "REST Demo",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay-Tee View").ArtistID            };

            s203.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s203.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s203.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s203.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s203);


            Song s204 = new Song()
            {
                SongName = "Container Wave",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta View").ArtistID            };

            s204.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s204.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s204.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s204);


            Song s205 = new Song()
            {
                SongName = "Git Hash",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Builder").ArtistID            };

            s205.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s205.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s205.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s205.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s205);


            Song s206 = new Song()
            {
                SongName = "Policy Funk",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Builder").ArtistID            };

            s206.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s206.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s206.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s206.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s206);


            Song s207 = new Song()
            {
                SongName = "Docker Release",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay View").ArtistID            };

            s207.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s207.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s207.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s207);


            Song s208 = new Song()
            {
                SongName = "Lambda Hotfix",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Hacker").ArtistID            };

            s208.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s208.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s208.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s208);


            Song s209 = new Song()
            {
                SongName = "Swagger Salt",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Builder").ArtistID            };

            s209.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s209.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s209);


            Song s210 = new Song()
            {
                SongName = "ThenInclude Exception",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Dev").ArtistID            };

            s210.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s210.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s210.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s210.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s210.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s210);


            Song s211 = new Song()
            {
                SongName = "Cookie Banger",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Coder").ArtistID            };

            s211.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s211.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s211.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s211);


            Song s212 = new Song()
            {
                SongName = "SessionState Funk",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Coder").ArtistID            };

            s212.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s212.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s212.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s212);


            Song s213 = new Song()
            {
                SongName = "Await Suite",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee View").ArtistID            };

            s213.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s213.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s213.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s213.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s213.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s213);


            Song s214 = new Song()
            {
                SongName = "Filter Drop",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Builder").ArtistID            };

            s214.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s214.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s214.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s214);


            Song s215 = new Song()
            {
                SongName = "Bootstrap Wave",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle View").ArtistID            };

            s215.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s215.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s215.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s215.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s215);


            Song s216 = new Song()
            {
                SongName = "Role Secret",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Mapper").ArtistID            };

            s216.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s216.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s216.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s216.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s216);


            Song s217 = new Song()
            {
                SongName = "Index Overload",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Tester").ArtistID            };

            s217.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s217.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s217);


            Song s218 = new Song()
            {
                SongName = "Policy Suite",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Mapper").ArtistID            };

            s218.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s218.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s218);


            Song s219 = new Song()
            {
                SongName = "OAuth Wave",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Model").ArtistID            };

            s219.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s219.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s219);


            Song s220 = new Song()
            {
                SongName = "Bootstrap Remix",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Builder").ArtistID            };

            s220.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s220.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s220.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s220);


            Song s221 = new Song()
            {
                SongName = "Commit Key",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em View").ArtistID            };

            s221.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s221.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s221);


            Song s222 = new Song()
            {
                SongName = "Join Backoff",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay-Tee Dev").ArtistID            };

            s222.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s222.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s222.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s222.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s222);


            Song s223 = new Song()
            {
                SongName = "Fixture Debugger",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Builder").ArtistID            };

            s223.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s223.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s223.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s223.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s223.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s223);


            Song s224 = new Song()
            {
                SongName = "Role Breakpoint",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Ninja").ArtistID            };

            s224.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s224.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s224.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s224);


            Song s225 = new Song()
            {
                SongName = "Dependency Patch",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Mapper").ArtistID            };

            s225.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s225.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s225.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s225.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s225);


            Song s226 = new Song()
            {
                SongName = "Fixture Pipeline",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Dev").ArtistID            };

            s226.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s226.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s226.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s226);


            Song s227 = new Song()
            {
                SongName = "Partial Wave",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Ninja").ArtistID            };

            s227.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s227.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s227.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s227);


            Song s228 = new Song()
            {
                SongName = "Cache Refactor",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Controller").ArtistID            };

            s228.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s228.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s228);


            Song s229 = new Song()
            {
                SongName = "OrderBy Refactor",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Hacker").ArtistID            };

            s229.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s229.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s229.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s229.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s229);


            Song s230 = new Song()
            {
                SongName = "TagHelper Demo",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Model").ArtistID            };

            s230.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s230.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s230);


            Song s231 = new Song()
            {
                SongName = "XML Remix",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Architect").ArtistID            };

            s231.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s231.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s231);


            Song s232 = new Song()
            {
                SongName = "Await CacheHit",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Tester").ArtistID            };

            s232.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s232.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s232.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s232);


            Song s233 = new Song()
            {
                SongName = "GroupBy Drop",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Tester").ArtistID            };

            s233.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s233.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s233.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s233);


            Song s234 = new Song()
            {
                SongName = "Identity Miss",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Debugger").ArtistID            };

            s234.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s234.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s234.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s234);


            Song s235 = new Song()
            {
                SongName = "Delegate Remix",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Hacker").ArtistID            };

            s235.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s235.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s235.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s235.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s235.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s235);


            Song s236 = new Song()
            {
                SongName = "Controller Funk",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Controller").ArtistID            };

            s236.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s236.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s236.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s236.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s236.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s236);


            Song s237 = new Song()
            {
                SongName = "JSON Release",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay-Tee Builder").ArtistID            };

            s237.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s237.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s237);


            Song s238 = new Song()
            {
                SongName = "Push Throttling",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Architect").ArtistID            };

            s238.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s238.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s238.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s238.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s238);


            Song s239 = new Song()
            {
                SongName = "XML CacheHit",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Debugger").ArtistID            };

            s239.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s239.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s239.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s239.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s239.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s239);


            Song s240 = new Song()
            {
                SongName = "Dependency Overload",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Builder").ArtistID            };

            s240.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s240.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s240.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s240.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s240);


            Song s241 = new Song()
            {
                SongName = "ThenInclude Deploy",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Builder").ArtistID            };

            s241.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s241.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));
            s241.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s241.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s241);


            Song s242 = new Song()
            {
                SongName = "GroupBy Timeout",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Coder").ArtistID            };

            s242.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s242.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s242.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s242);


            Song s243 = new Song()
            {
                SongName = "Commit Warmup",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Ninja").ArtistID            };

            s243.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s243.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s243.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s243.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s243);


            Song s244 = new Song()
            {
                SongName = "Mock Secret",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee View").ArtistID            };

            s244.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s244.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s244.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s244.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s244.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s244);


            Song s245 = new Song()
            {
                SongName = "Git Debugger",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Model").ArtistID            };

            s245.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s245.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s245.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s245.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s245);


            Song s246 = new Song()
            {
                SongName = "Select Remix",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Model").ArtistID            };

            s246.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s246.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s246.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s246);


            Song s247 = new Song()
            {
                SongName = "View Bop",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Mapper").ArtistID            };

            s247.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s247.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s247.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s247.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s247);


            Song s248 = new Song()
            {
                SongName = "Route Retry",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Debugger").ArtistID            };

            s248.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s248.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));
            s248.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s248.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s248);


            Song s249 = new Song()
            {
                SongName = "Filter Overload",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Controller").ArtistID            };

            s249.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s249.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s249.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));
            s249.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s249.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s249);


            Song s250 = new Song()
            {
                SongName = "Fixture Nugget",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Tester").ArtistID            };

            s250.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s250.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s250.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));
            s250.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s250.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s250);


            Song s251 = new Song()
            {
                SongName = "Claim Timeout",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Debugger").ArtistID            };

            s251.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s251.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s251.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s251.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s251);


            Song s252 = new Song()
            {
                SongName = "Container Blues",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee View").ArtistID            };

            s252.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s252.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s252.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s252);


            Song s253 = new Song()
            {
                SongName = "TempData Salt",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Tester").ArtistID            };

            s253.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s253.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s253.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));

            Songs.Add(s253);


            Song s254 = new Song()
            {
                SongName = "Where Backoff",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Controller").ArtistID            };

            s254.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s254.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s254);


            Song s255 = new Song()
            {
                SongName = "Session Pipeline",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Debugger").ArtistID            };

            s255.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s255.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s255.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s255);


            Song s256 = new Song()
            {
                SongName = "Validation Loop",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee Tester").ArtistID            };

            s256.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s256.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s256.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s256);


            Song s257 = new Song()
            {
                SongName = "Claim Ballad",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Mapper").ArtistID            };

            s257.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s257.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s257.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s257.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s257.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s257);


            Song s258 = new Song()
            {
                SongName = "Cascade Ballad",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Model").ArtistID            };

            s258.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s258.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));

            Songs.Add(s258);


            Song s259 = new Song()
            {
                SongName = "Cache Handshake",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gamma Dev").ArtistID            };

            s259.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s259.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s259);


            Song s260 = new Song()
            {
                SongName = "Container Timeout",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha Coder").ArtistID            };

            s260.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s260.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s260.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s260);


            Song s261 = new Song()
            {
                SongName = "Session Exception",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Mapper").ArtistID            };

            s261.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s261.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s261.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));
            s261.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s261.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s261);


            Song s262 = new Song()
            {
                SongName = "Async Sprint",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Coder").ArtistID            };

            s262.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s262.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s262.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s262.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));

            Songs.Add(s262);


            Song s263 = new Song()
            {
                SongName = "RazorPage Hotfix",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Debugger").ArtistID            };

            s263.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s263.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s263.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s263.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s263);


            Song s264 = new Song()
            {
                SongName = "LeftJoin Beat",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Mapper").ArtistID            };

            s264.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s264.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "electronic"));

            Songs.Add(s264);


            Song s265 = new Song()
            {
                SongName = "Partial Jam",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Architect").ArtistID            };

            s265.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s265.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s265.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s265.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s265);


            Song s266 = new Song()
            {
                SongName = "Async Wave",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Builder").ArtistID            };

            s266.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s266.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s266.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s266.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s266.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s266);


            Song s267 = new Song()
            {
                SongName = "Interface Throughput",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Gamma Debugger").ArtistID            };

            s267.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s267.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s267.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s267.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s267);


            Song s268 = new Song()
            {
                SongName = "SessionState Uptime",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why Coder").ArtistID            };

            s268.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s268.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s268.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s268.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));
            s268.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));

            Songs.Add(s268);


            Song s269 = new Song()
            {
                SongName = "Layout Pipeline",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Zee Model").ArtistID            };

            s269.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s269.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s269.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "latin"));
            s269.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));
            s269.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s269);


            Song s270 = new Song()
            {
                SongName = "Session Flow",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Tester").ArtistID            };

            s270.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s270.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s270.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));
            s270.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s270);


            Song s271 = new Song()
            {
                SongName = "Policy Loop",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Tester").ArtistID            };

            s271.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s271.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s271.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s271);


            Song s272 = new Song()
            {
                SongName = "RightJoin Remix",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Model").ArtistID            };

            s272.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s272.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s272);


            Song s273 = new Song()
            {
                SongName = "Container Secret",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Pro Coder").ArtistID            };

            s273.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s273.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s273.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s273);


            Song s274 = new Song()
            {
                SongName = "Rebase Ballad",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Why View").ArtistID            };

            s274.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s274.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s274.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s274.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s274.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s274);


            Song s275 = new Song()
            {
                SongName = "Integration Warmup",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Dee Coder").ArtistID            };

            s275.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s275.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s275.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s275);


            Song s276 = new Song()
            {
                SongName = "Task Refactor",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta Architect").ArtistID            };

            s276.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s276.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s276.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s276);


            Song s277 = new Song()
            {
                SongName = "Middleware Demo",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Controller").ArtistID            };

            s277.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s277.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s277.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "afrobeats"));
            s277.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s277);


            Song s278 = new Song()
            {
                SongName = "Query Deploy",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Model").ArtistID            };

            s278.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s278.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s278);


            Song s279 = new Song()
            {
                SongName = "UnitTest Tuning",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are Mapper").ArtistID            };

            s279.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s279.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s279.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Final Release"));
            s279.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s279.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));
            s279.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "soca"));

            Songs.Add(s279);


            Song s280 = new Song()
            {
                SongName = "ForeignKey Throughput",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Tee Debugger").ArtistID            };

            s280.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s280.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s280.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s280.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "lofi"));
            s280.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s280);


            Song s281 = new Song()
            {
                SongName = "Pull Anthem",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Tester").ArtistID            };

            s281.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s281.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "arabic"));

            Songs.Add(s281);


            Song s282 = new Song()
            {
                SongName = "OpenID Blues",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Builder").ArtistID            };

            s282.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s282.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s282.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s282);


            Song s283 = new Song()
            {
                SongName = "Model Cipher",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Coder").ArtistID            };

            s283.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Diagram Dreams"));
            s283.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s283);


            Song s284 = new Song()
            {
                SongName = "Container Uptime",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Em Hacker").ArtistID            };

            s284.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Refactor Rhapsody"));
            s284.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s284.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));
            s284.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s284);


            Song s285 = new Song()
            {
                SongName = "Abstract Sprint",
                Price = 1.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay-Tee Controller").ArtistID            };

            s285.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s285.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "world"));

            Songs.Add(s285);


            Song s286 = new Song()
            {
                SongName = "InnerJoin Jam",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee View").ArtistID            };

            s286.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s286.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s286);


            Song s287 = new Song()
            {
                SongName = "Interface Throttling",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Mapper").ArtistID            };

            s287.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s287.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s287.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));

            Songs.Add(s287);


            Song s288 = new Song()
            {
                SongName = "Layout Nonce",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay-Tee Dev").ArtistID            };

            s288.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s288.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s288.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s288.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "classroom"));

            Songs.Add(s288);


            Song s289 = new Song()
            {
                SongName = "Commit Secret",
                Price = 5.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Are View").ArtistID            };

            s289.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s289.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Unit Test Utopia"));
            s289.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "gaming"));
            s289.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "rock"));

            Songs.Add(s289);


            Song s290 = new Song()
            {
                SongName = "REST Patch",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Kay Mapper").ArtistID            };

            s290.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s290.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));
            s290.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s290);


            Song s291 = new Song()
            {
                SongName = "C# Patch",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Elle Architect").ArtistID            };

            s291.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Sprint 1"));
            s291.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Wireframe Weekend"));
            s291.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "pop"));
            s291.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "brazilian"));

            Songs.Add(s291);


            Song s292 = new Song()
            {
                SongName = "ViewData Warmup",
                Price = 3.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Jay Model").ArtistID            };

            s292.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s292.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s292.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "hip-hop"));

            Songs.Add(s292);


            Song s293 = new Song()
            {
                SongName = "SessionState Exception",
                Price = 4.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Alpha View").ArtistID            };

            s293.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "TA Sessions"));
            s293.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "ambient"));

            Songs.Add(s293);


            Song s294 = new Song()
            {
                SongName = "Interface Key",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Bee Builder").ArtistID            };

            s294.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Office Hours"));
            s294.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Midterm Mix"));
            s294.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "r&b"));

            Songs.Add(s294);


            Song s295 = new Song()
            {
                SongName = "Delegate Throughput",
                Price = 2.00m,
                AvgRating = 0.00m,
                Status = true,
                ArtistID = db.Artists.FirstOrDefault(a => a.ArtistName == "Beta View").ArtistID            };

            s295.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Code Freeze"));
            s295.Albums.Add(db.Albums.FirstOrDefault(a => a.AlbumName == "Bug Bash"));
            s295.Genres.Add(db.Genres.FirstOrDefault(g => g.GenreName == "reggae"));

            Songs.Add(s295);


            try
            {
                foreach (Song songToAdd in Songs)
                {
                    strSongName = songToAdd.SongName;

                    Song dbSong = db.Songs
                        .Include(s => s.Artist)
                        .Include(s => s.Albums)
                        .Include(s => s.Genres)
                        .FirstOrDefault(s => s.SongName == songToAdd.SongName);

                    if (dbSong == null)
                    {
                        db.Songs.Add(songToAdd);
                    }
                    else
                    {
                        dbSong.SongName = songToAdd.SongName;
                        dbSong.Price = songToAdd.Price;
                        dbSong.AvgRating = songToAdd.AvgRating;
                        dbSong.Status = songToAdd.Status;
                        dbSong.ArtistID = songToAdd.ArtistID;

                        dbSong.Albums.Clear();
                        foreach (Album album in songToAdd.Albums)
                        {
                            dbSong.Albums.Add(album);
                        }

                        dbSong.Genres.Clear();
                        foreach (Genre genre in songToAdd.Genres)
                        {
                            dbSong.Genres.Add(genre);
                        }

                        db.Update(dbSong);
                    }

                    db.SaveChanges();
                    intSongsAdded += 1;
                }
            }
            catch (Exception ex)
            {
                String msg = "Songs Added: " + intSongsAdded +
                             "; Error on Song: " + strSongName;

                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}
