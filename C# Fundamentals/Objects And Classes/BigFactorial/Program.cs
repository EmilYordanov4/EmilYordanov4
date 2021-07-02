using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());

            BigInteger sum = 1;

            for (int i = 1; i <= startingNumber; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}
