using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Utilities
{
    public static class RatingHelper
    {
        public static async Task UpdateSongRatingAsync(AppDbContext db, int songId)
        {
            var song = await db.Songs
                .Include(s => s.Reviews)
                .FirstOrDefaultAsync(s => s.SongID == songId);

            if (song == null) return;

            var approvedRatings = song.Reviews
                .Where(r => r.IsApproved == true)
                .Select(r => r.Rating)
                .ToList();

            song.AvgRating = approvedRatings.Any()
                ? Math.Round((decimal)approvedRatings.Average(), 1)
                : 0m;

            await db.SaveChangesAsync();
        }

        public static async Task UpdateAlbumRatingAsync(AppDbContext db, int albumId)
        {
            var album = await db.Albums
                .Include(a => a.Reviews)
                .FirstOrDefaultAsync(a => a.AlbumID == albumId);

            if (album == null) return;

            var approvedRatings = album.Reviews
                .Where(r => r.IsApproved == true)
                .Select(r => r.Rating)
                .ToList();

            album.AvgRating = approvedRatings.Any()
                ? Math.Round((decimal)approvedRatings.Average(), 1)
                : 0m;

            await db.SaveChangesAsync();
        }

        public static async Task UpdateArtistRatingAsync(AppDbContext db, int artistId)
        {
            var artist = await db.Artists
                .Include(a => a.Reviews)
                .FirstOrDefaultAsync(a => a.ArtistID == artistId);

            if (artist == null) return;

            var approvedRatings = artist.Reviews
                .Where(r => r.IsApproved == true)
                .Select(r => r.Rating)
                .ToList();

            artist.AvgRating = approvedRatings.Any()
                ? Math.Round((decimal)approvedRatings.Average(), 1)
                : 0m;

            await db.SaveChangesAsync();
        }

        public static async Task UpdateRatingForReviewAsync(AppDbContext db, Review review)
        {
            if (review.SongID.HasValue)
                await UpdateSongRatingAsync(db, review.SongID.Value);
            else if (review.AlbumID.HasValue)
                await UpdateAlbumRatingAsync(db, review.AlbumID.Value);
            else if (review.ArtistID.HasValue)
                await UpdateArtistRatingAsync(db, review.ArtistID.Value);
        }
    }

}
