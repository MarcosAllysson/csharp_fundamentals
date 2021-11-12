using System;

namespace LearningExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var array = new int[3];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(array[i]);
                }

                // Subscripate("");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Didnt find the index in the list.");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Something did not work -> {err}");
            }
            finally
            {
                Console.Write("\n");
                Console.WriteLine("End of program.");
            }
        }

        static void Subscripate(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                // throw new Exception("Text cannot be empty or null.");
                throw new ArgumentNullException("Text cannot be empty or null.");
            }
        }
    }
}
