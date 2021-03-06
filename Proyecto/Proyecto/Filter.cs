﻿using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Filter
    {
        public Filter()
        {
        }
        /*
        public List<object> FilteredSearch(List<int> filters, string a)
        {
            List<object> FilteredRes = new List<object>();

            List<Song> SFSongs = Spotflix.GetSongDB;
            List<Song> SongResults = new List<Song>();

            foreach (Song s in SFSongs)
            {
                bool proof = false;
                List<string> Options = new List<string>();


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
                    string o3 = s.GetMetadata.Album.GetName;
                    Options.Add(o3);
                }

                if (filters.Contains(4) == true)
                {
                    string o4 = s.GetMetadata.Genre;
                    Options.Add(o4);
                }

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
                    string o3 = v.GetMetadata.Genre;
                    Options2.Add(o3);
                }

                if (filters.Contains(8) == true)
                {
                    string o4 = v.GetMetadata.Category;
                    Options2.Add(o4);
                }

                if (filters.Contains(9) == true)
                {
                    string o5 = v.GetMetadata.Director.Name;
                    Options2.Add(o5);
                }

                if (filters.Contains(10) == true)
                {
                    string o6 = v.GetMetadata.Studio;
                    Options2.Add(o6);
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






            */
        public List<Media> Search(string key)
        {
            List<Media> SearchResults = new List<Media>();

            List<Media> SF = Spotflix.GetMediaDB;
            
            /*
            foreach(Song s in SF)
            {
                List<string> Options = new List<string>();

                string o1 = s.GetMetadata.Name;
                string o2 = s.GetMetadata.Artist1.Name;
                string o3 = s.GetMetadata.Album.GetName;
                string o4 = s.GetMetadata.Genre;

                string o1 = s.GetMetadata().GetName();
                string o2 = s.GetMetadata().GetArtist().GetName();
                string o3 = s.GetMetadata().GetAlbum().GetName();
                string o4 = s.GetMetadata().GetGenre();

                Options.Add(o1);
                Options.Add(o2);
                Options.Add(o3);
                Options.Add(o4);

                foreach (string i in Options)
                {
                   
                    if (i.Contains(key) == true)
                    {
                        SearchResults.Add(s);
                       
                    }
                    
                }
            }
            */

            foreach(Media v in SF)
            {
                List<string> Options2 = new List<string>();
                string o1, o2, o3, o4, o5, o6, o7, o8;
                o1 = o2 = o3 = o4 = o5 = o6 = o7 = o8 = "";

                try
                {

                    o1 = v.GetMetadata().GetName().ToLower();
                }
                catch { }
                try
                {
                    o2 = v.GetMetadata().GetCreator().ToLower();
                }
                catch { }
                try { o3 = v.GetMetadata().GetGenre().ToLower(); }
                catch { }
                try { o4 = v.GetMetadata().GetCategory().ToLower(); }
                catch { }
                try { o5 = v.GetMetadata().GetDirector().GetName().ToLower(); }
                catch { }
                try { o6 = v.GetMetadata().GetStudio().ToLower(); }
                catch { }
                try { o7 = v.GetMetadata().GetArtist().GetName().ToLower(); }
                catch { }
                try { o8 = v.GetMetadata().GetAlbum().GetName().ToLower(); }
                catch { }

                Options2.Add(o1);
                Options2.Add(o2);
                Options2.Add(o3);
                Options2.Add(o4);
                Options2.Add(o5);
                Options2.Add(o6);
                Options2.Add(o7);
                Options2.Add(o8);
                try
                {
                    foreach (Person actor in v.GetMetadata().GetActors())
                    {
                        Options2.Add(actor.GetName());
                    }
                }
                catch { }
                
                foreach (string i in Options2)
                {
                    bool asd = i.Contains(key.ToLower());
                    if (asd == true)
                    {
                        if (SearchResults.Contains(v) == false)
                        {
                            SearchResults.Add(v);
                        }
                        
                            
                    }
                    
                    
                }

            }
            if (SearchResults.Count == 0)
            {
                Console.WriteLine("Your search has returned no results");
                return SearchResults;
            }
            else
            {
                return SearchResults;
            }
            
        }
        
    }

}
