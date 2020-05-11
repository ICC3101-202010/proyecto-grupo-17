using System;
namespace Proyecto
{
    public class SongMetadata
    {
        public string Name;
        public Artist Artist1;
        public string Album;
        public string Gender;
        public int PublicationYear;

        public SongMetadata(string name, Artist artist, string album, string gender, int publicationYear)
        {
            Name = name;
            Artist1 = artist;
            Album = album;
            Gender = gender;
            PublicationYear = publicationYear;
        }
    }
}
