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
            Console.WriteLine("Type A or B");
            string ans = Console.ReadLine();


            if (ans == "A" || ans == "a")
            {
                Console.WriteLine("What song element are you looking for?");
                Console.WriteLine("a) Name");
                Console.WriteLine("b) Artist");
                Console.WriteLine("c) Album");
            }


            else if (ans == "B" || ans == "b")
            {
                Console.WriteLine("What film element are you looking for?");
                Console.WriteLine("a) Name");
                Console.WriteLine("b) Director");

            }


            Console.WriteLine("a) Song name/artist/album/film name/film director");
            Console.WriteLine("b) Artist");
            Console.WriteLine("c) Album");
            Console.WriteLine("d) ")

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
