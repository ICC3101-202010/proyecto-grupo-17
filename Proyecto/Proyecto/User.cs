using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Proyecto
{
    [Serializable]
    public class User
    {
        private List<object> UserData;
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
        private bool Admin;

        public User(string name, string email, string password, bool privateAccount, bool premium, bool admin)
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
            Admin = admin;
        }

        public string GetPassword()
        {
            return Password;
        }

        public bool GetAdmin()
        {
            return Admin;
        }

        public string GetUsername()
        {
            return UserName;
        }

        public string GetEmail()
        {
            return Email;
        }

        public bool GetPrivate()
        {
            return PrivateAccount;
        }

        public bool GetPremium()
        {
            return Premium;
        }

        public void MakeAdmin() { Admin = true; }

        public List<Playlist> GetPlaylist()
        {
            return Playlists;
        }

        public List<User> GetFollowers()
        {
            return Followers;
        }

        public List<object> GetFollowing()
        {
            return Following;
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

            Playlist a = new Playlist(name, privateList, UserName);
            Playlists.Add(a);
        }

        public void Follow(object follow)
        {

        }




        public void AddMedia()
        {
            List<string> opts = new List<string>() { "Song", "Video", "Back" };
            string sel = null;
            while (true)
            {
                Console.Clear();
                sel = RegexUtilities.GetMenu(opts);
                if (sel == opts[2]) { return; }

                else if (sel == opts[0])
                {
                    Console.Clear();
                    string fName = RegexUtilities.WriteData("File Name(with extension):  ");
                    Console.Clear();
                    
                    try
                    {
                        Song song = new Song(fName);


                        Spotflix.SaveMedia(song);
                        Console.WriteLine("Win");
                        Thread.Sleep(2000);
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Fail");
                        Thread.Sleep(2000);
                    }
                }

                else if (sel == opts[1])
                {
                    Console.Clear();
                    string fName = RegexUtilities.WriteData("File Name(with extension):  ");
                    Console.Clear();


                    try
                    {
                        
                        Video video = new Video(fName);
                        Spotflix.SaveMedia(video);
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Fail");
                        Thread.Sleep(2000);
                    }

                    //video.Get

                    /*sMeta.GetDirector().AddVideo(video);
                    foreach (Person ppl in sMeta.GetActors())
                    {
                        ppl.AddVideo(video);
                    }*/
                }


            }





        }
    }
}


//string a = "sss.mp4";
//_ = Process.Start(a);
//private Process a = new Process();