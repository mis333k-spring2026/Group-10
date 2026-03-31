using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Team10FinalProject.ViewModels
{
    public class PromotionViewModel
    {
        public int? PromotionID { get; set; }

        [Required]
        [Display(Name = "Promotion Type")]
        public string PromotionType { get; set; }

        [Display(Name = "Discount Amount")]
        [Range(0.01, 1000.00, ErrorMessage = "Discount amount must be greater than 0.")]
        public decimal? DiscountAmount { get; set; }

        [Display(Name = "Promotion Active")]
        public bool PromotionStatus { get; set; } = true;

        [Display(Name = "Song")]
        public int? SongID { get; set; }

        public SelectList? AllSongs { get; set; }

        [Display(Name = "Album")]
        public int? AlbumID { get; set; }

        public SelectList? AllAlbums { get; set; }

        [Display(Name = "Artist")]
        public int? ArtistID { get; set; }

        public SelectList? AllArtists { get; set; }
    }
}