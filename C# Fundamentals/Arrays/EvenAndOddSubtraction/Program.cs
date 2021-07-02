using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ').ToArray();

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int number = int.Parse(inputNumbers[i]);

                if (number % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }

            Console.WriteLine($"{sumEven - sumOdd}");
        }
    }
}
