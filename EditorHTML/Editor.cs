using System;
using System.IO;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("       EDITOR MODE       ");
            Console.WriteLine("--------------------------");

            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Do you want to save the file? ");
            Console.WriteLine(" 1 - YES ");
            Console.WriteLine(" 2 - NO ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Your option: ");

            short userOption = short.Parse(Console.ReadLine());
            switch (userOption)
            {
                case 1:
                    {
                        Console.WriteLine("Which path? ");
                        string path = Console.ReadLine();

                        Console.WriteLine("What is the filename? ");
                        string filename = Console.ReadLine();

                        SaveFile(path: path, filename: filename, file: file.ToString());
                        Menu.ShowMenu();
                        break;
                    }
                case 2: Console.WriteLine("Ok"); break;
                default: Viewer.Show(file.ToString()); break;

            }
        }

        public static void SaveFile(string path, string filename, string file)
        {
            string completePath = path + "/" + filename;
            using (var newFile = new StreamWriter(completePath))
            {
                newFile.Write(file);
            }
        }

        public static void OpenFile(string path)
        {
            using (var openFile = new StreamReader(path))
            {
                Console.Write("\n");
                Console.WriteLine(openFile.ReadToEnd());
                Console.Write("\n");
            }

            Console.ReadKey();
            Menu.ShowMenu();
        }
    }
}