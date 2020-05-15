using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;



namespace Proyecto
{
    class MainClass
    {
        
        static string fileName = "Spotflix.bin";

        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            RegexUtilities.LoadingScreen();
            Thread.Sleep(3000);
            List<string> start = new List<string>() { "Hello, and welcome to Spotflix!", "Log In" , "Register" ,"Admin Log In", "Exit"};
            List<string> mainMenu = new List<string>() { "Menu", "Search", "Profile", "play", "Log out" };
            List<string> searchMenu = new List<string>() {"Search: ", "Filters", "Go!", "Back" };
            Console.Clear();
            while (true)
            {
                RegexUtilities.LoadingScreen();
                string selectedMenuItem = RegexUtilities.GetMenu(start);
                if (selectedMenuItem == "Log In")
                {
                    Console.Clear();
                    RegexUtilities.LoadingScreen();
                    string username = Spotflix.LogIn();

                    if (username != "")
                    {
                        User activeUser = Spotflix.GetUserDB[username];
                        while (true)
                        {
                            Console.Clear();
                            RegexUtilities.LoadingScreen();
                            selectedMenuItem = RegexUtilities.GetMenu(mainMenu);
                            if (selectedMenuItem == "Log out") { username = ""; break; }

                            else if (selectedMenuItem == "Search")
                            {
                                while (true)
                                {
                                    Console.Clear();
                                    RegexUtilities.LoadingScreen();
                                    selectedMenuItem = RegexUtilities.GetMenu(searchMenu);
                                    string searchKey = "";
                                    if (selectedMenuItem == searchMenu[0])
                                    {
                                        Console.Clear();
                                        RegexUtilities.LoadingScreen();
                                        searchMenu[0] = searchMenu[0].Substring(0, 8);
                                        searchKey = RegexUtilities.WriteData(searchMenu[0]);
                                        searchMenu[0] += searchKey;
                                        Console.Clear();

                                    }

                                    else if (selectedMenuItem == searchMenu[2])
                                    {
                                        Filter fil = new Filter();
                                        List<Media> results = fil.Search(searchKey);
                                        if (results.Count > 0)
                                        {
                                            List<string> lsSe = new List<string>();
                                            foreach (Media media in results)
                                            {
                                                lsSe.Add(media.GetMetadata().GetName());
                                            }
                                            lsSe.Add("Back");
                                            while (true)
                                            {
                                                string selectMedia = RegexUtilities.GetMenu(lsSe);
                                                if (selectMedia != "" && selectMedia != "Back")
                                                {
                                                    int ind = lsSe.IndexOf(selectMedia);
                                                    Media media = results[ind];
                                                    if (media.GetType() == typeof(Song))
                                                    {
                                                        //display info
                                                        media.Play();
                                                    }
                                                }
                                                else if (selectMedia == "Back")
                                                {
                                                    break;
                                                }

                                            }
                                        }
                                    }
                                    else if (selectedMenuItem == searchMenu[3])
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                }
                            }

                            else if (selectedMenuItem == "play")
                            {


                                //SoundPlayer player = new SoundPlayer();
                                //player.SoundLocation = "CSI.wav";
                                //player.Play();
                                //Player player = new Player();
                                //player.Open("CSI.wav");
                                //Thread.Sleep(30000);
                                //player.End();
                                


                            }
                        }
                    }
                    
                   
                }

                else if (selectedMenuItem == "Register")
                {
                    Console.Clear();
                    RegexUtilities.LoadingScreen();
                    Spotflix.Register();
                    Save(Spotflix.GetUserDB , Spotflix.GetMediaDB, Spotflix.GetPeopleDB, fileName);
                }

                else if (selectedMenuItem == "Admin Log In")
                {
                    
                    Console.Clear();
                    RegexUtilities.LoadingScreen();
                    string adm = Spotflix.AdminLogIn();
                    if (adm != "")
                    {
                        User administrator = Spotflix.GetUserDB[adm];



                        List<string> admMenu = new List<string>() { "Add Media", "a", "b", "c", "Log out" };
                        while (true)
                        {
                            Console.Clear();
                            selectedMenuItem = RegexUtilities.GetMenu(admMenu);

                            if (selectedMenuItem == "Add Media")
                            {
                                Console.Clear();
                                RegexUtilities.LoadingScreen();
                                administrator.AddMedia();
                                Save(Spotflix.GetUserDB, Spotflix.GetMediaDB, Spotflix.GetPeopleDB, fileName);
                                Console.WriteLine("Ready");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }

                            else if (selectedMenuItem == "Log out")
                            {
                                adm = "";
                                break;
                            }

                            else if (selectedMenuItem == "a")
                            {
                                

                            }

                            Save(Spotflix.GetUserDB, Spotflix.GetMediaDB, Spotflix.GetPeopleDB, fileName);
                        }



                    }

                    else
                    {
                        Console.Clear();
                        RegexUtilities.LoadingScreen();
                        Console.WriteLine("You are not an administrator.");
                        break;
                    }
                        
                    
                Save(Spotflix.GetUserDB, Spotflix.GetMediaDB, Spotflix.GetPeopleDB, fileName);
                }



                else if (selectedMenuItem == "Exit")
                {
                    Save(Spotflix.GetUserDB, Spotflix.GetMediaDB, Spotflix.GetPeopleDB, fileName);
                    Environment.Exit(0);
                }
                

                
                Console.Clear();
            }


            /*

            string ans = Console.ReadLine();

            if (ans == "new")
            {
                Spotflix.Register();
            }

            else if (ans == "returning")
            {
                Console.WriteLine("Please write your username and password");
                Console.WriteLine("Username: ");
                string userN = Console.ReadLine();
                Console.WriteLine("Password: ");
                string passW = Console.ReadLine();

                

                if (Spotflix.GetUserDB.ContainsKey(userN) == true)
                {
                    User userData = Spotflix.GetUserDB[userN];

                    if (userData.GetPassword() == passW)
                    {
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("a) Search for music or videos");
                        Console.WriteLine("b) Go to playlists");
                        Console.WriteLine("c) Look for other profiles");
                        Console.WriteLine("");
                        Console.WriteLine("d) Exit");

                        string Ans = Console.ReadLine();

                        if (Ans == "a")
                        {
                            Console.WriteLine("Please write the name of the song or video that you are looking for");
                            string search = Console.ReadLine();

                            Console.WriteLine("Do you wish to apply any filters? y/n");
                            string a = Console.ReadLine();

                            if (a == "y")
                            {
                                Console.WriteLine("Please choose one or more of the following filters:");
                                Console.WriteLine("For songs:");
                                Console.WriteLine("1) Name");
                                Console.WriteLine("2) Artist");
                                Console.WriteLine("3) Album");
                                Console.WriteLine("4) Genre");
                                Console.WriteLine("");
                                Console.WriteLine("For videos:");
                                Console.WriteLine("5) Name");
                                Console.WriteLine("6) Creator");
                                Console.WriteLine("7) Genre");
                                Console.WriteLine("8) Category");
                                Console.WriteLine("9) Director");
                                Console.WriteLine("10) Studio");

                                Console.WriteLine("Please type the numbers next to the desired filters");
                                List<int> FilterList = new List<int>();

                                string b1 = "y";

                                while (b1 == "y")
                                {
                                    Console.WriteLine("Filter:");

                                    int f1 = Convert.ToInt32(Console.ReadLine());
                                    FilterList.Add(f1);

                                    Console.WriteLine("Do you wish to add another filter? y/n");
                                    b1 = Console.ReadLine();

                                    if (FilterList.Count >= 9) //Security measure, so that nobody can write filters forever.
                                    {
                                        b1 = "n";
                                    }
                                }

                                Filter f2 = new Filter();

                                foreach(object o in f2.FilteredSearch(FilterList, a))
                                {
                                    Console.WriteLine(o);
                                }
                            }


                            else if (a == "n")
                            {
                                Filter f2 = new Filter();

                                foreach(object o in f2.Search(a))
                                {
                                    Console.WriteLine(o);
                                }
                            }


                            Console.WriteLine("What do you want to search for?");
                            string a1 = Console.ReadLine();

                            Filter f = new Filter();
                            List<object> filtered = f.Search(a1);

                            foreach (object o in filtered)
                            {
                                Console.WriteLine(o);
                            }
                        }


                        else if (Ans == "B" || Ans == "b")
                        {
                            User u = Spotflix.GetUserDB[userN];
                            Console.WriteLine("Do you wish to:");
                            Console.WriteLine("A) Access your existing playlists?");
                            Console.WriteLine("B) Create a new one?");
                            string a1 = Console.ReadLine();

                            if (a1 == "A" || a1 == "a")
                            {
                                foreach(Playlist p in u.GetPlaylist())
                                {
                                    Console.WriteLine(p);
                                }
                                
                            }

                            else if(a1 == "B" || a1 == "b")
                            {
                                u.NewPlaylist();
                            }

                            else
                            {
                                Console.WriteLine("Invalid answer");
                            }

                        }

                        else if (Ans == "C" || Ans == "c")
                        {
                            Console.WriteLine("Please state the name of the user you are looking for");
                            string userSearch = Console.ReadLine();
                            User u2 = Spotflix.GetUserDB[userSearch];

                            try
                            {
                                u2 = Spotflix.GetUserDB[userSearch];
                                
                            }

                            catch(Exception e)
                            {
                                Console.WriteLine("User not found");
                                Console.WriteLine(e.Message);
                            }

                            Console.WriteLine("Here's the public info in the account");
                            Console.WriteLine(" ");

                            Console.WriteLine("Account name: ");
                            Console.Write(u2.GetUsername());
                            Console.WriteLine(" ");

                            Console.WriteLine("List of playlists: ");
                            Console.Write(u2.GetPlaylist());
                            Console.WriteLine(" ");

                            Console.WriteLine("List of people who follow this account: ");
                            Console.Write(u2.GetFollowers());
                            Console.WriteLine(" ");

                            Console.WriteLine("List of people that this account follows: ");
                            Console.WriteLine(u2.GetFollowing());
                            Console.WriteLine(" ");
                        }

                        else
                        {
                            Console.WriteLine("Invalid Answer");
                        }

                    }


                    else
                    {
                        Console.WriteLine("Wrong password");
                    }
                }


                else
                {
                    Console.WriteLine("User not found");
                }

            }

    */
        }

        public static void Save(Dictionary<string, User> userDB, List<Media> mediaDB, List<Person> peopleDB ,string name)
        {
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, userDB);
            formatter.Serialize(stream, mediaDB);
            formatter.Serialize(stream, peopleDB);
            stream.Close();
        }

        public static (Dictionary<string, User> ,List<Media>, List<Person>) Load(string name)
        {
            Stream stream = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            Dictionary<string, User> userDB = (Dictionary<string, User>)formatter.Deserialize(stream);
            List<Media> mediaDB = (List<Media>)formatter.Deserialize(stream);
            List<Person> peopleDB = (List<Person>)formatter.Deserialize(stream);
            stream.Close();

            return (userDB, mediaDB, peopleDB);
        }
    }


}
//string a = "sss.mp4";
//_ = Process.Start(a);
//private Process a = new Process();