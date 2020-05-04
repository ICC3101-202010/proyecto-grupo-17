using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Artist : Person
    {
        List<Album> albums = new List<Album>();
        List<Song> discography = new List<Song>();

        public Artist(string name, List<string> professions, int age, List<Album> albums, List<Song> discography) : base(name, professions, age)
        {
            this.albums = albums;
            this.discography = discography;
        }
    }
}
