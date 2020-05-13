﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto
{
    [Serializable]
    public static class Spotflix
    {
        private static Dictionary<string, User> UserDB = new Dictionary<string, User>();
        private static List<Media> MediaDB = new List<Media>();
        static List<Song> SongDB = new List<Song>();
        static List<Video> VideoDB = new List<Video>();

        //static Dictionary<string, List<Media>> mediaDB = new Dictionary<string, List<Media>>()
        //{
            //{"Songs", SongDB},
            //{"Videos", VideoDB}
        //};


        public static List<Song> GetSongDB
        {
            get
            {
                return SongDB;
            }
        }

        public static List<Video> GetVideoDB
        {
            get
            {
                return VideoDB;
            }
        }

        static Spotflix()
        {

        }

        public static Dictionary<string, User> GetUserDB
        {
            get
            {
                return UserDB;
            }
        }

        public static void ImportMedia(Media media)
        {

            //Media a = new Media();

            MediaDB.Add(media);
        }


        public static void LogIn()
        {
            Console.WriteLine("Welcome!");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
        }


        public static void Register()
        {
            string username = null;
            string password = null;
            string password2 = null;
            string email = null;
            bool privateAccount = true;
            bool premium = false;
            string a = null;
            string b = null;
            string c = null;
            string d = null;
            bool usertaken = false;
            bool emailtaken = false;
            string pvt = "";
            string prem = "";

            List<string> registrationForm = new List<string>()
            {
                "Username: ",
                "Email: ",
                "Password: ",
                "Confirm password: ",
                "Private account? y/n",
                "Premium user? y/n",
                "Ready!",
                "Back"
            };

            List<string> yesNo = new List<string>() { "Yes", "No" };

            while (true)
            {

                string sel = RegexUtilities.GetMenu(registrationForm);

                if (sel == registrationForm[0])
                {
                    registrationForm[0] = registrationForm[0].Substring(0, 10);
                    Console.Clear();
                    Console.CursorVisible = true;
                    username = RegexUtilities.WriteData(registrationForm[0]);
                    Console.CursorVisible = false;
                    if (UserDB.ContainsKey(username))
                    {
                        usertaken = true;
                        Console.Clear();
                        Console.WriteLine("Username taken, please choose a different one.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        registrationForm[0] += username;
                        usertaken = false;
                    }

                    Console.Clear();
                   
                }
                else if(sel == registrationForm[1])
                {
                    registrationForm[1] = registrationForm[1].Substring(0, 7);
                    Console.Clear();
                    Console.CursorVisible = true;
                    email = RegexUtilities.WriteData(registrationForm[1]);
                    foreach (User user in UserDB.Values)
                    {
                        if (user.GetEmail() == email)
                        {
                            emailtaken = true;
                            break;
                        }
                        else
                        {
                            emailtaken = false;
                        }
                    }

                    Console.CursorVisible = false;

                    if (RegexUtilities.IsValidEmail(email) == true && emailtaken == false)
                    {
                        registrationForm[1] += email;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid email or email already in use!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        email = null;
                    }

                    
                    Console.Clear();
                }

                else if (sel == registrationForm[2])
                {
                    registrationForm[2] = registrationForm[2].Substring(0, 10);
                    Console.Clear();
                    Console.CursorVisible = true;
                    Console.Write(registrationForm[2]);
                    password = RegexUtilities.HidePassword();
                    Console.CursorVisible = false;
                    Console.Clear();
                    a = "";
                    foreach (char item in password) { a += "•"; }
                    registrationForm[2] = $"Password: {a}";
                }
                else if (sel == registrationForm[3] && password == null)
                {
                    Console.Clear();
                    Console.WriteLine("You must enter a password first!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if (sel == registrationForm[3] && password != null)
                {
                    registrationForm[3] = registrationForm[3].Substring(0, 18);
                    Console.Clear();
                    Console.CursorVisible = true;
                    Console.Write(registrationForm[3]);
                    password2 = RegexUtilities.HidePassword();
                    b = "";
                    foreach (char item in password2) { b += "•"; }
                    registrationForm[3] = $"Confirm password: {b}";
                    Console.CursorVisible = false;
                    Console.Clear();
                }

                else if (sel == registrationForm[4])
                {
                    c = "x";
                    while (true)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("Do you want your account to be private?");
                        pvt = RegexUtilities.GetMenu(yesNo);
                        if (pvt == "Yes")
                        {
                            privateAccount = true;
                            registrationForm[4] = registrationForm[4].Substring(0, 15);
                            registrationForm[4] += ": Yes";
                            break;

                        }
                        else if (pvt == "No")
                        {
                            privateAccount = false;
                            registrationForm[4] = registrationForm[4].Substring(0, 15);
                            registrationForm[4] += ": No";
                            break;
                        }
                    }
                    Console.Clear();

                }

                else if (sel == registrationForm[5])
                {
                    d = "x";
                    while (true)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("Do you want to get our premium service for only $3.990/month?"); // Que incluye...?
                        prem = RegexUtilities.GetMenu(yesNo);
                        if (prem == "Yes")
                        {
                            premium = true;
                            registrationForm[5] = registrationForm[5].Substring(0, 12);
                            registrationForm[5] += ": Yes";
                            break;
                        }
                        else if (prem == "No")
                        {
                            premium = false;
                            registrationForm[5] = registrationForm[5].Substring(0, 12);
                            registrationForm[5] += ": No";
                            break;
                        }
                    }
                    Console.Clear();
                }

                else if (sel == registrationForm[6])
                {
                    if (username == null | usertaken == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Username in already taken or empty!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    else if (password != password2 | password == null | password2 == null | password == "" | password2 == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Password doesn't match or empty!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    else if (email == null | emailtaken == true | email == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid email address!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    else if (c == null)
                    {
                        Console.Clear();
                        Console.WriteLine("You have to select if you want your account to be private!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    else if (d == null)
                    {
                        Console.Clear();
                        Console.WriteLine("You have to select if you want a premium account!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        User user = new User(username, email, password, privateAccount, premium);
                        UserDB.Add(username, user);
                        Console.Clear();
                        Console.WriteLine("User created successfully!");
                        Console.WriteLine("Now you can log in with your username and password.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        return;
                    }

                }
                                                                                                                              
                else if (sel == registrationForm[7])
                {
                    return;
                }

                if (password == password2 && password != null)
                {
                    registrationForm[2] = $"Password: {a} ✔";
                    registrationForm[3] = $"Confirm password: {b} ✔";

                }
                else if (password != password2 && password != null && password2 != null)
                {
                    registrationForm[2] = $"Password: {a} ✗";
                    registrationForm[3] = $"Confirm password: {b} ✗";
                }

                





            }







        }



    }
}
