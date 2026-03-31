using System.Collections.Generic;
using Team10FinalProject.Models;

namespace Team10FinalProject.ViewModels
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