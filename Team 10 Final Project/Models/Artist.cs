using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team10FinalProject.Models
{
    public class Artist
    {
        [Key]
        public Int32 ArtistID { get; set; }

        [Required]
        [Display(Name = "Artist Name")]
        // TODO: Change to public String? ArtistName { get; set; }
        public String ArtistName { get; set; }

        [Required]
[Display(Name = "Rating")]
        public Decimal AvgRating { get; set; } = 0.0m;

        //navigation properties
        //many to many relationship
        public List<Genre> Genres { get; set; } = new List<Genre>();

        //one to many relationship
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Album> Albums { get; set; } = new List<Album>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}