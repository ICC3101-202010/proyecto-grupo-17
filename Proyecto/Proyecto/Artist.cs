using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Artist : Person
    {
        private List<Album> Albums;
        private List<Song> Songs;

        public Artist(string name, List<string> professions, int age, List<Album> albums, List<Song> songs) : base(name, professions, age)
        {
            Albums = albums;
            Songs = songs;
        }
    }
}
