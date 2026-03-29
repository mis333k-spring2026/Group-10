using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Team_10_Final_Project.ViewModels
{
    public class CreateEditArtistViewModel
    {
        public int? ArtistID { get; set; }

        [Required]
        [Display(Name = "Artist Name")]
        public string ArtistName { get; set; }

        [Display(Name = "Genres")]
        public List<int> SelectedGenreIDs { get; set; } = new List<int>();

        public MultiSelectList? AllGenres { get; set; }
    }
}