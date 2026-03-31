using System.Collections.Generic;
using Team10FinalProject.Models;

namespace Team10FinalProject.ViewModels
{
    public class ArtistDetailsViewModel
    {
        public Artist Artist { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public Boolean CanReview { get; set; }

        public Decimal AverageRating { get; set; }
    }
}