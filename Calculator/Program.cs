using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorMenu();
        }

        static void SumTwoNumbers()
        {
            Console.Clear();
            Console.WriteLine("First value: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Now, type the second value: ");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of {firstValue} + {secondValue} = {firstValue + secondValue}.");

            Console.ReadKey();
            CalculatorMenu();
        }

        static void SubTwoNumbers()
        {
            Console.Clear();
            Console.WriteLine("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Now, enter the second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine($"Difference of {firstNumber} - {secondNumber} = {firstNumber - secondNumber}.");

            Console.ReadKey();
            CalculatorMenu();
        }

        static void MultiplyTwoNumbers()
        {
            Console.Clear();
            Console.WriteLine("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}.");

            Console.ReadKey();
            CalculatorMenu();
        }

        static void DivisionTwoNumber()
        {
            Console.Clear();
            Console.WriteLine("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine($"Division of {firstNumber} / {secondNumber} = {firstNumber / secondNumber}.");

            Console.ReadKey();
            CalculatorMenu();
        }

        static void CalculatorMenu()
        {
            Console.Clear();
            Console.WriteLine("============ Calculator ============");
            Console.WriteLine();
            Console.WriteLine("Select your choice: ");
            Console.WriteLine("1 -> Sum");
            Console.WriteLine("2 -> Sub");
            Console.WriteLine("3 -> Mul");
            Console.WriteLine("4 -> Div");
            Console.WriteLine("0 -> END");
            Console.WriteLine("=====================================");
            Console.WriteLine("");

            int userChoice = int.Parse(Console.ReadLine());
            Console.Clear();
            HandleOperation(userChoice);
        }

        static void HandleOperation(int operationNumber)
        {
            switch (operationNumber)
            {
                case 1: SumTwoNumbers(); break;
                case 2: SubTwoNumbers(); break;
                case 3: MultiplyTwoNumbers(); break;
                case 4: DivisionTwoNumber(); break;
                case 0: break;
                // Another option to exit the execution.
                // case 5: System.Environment.Exit(0); break;
                default: CalculatorMenu(); break;
            }
        }
    }
}
