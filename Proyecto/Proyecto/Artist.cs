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

        public Artist(string name) : base(name)
        {
            Name = name;
            List<Album> albums = new List<Album>();
            List<Song> songs = new List<Song>();
            List<User> followers = new List<User>();

            Albums = albums;
            Songs = songs;
            Followers = followers;

        }

        public List<Song> GetSongs()
        {
            return Songs;
        }

        public List<User> GetFollowers()
        {
            return Followers;
        }

        public List<Album> GetAlbums()
        {
            return Albums;
        }

        public void AddAlbum(Album album)
        {
            //Event
            Albums.Add(album);
        }

        public void AddSong(Song song)
        {
            //Event
            Songs.Add(song);
        }

        public void AddFollower(User user)
        {
            //Event -> Remove en el mismo metodo?
            Followers.Add(user);
        }
    }
}
