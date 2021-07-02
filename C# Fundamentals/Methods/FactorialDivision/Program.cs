using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstDigit = double.Parse(Console.ReadLine());
            double secondDigit = double.Parse(Console.ReadLine());

            firstDigit = CalculatingFactorial(firstDigit);
            secondDigit = CalculatingFactorial(secondDigit);

            Console.WriteLine($"{firstDigit / secondDigit:f2}");
        }

        static double CalculatingFactorial(double number) 
        {
            double factorialNumber = 1;
            for (double i = number; i >= 1; i--)
            {
                factorialNumber *= i;
            }
            return factorialNumber;
        }
    }
}
