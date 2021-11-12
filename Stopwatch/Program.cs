using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S -> second => 3s => 3 seconds");
            Console.WriteLine("M -> minute => 1m => 1 minute");
            Console.WriteLine("0 -> exit");
            Console.WriteLine("How much time do you want to count? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // getting the last char
            int time = int.Parse(data.Substring(0, data.Length - 1)); // getting all caracters except the last one

            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Getting ready...");
            Thread.Sleep(1000);

            Console.WriteLine("Set...");
            Thread.Sleep(1000);

            Console.WriteLine("GOOOOOOOOOOOOOOOO");
            Thread.Sleep(1500);

            Start(time);
        }
        static void Start(int time)
        {

            for (var i = 1; i <= time; i++)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000); // 1000 miliseonds is equal to 1 minute.
            }

            // int currentTime = 0;

            // while (currentTime != time)
            // {
            //     Console.Clear();
            //     currentTime++;
            //     Console.WriteLine(currentTime);
            //     Thread.Sleep(1000); // 1000 miliseonds is equal to 1 minute.
            // }

            Console.Clear();
            Console.WriteLine("Stopwatch finished!");
            Thread.Sleep(1500);
            Menu();
        }
    }
}
