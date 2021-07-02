using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> countingChars = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    continue;
                }
                else if (!countingChars.ContainsKey(text[i]))
                {
                    countingChars[text[i]] = 0;
                }

                countingChars[text[i]]++;
            }

            foreach (var kvp in countingChars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
