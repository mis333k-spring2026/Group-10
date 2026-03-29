using System;

namespace Team_10_Final_Project.ViewModels
{
    public class CartItemViewModel
    {
        public Int32? SongID { get; set; }
        public String? SongName { get; set; }

        public Int32? AlbumID { get; set; }
        public String? AlbumName { get; set; }

        public String ArtistName { get; set; }

        public Decimal Price { get; set; }
        public Decimal? OriginalPrice { get; set; }

        public Boolean IsDiscounted { get; set; }
        public Decimal Savings => IsDiscounted && OriginalPrice.HasValue ? OriginalPrice.Value - Price : 0m;
    }
}