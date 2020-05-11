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
            List<object> FilterList = new List<object>();

            if (a == "Song" || a == "song")
            {
                string
                a1 = SongMetadata.Name;
            }
        }



        public void Search(string a)
        {
            List<Song> SFSongs = Spotflix.GetSongDB;

            foreach(Song s in SFSongs)
            {

            }


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
        public void Search()
        {

        }
    }
}
