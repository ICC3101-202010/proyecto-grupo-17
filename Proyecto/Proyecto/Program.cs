using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Proyecto
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            User user1 = new User("jmzegers", "jmzegers@gmail.com", "1234", true, true);
            User user2 = new User("jpzegers", "jpzegers@gmail.com", "2345", true, false);
            User user3 = new User("nzegers", "nzegers@gmail.com", "3456", false, true);
            User user4 = new User("mmzegers", "mmzegers@gmail.com", "5678", false, false);

            Spotflix.AddToUserDB("jmzegers", user1);

            Console.WriteLine("Hello, and welcome to Spotflix!");
            Console.WriteLine("Are you a new user or a returning one? new/ret");
            string ans = Console.ReadLine();

            if (ans == "new")
            {
                Spotflix.Register();
            }

            else if (ans == "ret")
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

                            Console.WriteLine("Do you wish to follow this account? y/n");
                            string a2 = Console.ReadLine();

                            if (a2 == "y")
                            {
                                User u = Spotflix.GetUserDB[userN];
                                List<object> f1 = u.GetFollowing();
                                f1.Add(u2);
                                List<User> f2 = u2.GetFollowers();
                                f2.Add(u);
                            }
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

        }


    }


}
//string a = "sss.mp4";
//_ = Process.Start(a);
//private Process a = new Process();