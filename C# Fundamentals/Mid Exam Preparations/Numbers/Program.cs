using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            List<int> biggerNumbers = new List<int>();
            double average = numbers.Average();

            numbers = numbers.OrderByDescending(x => x).ToList();
            int count = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    count++;
                    biggerNumbers.Add(numbers[i]);
                    if (count >= 5)
                    {
                        break;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", biggerNumbers));
            }
        }
    }
}
