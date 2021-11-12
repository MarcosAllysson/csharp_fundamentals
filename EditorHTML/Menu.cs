using System;
using System.Threading;

namespace EditorHTML
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            WriteMenuLine();

            for (var lines = 0; lines < 11; lines++)
            {
                Console.Write("|");

                for (var i = 0; i < 31; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            WriteMenuLine();
        }

        public static void WriteMenuLine()
        {
            Console.Write("+");

            for (var i = 0; i < 31; i++)
                Console.Write("-");

            Console.Write("+");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("       HTML EDITOR      ");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("========================");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Choose an option below: ");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - New file");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Open a file");

            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Exit");

            Console.SetCursorPosition(3, 10);
            Console.Write("Your option: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2:
                    {
                        Console.WriteLine("What is the path? ");
                        string path = Console.ReadLine();
                        Editor.OpenFile(path);
                        break;
                    }
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("Leaving...");
                        Thread.Sleep(1500);
                        System.Environment.Exit(0);
                        break;
                    }
                default: ShowMenu(); break;
            }
        }
    }
}