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
            Console.WriteLine("song name/artist/album/film name/film director");
            string searchObject = Console.ReadLine();
            List<Media> SearchResults = new List<Media>();

        }

        public void Filter(string a)
        {
            if (a == "song name")
            {
                MediaDB
            }
        }

    }
}
