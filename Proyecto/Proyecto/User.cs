using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Proyecto
{
    public class User
    {
        private string UserName;
        private string Email;
        private string Password;
        private bool PrivateAccount;   
        private List<User> Followers;
        private List<Object> Following;
        private Queue<Media> Queue;
        private Dictionary<object, List<object>> Favorites;
        private List<object> Likes;
        private bool Premium;
        private List<Playlist> Playlists;

        public string GetPassword()
        {
            return Password;
        }

        public string GetUsername()
        {
            return UserName;
        }

        public string GetEmail()
        {
            return Email;
        }

        public User(string name, string email, string password, bool privateAccount, bool premium)
        {
            UserName = name;
            Email = email;
            Password = password;
            PrivateAccount = privateAccount;
            Dictionary<object, List<object>> favorites = new Dictionary<object, List<object>>();
            List<object> likes = new List<object>();
            Queue<Media> queue = new Queue<Media>();
            List<Playlist> playlists = new List<Playlist>();
            Favorites = favorites;
            Likes = likes;
            Queue = queue;
            Playlists = playlists;
            Premium = premium;
        }

        public void AddToQueue(Media nextMedia)
        {

        }

        public void AddToPlaylist(Media media, Playlist plName)
        {

        }

        public void NewPlaylist(string name)
        {

            bool privateList = false;
            if (PrivateAccount == true)
            {
                privateList = true;
            }
            Console.WriteLine("Do you want your playlist to be private? y/n");
            int read = Console.Read();
            if (read == 'y')
            {
                privateList = true;
            }

            Playlist a = new Playlist(name, privateList);
            Playlists.Add(a);
        }

        public void Follow(object follow)
        {

        }

    }
}


//string a = "sss.mp4";
//_ = Process.Start(a);
//private Process a = new Process();