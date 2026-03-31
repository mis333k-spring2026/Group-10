using System;
using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class OrderDetail
    {
        [Key]
        public Int32 OrderDetailID { get; set; }

        [Required]
        [Display(Name = "Price")]
        public Decimal Price { get; set; }

        // required parent order
        [Required]
        public Int32 OrderID { get; set; }
        public Order Order { get; set; }

        // optional: this line item may be a song
        public Int32? SongID { get; set; }
        public Song? Song { get; set; }

        // optional: or this line item may be an album
        public Int32? AlbumID { get; set; }
        public Album? Album { get; set; }
    }
}