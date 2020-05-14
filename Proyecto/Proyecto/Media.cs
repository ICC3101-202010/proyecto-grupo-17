using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Proyecto
{
    [Serializable]
    public class Media
    {
        protected Dictionary<string, List<string>> Information;
        protected int UsersLike;
        protected double Score;
        protected int Views;
        protected string FileName;


        public Media(string fileName)
        {
            Dictionary<string, List<string>> information = new Dictionary<string, List<string>>();
            FileName = fileName;
            Information = information;
            UsersLike = 0;
            Score = 0;
            Views = 0;
        }

        public void MetadataInfo()
        {

        }
        public void SetScore()
        {
            //Event con score que saca promedio
        }

        public void SetViews()
        {
            //Event con play
        }


        public void TiempoReproduccion()
        {

        }

        public void AddInfo()
        {

        }


        public void Play()
        {
            _ = Process.Start(FileName);
        }

        public void AddToQueue()
        {

        }

        public void AddLike(bool a)
        {
            // Event

            if (a == true)
            {
                UsersLike += 1;
            }
            else
            {
                UsersLike -= 1;
            }
            
        }
        
    }
}
