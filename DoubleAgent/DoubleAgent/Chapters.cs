using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DoubleAgent
{
    class Chapters
    {
        static Random rnd = new Random();

        static string playerName;
        static int pin = rnd.Next(1000, 10000);
        static string checkIn = DateTime.Now.ToString("HH:mm");
        public static int points = 0;

        public static void Chapter1()
        {
            //Dialog(character, message, wait time (Seconds))
            Dialog("nav", "Welcome... Initializing...", 3);
            Dialog("nav", "Please verify your agent credentials...", 1);
            Console.Write("Name: ");
            playerName = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Dialog("player", $"Agent {playerName}, arriving from Sector 8, checking in at {checkIn}.", 3);
            Dialog("nav", "Thank you...", 3);
            Dialog("nav", $"Your facility-assigned PIN will be: {pin}.", 1);
            Dialog("nav", "Your superior will be: Agent Smith.", 1);
            Pause();
            Console.Clear();
            Thread.Sleep(1000);
            Dialog("story", "You step out of the security chamber. Waiting on the other side of the door is agent SMITH", 2);
            Dialog("smith", $"Welcome {playerName}, glad to have you here with us.", 2);
            Console.WriteLine("1) \"Glad to be here!\" \n2) \"I've never seen a place this big!\"");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();
            if(choice == "1")
            {
                Dialog("player", "Glad to be here!", 2);
                Dialog("smith", "Excellect. Let's discuss this matter in my office.", 2);
                points = points + 1;

            }
            else if(choice == "2")
            {
                Dialog("player", "I've never seen a place this big!", 2);
                Dialog("smith", "This is the headquarters of all our operations. Come to my office and we'll debrief.", 2);
                points = points + 2;
            }
            else
            {
                //TODO Make 3rd (Hidden) option. since i dont' wanna catch errors.
                Dialog("player", "I'm a big dumb idiot!", 2);
            }

            Dialog("story", "You walk with him to his office.", 2);
            Dialog("smith", "Now, we have intelligence that is showing us signs that we may have a double agent in our hands in our HQ. We've been informed that you"+ 
                " are the best agent to help us.", 4);

            //Insert more story here------------------------------
            Dialog("story", "You accept the task and get going. Should you scout the area first? Or get an early start on spying?", 2);
            Console.WriteLine("1) Scout the area. \n2) Spy");
            Console.Write("Choice: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Dialog("player", "I'm going to start scouting", 2);
            }
            else if (choice == "2")
            {
                Dialog("player", "I'll start spying on him", 2);
            }
            else
            {
                Console.WriteLine("Make something for this");
            }

            Dialog("nav", "Enter PIN to access door", 2);
            Console.Write("PIN: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if(choice == pin.ToString())
            {
                Dialog("nav", "PIN Correctly Entered", 2);
            }
            else if(choice != pin.ToString())
            {
                Dialog("nav", "!!!SECURITY BREACH!!! - Reseting stronger PIN", 2);
                pin = rnd.Next(1000000, 9999999);
                Dialog("nav", $"PIN reset... Your new PIN: {pin}", 2);
            }
            Dialog("story", "The door opens. Inside you find an armory with many weapons and gadgets.", 2);
        }

        public static void Chapter2() //Should probably change this to chapter 3

        {
            Console.WriteLine("Start of chap2");
        }
           
        static void Dialog(string character, string message, int time)
        {
            time = time * 1000;
            switch (character)
            {
                case "player":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(playerName + ": " + message + Environment.NewLine);
                    Console.ResetColor();
                    Thread.Sleep(time);
                    break;
                case "nav":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("NAV: " + message + Environment.NewLine);
                    Console.ResetColor();
                    Thread.Sleep(time);
                    break;
                case "story":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(message + "\n");
                    Console.ResetColor();
                    Thread.Sleep(time);
                    break;
                case "smith":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SMITH: " + message + Environment.NewLine);
                    Console.ResetColor();
                    Thread.Sleep(time);
                    break;
            }
        }
        static void Pause()
        {
            string text = "Press any key to continue \n";
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
            Console.ReadKey(true);
        }
    }
}
