using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Song : Media
    {
        
        private SongMetadata MetaData;

        public Song(SongMetadata metadata, string fileName) : base(fileName)
        {
            MetaData = metadata;
        }

        public SongMetadata GetMetadata
        {
            get
            {
                return MetaData;
            }
        }
    }
}
