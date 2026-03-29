using System.Collections.Generic;
using Team_10_Final_Project.Models;

namespace Team_10_Final_Project.ViewModels
{
    public class ArtistDetailsViewModel
    {
        public Artist Artist { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public Boolean CanReview { get; set; }

        public Decimal AverageRating { get; set; }
    }
}