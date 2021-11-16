/*
Faça um Programa que peça as 4 notas bimestrais e mostre a média.
*/
using System;
using System.Collections.Generic;
using System.Threading;

namespace Sequential
{
    public static class Four
    {
        public static void AskFourGrades()
        {
            try
            {
                var userGrades = new List<double>();

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Inform {i + 1}° number: ");
                    double tempGrade = double.Parse(Console.ReadLine());
                    userGrades.Add(tempGrade);
                }

                Console.WriteLine("\nCalculating average...");
                Thread.Sleep(2000);
                Console.WriteLine($"The average of your grades is: {CalculateAverageGrade(userGrades)}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("I could not calculate your average. Enter only valid numbers.");
            }
        }

        private static double CalculateAverageGrade(List<double> numbers)
        {
            double totalSum = 0;
            double totalNumbers = 0;

            foreach (var number in numbers)
            {
                totalSum += number;
                totalNumbers += 1;
            }

            return totalSum / totalNumbers;
        }
    }

}