using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Playlist
    {
        private string Name;
        private bool PrivateList;
        private List<Media> PList;

        public Playlist(string name, bool privateList)
        {

            Name = name;
            List<Media> pList = new List<Media>();
            PList = pList;
            PrivateList = privateList;

        }



    }
}
