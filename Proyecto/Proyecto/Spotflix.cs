using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Spotflix
    {
        private List<User> Users;

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
            }

            Console.WriteLine("Make account private? y/n");
            int pvtac = Console.Read();

            bool privateAccount = false;
            if (pvtac == 'y')
            {
                privateAccount = true;
            }

            bool premium = false; //Para pagar premium se hace despues?

            User user = new User()


        }

        public void Load()
        {

        }
    }
}
