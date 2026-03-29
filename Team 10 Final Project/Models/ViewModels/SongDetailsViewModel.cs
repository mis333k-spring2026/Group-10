using System.Collections.Generic;
using Team_10_Final_Project.Models;

namespace Team_10_Final_Project.ViewModels
{
    public class SongDetailsViewModel
    {
        public Song Song { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public Decimal CurrentPrice { get; set; }
        public Decimal? OriginalPrice { get; set; }
        public Boolean IsDiscounted { get; set; }

        public Boolean CanAddToCart { get; set; }
        public Boolean AlreadyInCart { get; set; }

        public Boolean CanReview { get; set; }

        public Decimal AverageRating { get; set; }
    }
}