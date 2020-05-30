using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class VideoMetadata : Metadata
    {
        private string Name;
        private string Creator;
        private string Genre;
        private string Category;
        private List<Person> Actors;
        private Person Director;
        private string Studio;
        private int PubYear;
        private string Description;
        private string Resolution;
        private string AspectRatio;

        public VideoMetadata()
        {
            Add();
        }

        public override string GetName() { return Name; }
        public override string GetCreator() { return Creator; }
        public override string GetGenre() { return Genre; }
        public override string GetCategory() { return Category; }
        public override string GetStudio() { return Studio; }
        public int GetPubYear() { return PubYear; }
        public string GetDescription() { return Description; }
        public override List<Person> GetActors() { return Actors; }
        public override Person GetDirector() { return Director; }
        public string GetResolution() { return Resolution; }
        public string GetAspectRatio() { return AspectRatio; }




        public void Add()
        {
            List<string> metaMenu = new List<string>() {"Name: ","Creator: ","Genre: ","Category: ", "Actors: ", "Director: ",
            "Studio: ", "Release Year: ", "Description: ", "Resolution: ", "Aspect Ratio: ","Done!", "Back"};
            string name = "";
            string creator = "";
            string genre = "";
            string category = "";
            string studio = "";
            string rYear = "";
            string description = "";
            Person dirObj = null;
            int relYear = 0;
            bool dirExist = false;
            string director = "";
            string resolution = "";
            string aspectRatio = "";
            List<string> resList = new List<string>() { "480p (720 x 480)", "720p (1280 x 720)", "1080p (1920 x 1080)",
                "1440p (2560 x 1440)" , "4K (3840 x 2160)", "8K (7680 x 4320)"};
            List<string> ratioList = new List<string>() {"Standard (4:3)", "Widescrenn 16:9", "Ultra Widescreen 21:9" };
            List<string> actors = new List<string>();

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

                else if (sel == metaMenu[1]) //Creator[1]
                {
                    metaMenu[1] = metaMenu[1].Substring(0, 9);
                    Console.Clear();
                    Console.CursorVisible = true;
                    creator = RegexUtilities.WriteData(metaMenu[1]);
                    Console.CursorVisible = false;
                    metaMenu[1] += creator;
                    Console.Clear();
                }

                else if (sel == metaMenu[2]) //Genre[2]
                {
                    metaMenu[2] = metaMenu[2].Substring(0, 7);
                    Console.Clear();
                    Console.CursorVisible = true;
                    genre = RegexUtilities.WriteData(metaMenu[2]);
                    Console.CursorVisible = false;
                    metaMenu[2] += genre;
                    Console.Clear();
                }

                else if (sel == metaMenu[3]) //Category[3]
                {
                    metaMenu[3] = metaMenu[3].Substring(0, 10);
                    Console.Clear();
                    Console.CursorVisible = true;
                    category = RegexUtilities.WriteData(metaMenu[3]);
                    Console.CursorVisible = false;
                    metaMenu[3] += category;
                    Console.Clear();
                }

                else if (sel == metaMenu[4])//Actors[4] list<person>
                {
                    metaMenu[4] = metaMenu[4].Substring(0, 8);
                    Console.Clear();
                    Console.CursorVisible = true;
                    actors = RegexUtilities.WriteList(metaMenu[4].Substring(0, 5));
                    Console.CursorVisible = false;
                    metaMenu[4] += "✔";
                    Console.Clear();
                }

                else if (sel == metaMenu[5]) //Director[5] Person
                {
                    metaMenu[5] = metaMenu[5].Substring(0, 10);
                    Console.Clear();
                    Console.CursorVisible = true;
                    director = RegexUtilities.WriteData(metaMenu[5]);
                    
                    foreach (Person person in Spotflix.GetPeopleDB)
                    {
                        if (person.GetName() == director)
                        {
                            dirExist = true;
                            dirObj = person;
                            break;
                        }
                    }
                    Console.CursorVisible = false;
                    metaMenu[5] += director;
                    Console.Clear();
                }

                else if (sel == metaMenu[6]) //Studio[6]
                {
                    metaMenu[6] = metaMenu[6].Substring(0, 8);
                    Console.Clear();
                    Console.CursorVisible = true;
                    studio = RegexUtilities.WriteData(metaMenu[6]);
                    Console.CursorVisible = false;
                    metaMenu[6] += studio;
                    Console.Clear();
                }

                else if (sel == metaMenu[7]) //Release Year[7]int
                {
                    metaMenu[7] = metaMenu[7].Substring(0, 14);
                    Console.Clear();
                    Console.CursorVisible = true;
                    while (true)
                    {
                        rYear = RegexUtilities.WriteData(metaMenu[7]);
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
                    metaMenu[7] += rYear;
                    Console.Clear();
                }

                else if (sel == metaMenu[8]) //Description[8]
                {
                    metaMenu[8] = metaMenu[8].Substring(0, 13);
                    Console.Clear();
                    Console.CursorVisible = true;
                    description = RegexUtilities.WriteData(metaMenu[8]);
                    Console.CursorVisible = false;
                    metaMenu[8] += description;
                    Console.Clear();
                }

                else if (sel == metaMenu[9]) //Res[9]
                {
                    metaMenu[9] = metaMenu[9].Substring(0, 12);
                    Console.Clear();
                    resolution = "";
                    while (resolution == "")
                    {
                        resolution = RegexUtilities.GetMenu(resList);
                    }
                    Console.CursorVisible = false;
                    metaMenu[9] += resolution;
                    Console.Clear();
                }

                else if (sel == metaMenu[10]) //ratio[10]
                {
                    metaMenu[10] = metaMenu[10].Substring(0, 14);
                    Console.Clear();
                    aspectRatio = "";
                    while (aspectRatio == "")
                    {
                        aspectRatio = RegexUtilities.GetMenu(ratioList);
                    }
                    Console.CursorVisible = false;
                    metaMenu[10] += aspectRatio;
                    Console.Clear();
                }
                else if (sel == metaMenu[11]) //Done[11]
                {
                    if (dirExist == true)
                    {
                        dirObj.AddProfession("Director");
                    }
                    else
                    {
                        dirObj = new Person(director);
                        Spotflix.AddPerson(dirObj);
                    }

                    List<Person> actrs = new List<Person>();
                    Person actr = null;
                    foreach (string act in actors)
                    {
                        bool actExist = false;
                        foreach (Person ppl in Spotflix.GetPeopleDB)
                        {
                            if (ppl.GetName() == act)
                            {
                                ppl.AddProfession("Actor");
                                actExist = true;
                                actrs.Add(ppl);
                                break;
                            }
                        }
                        if (actExist == false)
                        {
                            actr = new Person(act);
                            Spotflix.AddPerson(actr);
                            actrs.Add(actr);
                        }
                    }


                    if (name != "" && creator != "" && genre != "" && category != "" && actrs.Count > 0 && director != "" && studio != ""
                        && relYear > 0 && description != "" && resolution != "" && aspectRatio != "")
                    {
                        Console.Clear();
                        Name = name;
                        Creator = creator;
                        Genre = genre;
                        Category = category;
                        Actors = actrs;
                        Director = dirObj;
                        Studio = studio;
                        PubYear = relYear;
                        Description = description;
                        Resolution = resolution;
                        AspectRatio = aspectRatio;
                        return;
                    }
                    Console.Clear();
                }

                else if (sel == metaMenu[12]) //Back[12]
                {
                    return;
                }

            }


        }

        public override Artist GetArtist()
        {
            return null;
        }

        public override Album GetAlbum()
        {
            return null;
        }
    }
}
