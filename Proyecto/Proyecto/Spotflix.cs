using System;
using System.Collections.Generic;

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

        public static Dictionary<string, User> GetUserDB()
        {
            return UserDB;
        }

        public static void ImportMedia(Media media)
        {

            //Media a = new Media();

            MediaDB.Add(media);
        }






        public static void Register()
        {
            bool usertaken = true;
            string username = null;
            string askusername = "Username: ";

            while (usertaken)
            {
                Console.Write(askusername);
                username = Console.ReadLine();

                if (UserDB.ContainsKey(username) == true)
                {
                    Console.WriteLine("Username taken, please choose a different one.");
                    askusername = "Try a different username: ";
                }
                else
                {
                    usertaken = false;
                }

            }

            string email = null;
            bool emailtaken = true;
            string askemail = "Email: ";

            while (emailtaken)
            {
                Console.Write(askemail);
                email = Console.ReadLine();
                if (RegexUtilities.IsValidEmail(email))
                {
                    
                    string ver = null;


                    foreach (User us in UserDB.Values)
                    {
                        if (us.GetEmail() == email)
                        {
                            ver = "x";
                        }
                    }

                    if (ver == "x")
                    {

                        Console.WriteLine("Email already in use.");
                        askemail = "Try a different email address: ";
                        int check = 0;
                        while (check != 'y' || check != 'n')
                        {
                            Console.WriteLine("Do you want to sign in with that email? y/n");
                            check = Console.Read();
                            Console.Write("\n");
                            if (check == 'y')
                            {
                                return;
                            }
                            else if (check == 'n')
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice.");
                            }
                        }
                    }
                    else
                    {
                        emailtaken = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid email.");
                }


            }

            bool samepass = false;
            string password = null;

            while (samepass == false)
            {

                Console.Write("Password: ");
                password = RegexUtilities.HidePassword();
                Console.WriteLine();
                // Agregar requerimientos de contraseña?                                                                 
                Console.Write("Confirm password: ");
                string password2 = RegexUtilities.HidePassword();
                Console.WriteLine();
                if (password == password2)
                {
                    samepass = true;
                }

                else
                {
                    Console.WriteLine("The password must be the same");
                }
            }
            int pvtac = 0;
            bool privateAccount = false;
            while (pvtac != 'y' | pvtac != 'n')
            {

                Console.WriteLine("Make account private? y/n");
                pvtac = Console.Read();
                Console.WriteLine();

                if (pvtac == 'y')
                {
                    privateAccount = true;
                    break;
                }

                else if (pvtac == 'n')
                {
                    privateAccount = false;
                    break;
                }

            }
            bool premium = false; //Para pagar premium se hace despues?

            User user = new User(username, email, password, privateAccount, premium);

            UserDB.Add(username, user);


        }

        public static void LogIn()
        {
            Console.WriteLine("Welcome!");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
        }
    }
}
