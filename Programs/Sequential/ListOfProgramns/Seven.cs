/*
Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.
*/

using System;

namespace Sequential.ListOfProgramns
{
    public static class Seven
    {
        public static void AreaSquare()
        {
            Console.WriteLine("Inform a side of the square: ");

            try
            {
                float sideSquare = float.Parse(Console.ReadLine());
                float resultSideSquare = sideSquare * sideSquare;
                float doubleSquareArea = (float)Math.Pow(resultSideSquare, 2);

                Console.WriteLine($"Square area: {resultSideSquare.ToString(".##")}. \nDouble of this area: {doubleSquareArea.ToString(".##")}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid square value.");
            }
        }
    }
}