using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.Models
{
    public class Album
    {
        [Key]
        public Int32 AlbumID { get; set; }

        [Required]
        [Display(Name = "Album Name")]
        public String AlbumName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public Decimal Price { get; set; }

        [Display(Name = "Album Cover")]
        public String AlbumCover { get; set; }

        public Boolean Status { get; set; } = true;

        //navigation properties
        //one to many relationship
        [Required]
        public Int32 ArtistID { get; set; }
        public Artist Artist { get; set; } 

        //many to many relationship
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Song> Songs { get; set; } = new List<Song>();
        
    }
}