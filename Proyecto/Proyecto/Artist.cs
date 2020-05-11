using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Artist : Person
    {
        private List<Album> Albums;
        private List<Song> Songs;
        private string Studio;

        public Artist(string name, List<string> professions, int age, List<Album> albums, List<Song> songs, string studio) : base(name, professions, age)
        {
            Albums = albums;
            Songs = songs;
            Studio = studio;
        }
    }
}
