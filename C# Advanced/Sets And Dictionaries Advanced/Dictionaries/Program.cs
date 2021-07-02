using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> counter = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!counter.ContainsKey(input[i]))
                {
                    counter[input[i]] = 0;
                }
                counter[input[i]]++;
            }


            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
