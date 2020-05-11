using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Song : Media
    {
        string artist;
        string album;

        public Song(Dictionary<string, List<string>> Metadata, Dictionary<string, List<string>> Information, string artist, string album) : base(Metadata, Information)
        {
            this.artist = artist;
            this.album = album;
        }
    }
}
