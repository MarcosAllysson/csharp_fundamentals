using System;
using System.IO;

namespace TextEditor
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
            Console.WriteLine("What do you want to do? ");
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - Create a new file");
            Console.WriteLine("0 - Exit");

            short userOption = short.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1: OpenFile(); break;
                case 2: CreateNewFile(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Enter file path: "); // /home/marcos/Documents/Developer/C# | ASP.NET/TextEditor/text.txt
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void CreateNewFile()
        {
            Console.Clear();
            Console.WriteLine("Type your text below (ESC TO FINISH): ");
            Console.WriteLine("======================");

            string userText = "";

            do
            {
                userText += Console.ReadLine();
                userText += Environment.NewLine; // stepping a line when enter is hit.
            }
            // Verifying if user hits ESC
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            // Console.Write(userText);
            Save(userText);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Which path to save the file? ");
            var path = Console.ReadLine(); // /home/marcos/Documents/Developer/C# | ASP.NET/TextEditor/text.txt

            // Saving the file
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Save successfully at {path}");
            Console.ReadLine();
            Menu();
        }
    }
}
