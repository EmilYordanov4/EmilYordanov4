using System;
using System.Diagnostics.CodeAnalysis;

namespace Sequence2KPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 1;


            while (sum <= number)
            {

                if (number <= sum )
                {
                    Console.WriteLine(sum);
                    Environment.Exit(0);
                }
                
                Console.WriteLine(sum);
                sum = 2 * sum + 1;
                
            }
        }
    }
}
