using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Song : Media
    {
        
        private SongMetadata MetaData;

        public Song(string fileName) : base(fileName)
        {
            SongMetadata metadata = new SongMetadata();
            MetaData = metadata;
        }

       
        public override Metadata GetMetadata()
        {
            return MetaData;
        }
    }
}
