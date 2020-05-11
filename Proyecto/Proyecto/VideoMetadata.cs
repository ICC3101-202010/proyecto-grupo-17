using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class VideoMetadata
    {
        public string Name;
        public string Creator;
        public string Gender;
        public string Category;
        public List<Person> Actors;
        public Person Director;
        public string Studio;
        public int PubYear;
        public string Description;
        public double Score;

        public VideoMetadata(string name, string creator, string gender, string category, List<Person> actors, Person director, string studio, int pubYear, string description, double score)
        {
            Name = name;
            Creator = creator;
            Gender = gender;
            Category = category;
            Actors = actors;
            Director = director;
            Studio = studio;
            PubYear = pubYear;
            Description = description;
            Score = score;
        }
    }
}
