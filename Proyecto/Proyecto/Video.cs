using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Video : Media
    {

        private double duration;
        private string max_quality;
        private List<string> comments = new List<string>();
        private int FPS;
        private VideoMetadata Metadata;

        public Video(string fileName) : base(fileName)
        {
            
            VideoMetadata meta = new VideoMetadata();
            Metadata = meta;
        }

        public VideoMetadata GetMetadata
        {
            get
            {
                return Metadata;
            }
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
