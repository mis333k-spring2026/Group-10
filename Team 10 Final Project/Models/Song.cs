using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class Song
    {
        [Key]
        public Int32 SongID { get; set; }

        [Required]
        [Display(Name = "Song Name")]
        // TODO: Change to public String? SongName { get; set; }
        public String SongName   { get; set; }

        [Required]
        [Display(Name = "Price")]
        public Decimal Price { get; set; }

        [Required]
        [Display(Name = "Rating")]
        public Decimal AvgRating { get; set; }

        public Boolean Status { get; set; } = true;

        //navigation properties

        //one to many relationship
        [Required]
        public Int32 ArtistID { get; set; }
        // TODO: Change to public Artist? Artist { get; set; }
        public Artist Artist { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Album> Albums { get; set; } = new List<Album>();
        public List<Review> Reviews { get; set; } = new List<Review>();

        
    }
}