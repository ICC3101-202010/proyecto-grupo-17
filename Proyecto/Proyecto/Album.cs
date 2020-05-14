using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Album
    {
        private string Name;
        private List<Song> SongList;
        private string CoverPhoto;

        

        public Album(string name)
        {
            Name = name;
        }

        public void AddSong(Song song)
        {
            SongList.Add(song); //Event?
        }

        public string GetName()
        {
            return Name;
        }
    }
}
