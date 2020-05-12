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

        public void AddToQueue(Media nextMedia)
        {
            Queue.Enqueue(nextMedia);
        }

        public void AddToPlaylist(Media media, Playlist plName)
        {
            if (Playlists.Count == 0)
            {
                Console.WriteLine("You have no playlists, to create one go to new playlist.");  //placeholder
            }

            else
            {
                Playlist a = Playlists.Find(x => x.GetName() == plName.GetName());

                if (a.GetList().Contains(media))
                {
                    Console.WriteLine($"Playlist already contains {0}" , media);    //placeholder
                }

                else
                {

                    a.AddMedia(media);
                }
            }
        }

        public void LikeMedia(Media media)
        {
            if (Likes.Contains(media))
            {
                media.AddLike(false);
            }
            else
            {
                media.AddLike(true);
            }
            
        }

        public void NewPlaylist()
        {
            Console.Write("Playlist name: ");
            string name = Console.ReadLine();
            bool privateList = false;
            if (PrivateAccount == true)
            {
                privateList = true;
            }
            else
            {
                Console.WriteLine("Do you want your playlist to be private? y/n");
                int read = Console.Read();
                if (read == 'y')
                {
                    privateList = true;
                }
            }

<<<<<<< HEAD
            //Playlist a = new Playlist(name, privateList, UserName);
=======
            //Playlist a = new Playlist(name, privateList, this.User);
>>>>>>> 01aef45e0c14ac2fee2912a6cad058688d0310fb
            //Playlists.Add(a);
        }

        public void Follow(object follow)
        {

        }

    }
}


//string a = "sss.mp4";
//_ = Process.Start(a);
//private Process a = new Process();