using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathForLines = "text.txt";
            string pathForWords = "words.txt";
            string output = "expectedResult.txt";
            string[] words = File.ReadAllLines(pathForWords);

            Dictionary<string, int> counter = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                counter.Add(words[i], 0);
            }

            string text = File.ReadAllText(pathForLines);

            string pattern = @"\w+[']*\w*";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                if (counter.ContainsKey(item.ToString().ToLower()))
                {
                    counter[item.ToString().ToLower()]++;
                }
            }

            counter = counter.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, b => b.Value);
            string[] outputInfo = new string[counter.Count];
            int count = 0;
            foreach (var item in counter)
            {
                outputInfo[count] = $"{item.Key} - {item.Value}";
                count++;
            }
            File.WriteAllLines(output, outputInfo);
        }
    }
}
