using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class SongMetadata : Metadata
    {
        private string Name;
        private Artist Artist;
        private Album Album;
        private string Genre;
        private int PublicationYear;
        private string RecordLabel;
        private string Lyrics;

        public SongMetadata()
        {
            Add();
        }

        public override string GetName() { return Name; }
        public override Artist GetArtist() { return Artist; }
        public override Album GetAlbum() { return Album; }
        public override string GetGenre() { return Genre; }
        public int GetPublicationYear() { return PublicationYear; }
        public string GetLabel() { return RecordLabel; }

        public void AddLyrics(string lyrics)
        {
            Lyrics = lyrics;
        }

        public string GetLyrics()
        {
            return Lyrics;
        }

        public void Add()
        {
            List<string> metaMenu = new List<string>() {"Name: ","Artist: ","Album: ","Genre: ", "Release Year: ", "Record Label: ",
             "Done!", "Back"};
            string name = "";
            string artist = "";
            string genre = "";
            string album = "";
            string label = "";
            string rYear = "";
            
            Artist artObj = null;
            Album alObj = null;
            int relYear = 0;
            bool artExist = false;
            
            

            while (true)
            {
                string sel = RegexUtilities.GetMenu(metaMenu);

                if (sel == metaMenu[0]) //Name[0]
                {
                    metaMenu[0] = metaMenu[0].Substring(0, 6);
                    Console.Clear();
                    Console.CursorVisible = true;
                    name = RegexUtilities.WriteData(metaMenu[0]);
                    Console.CursorVisible = false;
                    metaMenu[0] += name;
                    Console.Clear();
                }

                else if (sel == metaMenu[1]) //Artist[1]
                {
                    metaMenu[1] = metaMenu[1].Substring(0, 8);
                    Console.Clear();
                    Console.CursorVisible = true;
                    artist = RegexUtilities.WriteData(metaMenu[1]);
                    Console.CursorVisible = false;
                    metaMenu[1] += artist;
                    Console.Clear();
                }

                else if (sel == metaMenu[2]) //Album[2]
                {
                    metaMenu[2] = metaMenu[2].Substring(0, 7);
                    Console.Clear();
                    Console.CursorVisible = true;
                    album = RegexUtilities.WriteData(metaMenu[2]);
                    Console.CursorVisible = false;
                    metaMenu[2] += album;
                    Console.Clear();
                }

                else if (sel == metaMenu[3]) //Genre[3]
                {
                    metaMenu[3] = metaMenu[3].Substring(0, 7);
                    Console.Clear();
                    Console.CursorVisible = true;
                    genre = RegexUtilities.WriteData(metaMenu[3]);
                    Console.CursorVisible = false;
                    metaMenu[3] += genre;
                    Console.Clear();
                }


                else if (sel == metaMenu[4]) //Release Year[4]int
                {
                    metaMenu[4] = metaMenu[4].Substring(0, 14);
                    Console.Clear();
                    Console.CursorVisible = true;
                    while (true)
                    {
                        rYear = RegexUtilities.WriteData(metaMenu[4]);
                        try
                        {
                            relYear = Convert.ToInt32(rYear);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please write a valid number");
                            Console.Clear();
                        }
                    }
                    Console.CursorVisible = false;
                    metaMenu[4] += rYear;
                    Console.Clear();
                }

                else if (sel == metaMenu[5]) //Label[5]
                {
                    metaMenu[5] = metaMenu[5].Substring(0, 14);
                    Console.Clear();
                    Console.CursorVisible = true;
                    label = RegexUtilities.WriteData(metaMenu[5]);
                    Console.CursorVisible = false;
                    metaMenu[5] += label;
                    Console.Clear();
                }



                else if (sel == metaMenu[6]) //Done[6]
                {


                    if (name != "" && artist != "" && genre != "" && album != "" && label != ""
                        && relYear > 0)
                    {
                        foreach (Artist ar in Spotflix.GetPeopleDB)
                        {
                            if (ar.GetName() == artist)
                            {
                                artExist = true;
                                artObj = ar;
                                break;
                            }
                        }
                        if (artExist == false)
                        {
                            artObj = new Artist(artist);
                            Spotflix.AddPerson(artObj);
                            alObj = new Album(album);
                            artObj.AddAlbum(alObj);
                        }

                        else if (artExist == true)
                        {
                            foreach (Album item in artObj.GetAlbums())
                            {
                                if (item.GetName() == album)
                                {
                                    alObj = item;
                                    break;
                                }
                            }

                            if (alObj == null)
                            {
                                alObj = new Album(album);
                                artObj.AddAlbum(alObj);

                            }
                        }
                        Name = name;
                        Artist = artObj;
                        Album = alObj;
                        Genre = genre;
                        RecordLabel = label;
                        PublicationYear = relYear;
                        return;

                    }


                    else
                    {
                        Console.Clear();
                        Console.WriteLine("There is missing information, please fill all the fields.");
                    }
                }
                else if (sel == metaMenu[7]) //Back[7]
                {
                    return;
                }

            }


        }

        public override string GetCreator()
        {
            return null;
        }

        public override string GetCategory()
        {
            return null;
        }

        public override Person GetDirector()
        {
            return null;
        }

        public override string GetStudio()
        {
            return null;
        }

        public override List<Person> GetActors()
        {
            return null;
        }
    }
}
