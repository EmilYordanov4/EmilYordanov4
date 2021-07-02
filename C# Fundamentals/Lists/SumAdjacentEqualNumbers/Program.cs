using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = i + 1;
                if (numbers.Count <= index)
                {
                    continue;
                }
                else if (numbers[i] == numbers[index])
                {
                    numbers[i] += numbers[index];
                    numbers.RemoveAt(index);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join( " ", numbers));
        }
    }
}
