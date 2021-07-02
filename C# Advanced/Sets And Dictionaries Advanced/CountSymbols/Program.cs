using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            SortedDictionary<char, int> counter = new SortedDictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (!counter.ContainsKey(word[i]))
                {
                    counter[word[i]] = 0;
                }
                counter[word[i]]++;
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
