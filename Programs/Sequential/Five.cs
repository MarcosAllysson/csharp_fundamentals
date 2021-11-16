/*
Faça um Programa que converta metros para centímetros.
*/
using System;

namespace Sequential
{
    public static class Five
    {
        public static void ConvertMetersToCentimeters()
        {
            Console.WriteLine("Meters: ");

            try
            {
                float meters = float.Parse(Console.ReadLine());
                float convertedMeterToCm = meters * 100;
                Console.WriteLine($"From {meters}m to cm = {convertedMeterToCm}cm.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Inform a valid number.");
            }
            catch (Exception err)
            {
                Console.WriteLine($"I got an error: {err}.");
            }
        }
    }
}