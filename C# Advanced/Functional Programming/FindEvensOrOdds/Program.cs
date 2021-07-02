using System;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isNumberEvenOrOdd = n => n % 2 == 0;
            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string cmd = Console.ReadLine();

            int start = indexes[0];
            int end = indexes[1];

            if (cmd == "odd")
            {
                isNumberEvenOrOdd = n => n % 2 != 0;
            }

            for (int i = start; i <= end; i++)
            {
                if (isNumberEvenOrOdd(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
