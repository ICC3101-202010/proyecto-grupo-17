using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Media
    {
        protected Dictionary<string, List<string>> Metadata = new Dictionary<string, List<string>>();
        protected Dictionary<string, List<string>> Information = new Dictionary<string, List<string>>();
        int Users_Like;
        double Score;
        int Views;

        public Media(Dictionary<string, List<string>> Metadata, Dictionary<string, List<string>> Information, int Users_Like, double Score, int Views)
        {
            this.Metadata = Metadata;
            this.Information = Information;
            this.Users_Like = Users_Like;
            this.Score = Score;
            this.Views = Views;
        }

        public int Tiempo_Reproduccion()
        {

        }
    }
}
