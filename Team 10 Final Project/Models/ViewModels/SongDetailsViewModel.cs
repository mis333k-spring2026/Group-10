using System.Collections.Generic;
using Team10FinalProject.Models;

namespace Team10FinalProject.ViewModels
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