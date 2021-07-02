using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> finalNumbers = new List<int>();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int sum = numbers[0 + i] + numbers[numbers.Count - i - 1];
                finalNumbers.Add(sum);
            }
            if (numbers.Count % 2 == 1)
            {
                finalNumbers.Add(numbers[numbers.Count/2]);
            }

            Console.WriteLine(string.Join(" ", finalNumbers));
        }
    }
}
