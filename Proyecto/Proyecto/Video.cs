using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Video : Media
    {

        private List<string> comments = new List<string>();
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


        void Add_image()
        {
            return;
        }

    }
}
