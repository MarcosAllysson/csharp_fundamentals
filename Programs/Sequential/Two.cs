/*
Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].
*/
using System;

namespace Sequential
{
    public static class Two
    {
        public static void AskForANumber()
        {
            try
            {
                Console.WriteLine("Type a number: ");
                short userNumber = short.Parse(Console.ReadLine());
                Console.WriteLine($"Your number is {userNumber}.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Enter a valid number.");
            }
        }
    }
}