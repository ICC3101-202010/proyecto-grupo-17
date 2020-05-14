using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Song : Media
    {
        //Dictionary<string, SongMetadata> Metadata = new Dictionary<string, SongMetadata>();
        private SongMetadata s1;

        public Song(SongMetadata metadata, string fileName) : base(fileName)
        {
            s1 = metadata;
        }

        public SongMetadata GetMetadata
        {
            get
            {
                return s1;
            }
        }
    }
}
