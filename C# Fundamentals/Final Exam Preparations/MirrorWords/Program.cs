using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<group>[@||#]{1})(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Za-z]{3,})\1";

            List<string> matchedWords = new List<string>();
            int countOfPairs = 0;
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                countOfPairs++;
                string wordOne = groups[2].Value;
                string wordTwo = groups[3].Value;

                char[] wordTwoAsChars = wordTwo.ToCharArray();
                Array.Reverse(wordTwoAsChars);
                wordTwo = string.Join("", wordTwoAsChars);
                
                if (wordOne == wordTwo)
                {
                    matchedWords.Add(wordOne);
                }
            }

            if (countOfPairs == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{countOfPairs} word pairs found!");
            }
            if (matchedWords.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");

                string wordOne = matchedWords[0];
                char[] wordAsChars = wordOne.ToCharArray();
                Array.Reverse(wordAsChars);
                string wordTwo = string.Join("",wordAsChars);
                Console.Write($"{wordOne} <=> {wordTwo}");

                for (int i = 1; i < matchedWords.Count; i++)
                {
                    wordOne = matchedWords[i];
                    wordAsChars = wordOne.ToCharArray();
                    Array.Reverse(wordAsChars);
                    wordTwo = string.Join("", wordAsChars);
                    Console.Write($", {wordOne} <=> {wordTwo}");
                }
            }
        }
    }
}
