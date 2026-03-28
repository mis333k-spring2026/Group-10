using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team_10_Final_Project.Models
{
    public class Genre
    {
        [Key]
        public Int32 GenreID { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public String GenreName { get; set; }

        //navigation properties
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Album> Albums { get; set; } = new List<Album>();
        public List<Artist> Artists { get; set; } = new List<Artist>();

        
    }
}