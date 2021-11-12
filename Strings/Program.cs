using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // GUIDS
            // var id = Guid.NewGuid();
            // id.ToString();
            // Console.WriteLine(id);

            // INTERPOLAÇÃO DE STRINGS:
            // var price = 10.2;
            // Console.WriteLine($"Price is: $" + price);


            // COMPARAÇÃO DE STRINGS:
            // var text = "Testing";
            // Console.WriteLine(text.CompareTo("testing"));
            // Console.WriteLine(text.Contains("testing"));
            // Console.WriteLine(text.Contains("testing", StringComparison.OrdinalIgnoreCase));


            // STARTSWITH/ENDSWITH:
            // var text = "Marcos Allysson";
            // Console.WriteLine(text.ToUpper().StartsWith("M"));
            // Console.WriteLine(text.ToUpper().EndsWith("N"));

            // EQUALS:
            // var text = "Marcos Allysson";
            // Console.WriteLine(text.Equals("Marcos Allysson"));

            // ÍNDICES:
            // var text = "Marcos Allysson";
            // var age = 24;
            // Console.WriteLine(text[0]);
            // Console.WriteLine(text.GetType());
            // Console.WriteLine(age.GetType());
            // Console.WriteLine(text.Insert(0, "n"));
            // Console.WriteLine(text.Replace("n", ""));
            // Console.WriteLine(text.Split(" "));

            // MÉTODOS ADICIONAIS:
            // var text = "Marcos Allysson";
            // Console.WriteLine(text.ToLower());
            // Console.WriteLine(text.ToUpper());


            // MANIPULANDO STRING:
            // var text = " Marcos Allysson ";
            // Console.WriteLine(text.Replace(" ", " - "));

            // var division = text.Split(" ");
            // for (var i = 0; i < division.Length; i++)
            // {
            //     Console.WriteLine($"{i} - {division[i]}");
            // }

            // Console.WriteLine(text.Substring(4, 9));
            // Console.WriteLine(text.Trim());
            // Console.WriteLine(text.TrimStart());
            // Console.WriteLine(text.TrimEnd());


            // STRING BUILD:
            var text = new StringBuilder();
            text.Append("Marcos");
            text.Append("Allysson");
            Console.WriteLine(text);
        }
    }
}
