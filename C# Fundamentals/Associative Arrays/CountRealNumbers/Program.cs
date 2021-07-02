using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray(); 
            SortedDictionary<double, int> numberOfOccurrences = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numberOfOccurrences.ContainsKey(numbers[i]))
                {
                    numberOfOccurrences.Add(numbers[i],1);
                }
                else
                {
                    numberOfOccurrences[numbers[i]]++;
                }
            }

            foreach (var item in numberOfOccurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
