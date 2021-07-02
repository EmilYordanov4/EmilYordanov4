using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> countOfOccurrences = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                if (!countOfOccurrences.ContainsKey(word))
                {
                    countOfOccurrences.Add(word, 1);
                }
                else
                {
                    countOfOccurrences[word]++;
                }
            }
            foreach (var item in countOfOccurrences)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key.ToLower()} ");
                }
            }
        }
    }
}
