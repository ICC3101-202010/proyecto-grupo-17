using System;
namespace Proyecto
{
    public class SongMetadata
    {
        public string Name;
        public Artist Artist1;
        public string Album;
        public string Genre;
        public int PublicationYear;

        public SongMetadata(string name, Artist artist, string album, string genre, int publicationYear)
        {
            Name = name;
            Artist1 = artist;
            Album = album;
            Genre = genre;
            PublicationYear = publicationYear;
        }
    }
}
