using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Filter
    {
        public Filter()
        {
        }

        public List<object> Filtered_Search(List<int> filters, string a)
        {
            List<object> FilteredRes = new List<object>();


            List<Song> SFSongs = Spotflix.GetSongDB;
            List<Song> SongResults = new List<Song>();

            foreach (Song s in SFSongs)
            {
                bool proof = false;
                List<string> Options = new List<string>();
<<<<<<< Updated upstream

                if (filters.Contains(1) == true)
                {
                    string o1 = s.GetMetadata.Name;
                    Options.Add(o1);
                }

                if (filters.Contains(2) == true)
                {
                    string o2 = s.GetMetadata.Artist1.Name;
                    Options.Add(o2);
                }

                if (filters.Contains(3) == true)
                {
                    string o3 = s.GetMetadata.Album;
                    Options.Add(o3);
                }

                if (filters.Contains(4) == true)
                {
                    string o4 = s.GetMetadata.Gender;
                    Options.Add(o4);
                }
=======
                string o1 = s.GetMetadata.Name;
                string o2 = s.GetMetadata.Artist1.Name;
                string o3 = s.GetMetadata.Album;
                //string o4 = s.GetMetadata.Gender;

                Options.Add(o1);
                Options.Add(o2);
                Options.Add(o3);
                //Options.Add(o4);
>>>>>>> Stashed changes

                foreach (string i in Options)
                {
                    if (proof == false)
                    {
                        if (i == a)
                        {
                            SongResults.Add(s);
                            proof = true;
                        }
                    }
                }
            }

            FilteredRes.Add(SongResults);


            List<Video> SFVideos = Spotflix.GetVideoDB;
            List<Video> VidResults = new List<Video>();

            foreach (Video v in SFVideos)
            {
                bool proof = false;
                List<string> Options2 = new List<string>();

                if (filters.Contains(5) == true)
                {
                    string o1 = v.GetMetadata.Name;
                    Options2.Add(o1);
                }

                if (filters.Contains(6) == true)
                {
                    string o2 = v.GetMetadata.Creator;
                    Options2.Add(o2);
                }

                if (filters.Contains(7) == true)
                {
                    string o3 = v.GetMetadata.Gender;
                    Options2.Add(o3);
                }

                if (filters.Contains(8) == true)
                {
                    string o4 = v.GetMetadata.Category;
                    Options2.Add(o4);
                }

                if (filters.Contains(9) == true)
                {
                    string o5 = v.GetMetadata.Name;
                    Options2.Add(o5);
                }


                foreach (string i in Options2)
                {
                    if (proof == false)
                    {
                        if (i == a)
                        {
                            VidResults.Add(v);
                            proof = true;
                        }
                    }

                }

            }

            FilteredRes.Add(VidResults);

            return FilteredRes;
        }







        public List<object> Search(string a)
        {
            List<object> SearchResults = new List<object>();

            List<Song> SFSongs = Spotflix.GetSongDB;
            List<Song> SongResults = new List<Song>();

            foreach(Song s in SFSongs)
            {
                bool proof = false;
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
                    if (proof == false)
                    {
                        if (i == a)
                        {
                            SongResults.Add(s);
                            proof = true;
                        }
                    }
                }
            }

            SearchResults.Add(SongResults);


            List<Video> SFVideos = Spotflix.GetVideoDB;
            List<Video> VidResults = new List<Video>();

            foreach(Video v in SFVideos)
            {
                bool proof = false;
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
                    if (proof == false)
                    {
                        if (i == a)
                        {
                            VidResults.Add(v);
                            proof = true;
                        }
                    }
                    
                }

            }

            SearchResults.Add(VidResults);

            return SearchResults;
        }

    }

}
