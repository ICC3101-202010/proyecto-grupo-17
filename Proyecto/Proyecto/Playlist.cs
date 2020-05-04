using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Playlist
    {
        public string name;
        bool privacy;
        List<Media> PList;

        public Playlist(string name, bool privacy, List<Media> PList)
        {
            this.name = name;
            this.privacy = privacy;
            this.PList = PList;
        }



    }
}
