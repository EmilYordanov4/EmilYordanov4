using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            char function = char.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            Calculate(numberOne, function, numberTwo);
        }

        static void Calculate(double numberOne, char function, double numberTwo)
        {
            if (function == '+')
            {
                Console.WriteLine(numberOne + numberTwo);
            }
            else if (function == '-')
            {
                Console.WriteLine(numberOne - numberTwo);
            }
            else if (function == '*')
            {
                Console.WriteLine($"{numberOne * numberTwo}");
            }
            else if (function == '/')
            {
                Console.WriteLine($"{numberOne / numberTwo}");
            }
        }
    }
}