using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Video : Media
    {

        private List<string> comments = new List<string>();
        private VideoMetadata MetaData;

        public Video(string fileName) : base(fileName)
        {
            
            VideoMetadata meta = new VideoMetadata();
            MetaData = meta;
        }

        public override Metadata GetMetadata()
        { 
            return MetaData;
            
        }


        void Add_image()
        {
            return;
        }

    }
}
