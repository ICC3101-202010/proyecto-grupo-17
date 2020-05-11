﻿using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Playlist
    {
        private string Name;
        private bool PrivateList;
        private List<Media> PList;
        private User CreatedBy;

        public Playlist(string name, bool privateList, User createdBy)
        {

            Name = name;
            List<Media> pList = new List<Media>();
            PList = pList;
            PrivateList = privateList;
            CreatedBy = createdBy;

        }


        public string GetName() { return Name; }

        public void AddMedia(Media media)
        {
            PList.Add(media);
        }

        public List<Media> GetList()
        {
            return PList;
        }
    }
}
