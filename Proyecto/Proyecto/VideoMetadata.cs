using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class VideoMetadata
    {
        public string Name;
        public string Creator;
        public string Genre;
        public string Category;
        public List<Person> Actors;
        public Person Director;
        public string Studio;
        public int PubYear;
        public string Description;
        public double Score;

        public VideoMetadata(string name, string creator, string genre, string category, List<Person> actors, Person director, string studio, int pubYear, string description, double score)
        {
            Name = name;
            Creator = creator;
            Genre = genre;
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
