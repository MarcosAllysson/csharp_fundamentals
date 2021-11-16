/*
Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.
*/

using System;

namespace Sequential.ListOfProgramns
{
    public static class Six
    {
        public static void CalculateCircleArea()
        {
            Console.WriteLine("Inform a ray: ");

            try
            {
                double ray = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(ray, 2);

                Console.WriteLine($"Area = {area.ToString(".#")}cm2.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Inform a valid number.");
            }
        }
    }
}