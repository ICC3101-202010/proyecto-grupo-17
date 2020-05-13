using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Song : Media
    {
        //Dictionary<string, SongMetadata> Metadata = new Dictionary<string, SongMetadata>();
        private SongMetadata s1;

        public Song(Dictionary<string, List<string>> Information, SongMetadata metadata) : base(Information)
        {
            metadata = s1;
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
