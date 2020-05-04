using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Album
    {
        string name;
        List<Song> Song_List;
        

        public Album(string name, List<Song> Song_List)
        {
            this.name = name;
            this.Song_List = Song_List;
        }
    }
}
