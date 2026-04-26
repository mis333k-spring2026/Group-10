using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.ViewModels
{
    public class TopSellingBandViewModel
    {
        [Display(Name = "Genre")]
        public string GenreName { get; set; }

        [Display(Name = "Top Artist")]
        public string ArtistName { get; set; }

        [Display(Name = "Song Purchases")]
        public int SongPurchases { get; set; }

        [Display(Name = "Song Revenue")]
        [DataType(DataType.Currency)]
        public decimal SongRevenue { get; set; }

        [Display(Name = "Album Breakdown")]
        public List<AlbumBreakdownViewModel> AlbumBreakdown { get; set; } = new();

        [Display(Name = "Total Album Purchases")]
        public int TotalAlbumPurchases { get; set; }

        [Display(Name = "Total Album Revenue")]
        [DataType(DataType.Currency)]
        public decimal TotalAlbumRevenue { get; set; }

        [Display(Name = "Total Revenue")]
        [DataType(DataType.Currency)]
        public decimal TotalRevenue { get; set; }
    }
}