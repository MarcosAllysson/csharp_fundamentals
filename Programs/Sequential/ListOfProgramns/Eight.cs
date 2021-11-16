/*
Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. 
Calcule e mostre o total do seu salário no referido mês.
*/

using System;
using System.Threading;

namespace Sequential.ListOfProgramns
{
    public static class Eight
    {
        public static void CalculateSalary()
        {
            try
            {
                Console.WriteLine("How much do you make per hour? ");
                var makePerHour = float.Parse(Console.ReadLine());

                Console.WriteLine("\nHow many hours do you work per month? ");
                var hoursPerMonth = int.Parse(Console.ReadLine());

                Console.Write('\n');
                Console.WriteLine("Calculating your salary...");
                Thread.Sleep(2000);

                var monthlySalary = makePerHour * hoursPerMonth;
                Console.WriteLine($@"You make R$ {makePerHour.ToString("#.##")} per hour, work {hoursPerMonth} hours per month. 
                So, you make R$ {monthlySalary.ToString(".##")} per month.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid time and or amount of money!");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Got an error: {err}. Try again");
            }
        }
    }
}