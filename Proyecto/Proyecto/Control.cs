using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Control
    {
        public Control()
        {

        }

        public void Search()
        {
            Console.WriteLine("What are you looking for?");
            Console.WriteLine("a) A song");
            Console.WriteLine("b) A film");
            Console.WriteLine("c) Both")
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

                        if (a1 == ArtistName)
                        {
                            searchRes.Add(a1);
                        }
                    }
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

        public void Filter(string a)
        {
            if (a == "song name")
            {
                
            }
        }

    }
}
