using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> customMin = xArr =>
            {
                int min = int.MaxValue;

                foreach (int item in xArr)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            };

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(customMin(numbers));
        }
    }
}
