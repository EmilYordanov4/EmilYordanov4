using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            long numbers = long.Parse(Console.ReadLine());

            long firstNumber = 0;
            long secondNumber = 0;

            long sumFirst = 0;
            long sumSecond = 0;

            for (int i = 0; i < numbers; i++)
            {
                string input = Console.ReadLine();

                string[] number = Regex.Split(input, @"\D+");
                foreach (string value in number)
                {
                    if (!string.IsNullOrEmpty(value))
                    {   
                        firstNumber = secondNumber;
                        secondNumber = long.Parse(value);
                    }
                }
                while (firstNumber != 0)
                {
                    sumFirst += firstNumber % 10;
                    firstNumber /= 10;
                }
                while (secondNumber != 0)
                {
                    sumSecond += secondNumber % 10;
                    secondNumber /= 10;
                }
                if (sumFirst >= sumSecond)
                {
                    Console.WriteLine(sumFirst);
                }
                else
                {
                    Console.WriteLine(sumSecond);
                }
                sumFirst = 0;
                sumSecond = 0;
            }
        }
    }
}
