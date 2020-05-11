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
            Console.WriteLine("Hello, and welcome to Spotflix!");
            Console.WriteLine("Are you a new user or a returning one? new/returning");
            string ans = Console.ReadLine();

            if (ans == "new")
            {
                
            }

            else if (ans == "returning")
            {
                Console.WriteLine("Please write your username and password");
                Console.WriteLine("Username: ");
                string userN = Console.ReadLine();
                Console.WriteLine("Password: ");
                string passW = Console.ReadLine();

                Spotflix SF = new Spotflix();

                if (SF.GetUserDB.ContainsKey(userN) == true)
                {
                    User userData = SF.GetUserDB[userN];

                    if (userData.GetPassword == passW)
                    {
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("a) Search for music or films");
                        Console.WriteLine("b) Access your playlists");
                        Console.WriteLine("c) Create a new playlist");
                        Console.WriteLine("d) Exit");

                        string Ans = Console.ReadLine();

                        if (Ans == "a")
                        {

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