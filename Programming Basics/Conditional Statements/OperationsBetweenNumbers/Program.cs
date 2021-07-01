using System;
using System.Diagnostics.CodeAnalysis;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double sum = 0;

            if ((symbol == "/" || symbol == "%") && numberOne == 0)
            {
                Console.WriteLine($"Cannot divide {numberTwo} by zero");
            }
            else if ((symbol == "/" || symbol == "%") && numberTwo == 0)
            {
                Console.WriteLine($"Cannot divide {numberOne} by zero");
            }
            else if (symbol == "+")
            {
                sum = numberOne + numberTwo;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {sum} - even");
                }
                else if (sum % 2 != 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {sum} - odd");
                }
            }
            else if (symbol == "-")
            {
                sum = numberOne - numberTwo;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {sum} - even");
                }
                else if (sum % 2 != 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {sum} - odd");
                }
            }
            else if (symbol == "*")
            {
                sum = numberOne * numberTwo;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {sum} - even");
                }
                else if (sum % 2 != 0)
                {
                    Console.WriteLine($"{numberOne} {symbol} {numberTwo} = {sum} - odd");
                }
            }
            else if (symbol == "/")
            {
                Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo:F2}");
            }
            else if (symbol == "%")
            {
                sum = numberOne % numberTwo;
                Console.WriteLine($"{numberOne} % {numberTwo} = {sum}");
            }
        }
    }
}
