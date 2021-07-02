using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathForWords = Path.Combine("data", "words.txt");
            var pathForText = Path.Combine("data", "text.txt");

            var dest = Path.Combine("data", "output.txt");

            string[] words = File.ReadAllText(pathForWords).Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> counter = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                counter.Add(words[i], 0);
            }

            string text = File.ReadAllText(pathForText);

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

            File.WriteAllLines(dest, outputInfo);
            
        }
    }
}
