using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Proyecto
{
    [Serializable]
    public class Media
    {
        protected Dictionary<string, List<string>> Information = new Dictionary<string, List<string>>();
        protected int UsersLike;
        protected double Score;
        protected int Views;
        protected string FileName;


        public Media(Dictionary<string, List<string>> Information)
        {
            this.Information = Information;
            UsersLike = 0;
            Score = 0;
            Views = 0;
        }

        public void MetadataInfo()
        {

        }





        public void TiempoReproduccion()
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
            if (a == true)
            {
                UsersLike += 1;
            }
            else
            {
                UsersLike -= 1;
            }
            
        }
        public string GetName()
        {
            return null;
        }
    }
}
