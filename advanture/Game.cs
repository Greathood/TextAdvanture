using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanture
{
    public class Game
    {
        public static void intro()
        {
            string name = null;
            int choice = 0;

            Console.WriteLine("Welcome to this text advanture");
            Console.WriteLine("Could you tell me your name?");
            Console.WriteLine("My name is:");

            name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Welcome " + name + " are you ready to start this advanture?");


            Console.WriteLine("1. Yes!");
            Console.WriteLine("2. No! I'm afraid");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Okay let us proceed");
                    break;
                case 2:
                    Console.WriteLine("See you next time, " + name);
                    Console.ReadKey();
                    break;
            }

        }
        
    }
}
