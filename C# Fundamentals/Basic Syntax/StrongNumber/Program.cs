using System;
using System.Diagnostics.CodeAnalysis;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factNumber = 0;

            int sum = 1;
            int totalSum = 0;

            for (int i = number; i > 0; i = i / 10)
            {
                factNumber = i % 10;

                for (int j = 1; j <= factNumber ; j++)
                {
                    sum *= j;
                }
                totalSum += sum;
                sum = 1;    
            }
            if (totalSum == number)
            {
                Console.WriteLine("yes");

            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
