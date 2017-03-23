using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleAgent
{
    class Game
    {
        public static void MainMenu()
        {
            Console.Title = "Double Agent V0.1";
            Console.WriteLine("Double Agent");
            Console.WriteLine("1) New Game \n2) About \n3) How To Play");
            Console.Write("Choice: ");
            string input = Console.ReadLine();
            if(input == "1")
            {
                Console.Clear();
                StartGame();
            }
            else if(input == "2")
            {
                About();
            }
            else if(input == "3")
            {
                HowToPlay();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, {0} is not a vaild choice\n", input);
                MainMenu();
            }
        }

        static void StartGame()
        {
            Chapters.Chapter1();
            Chapters.Chapter2();
        }
        static void About()
        {
            Console.Clear();
            Console.WriteLine("Double Agent \nCreated by Brandon DeHart \nV:0.1 \n");
            Console.WriteLine("My first project!");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }

        static void HowToPlay()
        {
            Console.Clear();
            Console.WriteLine("How to play");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }
    }
}
