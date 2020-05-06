using System;
using System.Diagnostics;

namespace Proyecto
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            int a = Console.Read();
            Console.WriteLine(a);
            if (a == 'y')
            {
                Console.WriteLine("True");
            }
        }


    }
}
//string a = "sss.mp4";
//_ = Process.Start(a);
//private Process a = new Process();