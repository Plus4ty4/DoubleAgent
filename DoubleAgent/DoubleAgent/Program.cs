using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleAgent
{
    class Program
    {
        static void Main()
        {
            Game.MainMenu();

            Console.WriteLine("Game Over...");
            Console.WriteLine("Points: " + Chapters.points.ToString());
            Console.ReadKey(true);
        }
    }
}
