using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Video : Media
    {

        string name;
        string creator;
        double duration;
        string max_quality;
        List<string> comments = new List<string>();
        int FPS;
        VideoMetadata Metadata;

        public Video(Dictionary<string, List<string>> Information, VideoMetadata Metadata, int Users_Like, double Score, int Views, string name, string creator, double duration, string max_quality, List<string> comments, int FPS) : base(Information)
        {
            this.name = name;
            this.creator = creator;
            this.duration = duration;
            this.max_quality = max_quality;
            this.comments = comments;
            this.FPS = FPS;
            this.Metadata = Metadata;
        }

        void Download()
        {

        }

        void Add_metadata()
        {
            Console.WriteLine("What kind of data would you like to add?"); //Se tiene que hacer cuando se crea el objeto
            string new_Metadata = Console.ReadLine();
            
        }

        void Add_info()
        {
            Console.WriteLine("What kind of new info would you like to add?");
        }

        void Add_image()
        {

        }

    }
}
