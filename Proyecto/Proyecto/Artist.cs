using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Artist : Person
    {
        private List<Album> Albums;
        private List<Song> Songs;
        private List<User> Followers;
        private string Studio;

        public Artist(string name, List<string> professions, int age, List<Album> albums, List<Song> songs, List<User> followers, string studio) : base(name, professions, age)
        {
            Albums = albums;
            Songs = songs;
            Followers = followers;
            Studio = studio;
        }
    }
}
