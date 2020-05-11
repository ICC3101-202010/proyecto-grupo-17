using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class VideoMetadata
    {
        string Gender;
        string Category;
        List<Person> Actors;
        Person Director;
        string Studio;
        int PubYear;
        string Descrption;
        double Score;

        public VideoMetadata(string gender, string category, List<Person> actors, Person director, string studio, int pubYear, string description, double score)
        {
            Gender = gender;
            Category = category;
            Actors = actors;
            Director = director;
            Studio = studio;
            PubYear = pubYear;
            Descrption = description;
            Score = score;
        }
    }
}
