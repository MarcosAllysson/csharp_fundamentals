/*
Faça um Programa que peça dois números e imprima a soma.
*/

using System;

namespace Sequential
{
    public static class Three
    {
        public static void AskTwoNumbers()
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("The second number now: ");
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine($"So, {firstNumber} + {secondNumber} = {SumTwoNumbers(firstNumber, secondNumber)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only valid number.");
            }
        }

        private static int SumTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}