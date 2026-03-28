using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.Models
{
    public class Artist
    {
        [Key]
        public Int32 ArtistID { get; set; }

        [Required]
        [Display(Name = "Artist Name")]
        public String ArtistName { get; set; }

        //navigation properties
        //many to many relationship
        public List<Genre> Genres { get; set; } = new List<Genre>();

        //one to many relationship
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Album> Albums { get; set; } = new List<Album>();
        
    }
}