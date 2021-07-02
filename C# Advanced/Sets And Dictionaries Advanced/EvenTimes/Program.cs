using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> counter = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (!counter.ContainsKey(input))
                {
                    counter[input] = 0;
                }
                counter[input]++;
            }
            foreach (var item in counter)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine($"{item.Key}");
                }
            }
        }
    }
}
