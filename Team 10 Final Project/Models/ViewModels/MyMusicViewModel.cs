using System.Collections.Generic;
using Team_10_Final_Project.Models;

namespace Team_10_Final_Project.ViewModels
{
    public class MyMusicViewModel
    {
        public List<Song> Songs { get; set; } = new List<Song>();

        public string? SearchTitle { get; set; }
        public string? SearchArtist { get; set; }
        public string? SearchAlbum { get; set; }
        public List<int> SelectedGenreIDs { get; set; } = new List<int>();
        public string? SortOption { get; set; }
    }
}