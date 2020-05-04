using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Song : Media
    {
        string artist;
        string album;

        public Song(Dictionary<string, List<string>> Metadata, Dictionary<string, List<string>> Information, int Users_Like, double Score, int Views, string artist, string album) : base(Metadata, Information, Users_Like, Score, Views)
        {
            this.artist = artist;
            this.album = album;
        }
    }
}
