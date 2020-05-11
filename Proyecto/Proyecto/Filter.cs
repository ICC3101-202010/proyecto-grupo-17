using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Filter
    {
        public Filter()
        {
        }

        public void filter(string a)
        {
            
        }



        public List<Object> Search(string a)
        {
            List<object> SearchResults = new List<object>();

            List<Song> SFSongs = Spotflix.GetSongDB;
            List<Song> SongResults = new List<Song>();

            foreach(Song s in SFSongs)
            {
                List<string> Options = new List<string>();
                string o1 = s.GetMetadata.Name;
                string o2 = s.GetMetadata.Artist1.Name;
                string o3 = s.GetMetadata.Album;
                string o4 = s.GetMetadata.Gender;

                Options.Add(o1);
                Options.Add(o2);
                Options.Add(o3);
                Options.Add(o4);

                foreach (string i in Options)
                {
                    if (i == a)
                    {
                        SongResults.Add(s);
                    }
                }
            }

            SearchResults.Add(SongResults);


            List<Video> SFVideos = Spotflix.GetVideoDB;
            List<Video> VidResults = new List<Video>();

            foreach(Video v in SFVideos)
            {
                List<string> Options2 = new List<string>();

                string o1 = v.GetMetadata.Name;
                string o2 = v.GetMetadata.Creator;
                string o3 = v.GetMetadata.Gender;
                string o4 = v.GetMetadata.Category;
                string o5 = v.GetMetadata.Studio;

                Options2.Add(o1);
                Options2.Add(o2);
                Options2.Add(o3);
                Options2.Add(o4);
                Options2.Add(o5);

                foreach (string i in Options2)
                {
                    if (i == a)
                    {
                        VidResults.Add(v);
                    }
                }

            }

            SearchResults.Add(VidResults);

            return SearchResults;
        }

    }

}

    /*Console.WriteLine("What are you looking for?");
            Console.WriteLine("a) A song");
            Console.WriteLine("b) A film");
            Console.WriteLine("c) Both");
            Console.WriteLine("Type A, B or C");
            string ans = Console.ReadLine();


            if (ans == "A" || ans == "a")
            {
                Console.WriteLine("What song element are you looking for?");
                Console.WriteLine("a) Name");
                Console.WriteLine("b) Artist");
                Console.WriteLine("c) Album");
                ans = Console.ReadLine();

                List<Song> searchRes = new List<Song>();

                if (ans == "A" || ans == "a")
                {
                    Console.WriteLine("Type the name of the song");
                    string SongName = Console.ReadLine();

                    List<Song> SFSongs = Spotflix.GetSongDB;

                    foreach (Song s in SFSongs)
                    {
                        SongMetadata SMD = s.GetMetadata;
                        string n1 = SMD.Name;

                        if (n1 == SongName)
                        {
                            searchRes.Add(s);
                        }
                    }
                }

                else if (ans == "B" || ans == "b")
                {
                    Console.WriteLine("Type the name of the song artist");
                    string ArtistName = Console.ReadLine();

                    List<Song> SFSongs = Spotflix.GetSongDB;

                    foreach (Song s in SFSongs)
                    {
                        SongMetadata SMD = s.GetMetadata;
                        string n1 = SMD.Artist1.Name;

                        if (n1 == ArtistName)
                        {
                            searchRes.Add(s);
                        }
                    }
                }

                else if (ans == "C" || ans == "c")
                {
                    Console.WriteLine("Type the name of the album");
                    string AlbumName = Console.ReadLine();

                    List<Song> SFSongs = Spotflix.GetSongDB;

                    foreach (Song s in SFSongs)
                    {
                        SongMetadata SMD = s.GetMetadata;
                        string n1 = SMD.Album;

                        if (n1 == AlbumName)
                        {
                            searchRes.Add(s);
                        }
                    }
                }


                else
                {
                    Console.WriteLine("Invalid answer");
                }


                int results = searchRes.Count;
                if (results == 0)
                {
                    Console.WriteLine("No results found!");
                }

                else
                {
                    Console.WriteLine(searchRes);
                }


            }


            else if (ans == "B" || ans == "b")
            {
                Console.WriteLine("What film element are you looking for?");
                Console.WriteLine("a) Name");
                Console.WriteLine("b) Director");
                Console.WriteLine("Type A or B");
                ans = Console.ReadLine();

                if (ans == "A" || ans == "a")
                {
                    Console.WriteLine("Type the name of the video");
                    string vidName = Console.ReadLine();

                    List<Video> SDB = Spotflix.GetVideoDB;
                    SDB.
                }
            }


            else
            {
                Console.WriteLine("Invalid answer");
            }


            Console.WriteLine("a) Song name/artist/album/film name/film director");
            Console.WriteLine("b) Artist");
            Console.WriteLine("c) Album");
            Console.WriteLine("d) ");

            string searchObject = Console.ReadLine();
            List<Media> SearchResults = new List<Media>();

        }
        */
