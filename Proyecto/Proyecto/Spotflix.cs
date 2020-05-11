using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Spotflix
    {
        private Dictionary<string, User> UserDB = new Dictionary<string, User>();
        private Dictionary<string, List<Media>> MediaDB = new Dictionary<string, List<Media>>();

        public Dictionary<string, User> GetUserDB
        {
            get
            {
                return UserDB;
            }
        }

        public void MediaDBAdd()
        {
            List<Media> SongList = new List<Media>();
            List<Media> FilmList = new List<Media>();
            MediaDB.Add("Songs", SongList);
            MediaDB.Add("Films", FilmList);
        }

        public Spotflix()
        {
        }




        public void Register()
        {
            Console.Write("Username:");
            string username = Console.ReadLine();
            Console.Write("Email");
            string email = Console.ReadLine();

            bool samepass = false;

            while (samepass == false)
            {

                Console.Write("Password");
                string password = Console.ReadLine();
                // Agregar requerimientos de contraseña?                                                                 
                Console.Write("Confirm password");
                string password2 = Console.ReadLine();

                if (password == password2)
                {
                    samepass = true;
                }

                else
                {
                    Console.WriteLine("The password must be the same");
                }
            }

            Console.WriteLine("Make account private? y/n");
            int pvtac = Console.Read();

            bool privateAccount = false;
            if (pvtac == 'y')
            {
                privateAccount = true;
            }

            bool premium = false; //Para pagar premium se hace despues?

            User user = new User();


        }

        public void Load()
        {

        }
    }
}
