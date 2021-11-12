using System;
using System.Globalization;

namespace FormatingMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // decimal money = 10.00m;
            // Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

            // decimal value = 12312.12m;
            // Console.WriteLine(Math.Round(value));
            // Console.WriteLine(Math.Ceiling(value));
            // Console.WriteLine(Math.Floor(value));

            Console.WriteLine(Math.Max(12312, 123231));
            Console.WriteLine(Math.Min(123, 3232));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(2));

        }
    }
}
