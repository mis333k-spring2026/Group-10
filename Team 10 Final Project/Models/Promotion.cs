using System;
using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class Promotion
    {
        [Key]
        public Int32 PromotionID { get; set; }

        [Required]
        [Display(Name = "Promotion Type")]
        public String PromotionType { get; set; }

        [Display(Name = "Discount Amount")]
        public Decimal? DiscountAmount { get; set; }

        public Boolean PromotionStatus { get; set; } = true;

        // optional relationships: promotion applies to ONE of these
        public Int32? SongID { get; set; }
        public Song? Song { get; set; }

        public Int32? AlbumID { get; set; }
        public Album? Album { get; set; }

        public Int32? ArtistID { get; set; }
        public Artist? Artist { get; set; }
    }
}