using System;
namespace Proyecto
{
    public class SongMetadata
    {
        public string Name;
        public Artist Artist1;
        public Album Album;
        public string Genre;
        public int PublicationYear;

        public SongMetadata(string name, Artist artist, Album album, string genre, int publicationYear)
        {
            Name = name;
            Artist1 = artist;
            Album = album;
            Genre = genre;
            PublicationYear = publicationYear;
        }
    }
}
