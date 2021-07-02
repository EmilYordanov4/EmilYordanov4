using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coolEmojies = new List<string>();
            string text = Console.ReadLine();

            string pattern = @"([:]{2}|[*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string patternForNumbers = @"(?<number>\d)";

            MatchCollection numbers = Regex.Matches(text, patternForNumbers);
            int threshold = 1;

            foreach (Match number in numbers)
            {
                threshold *= int.Parse(number.ToString());
            }

            MatchCollection emojies = Regex.Matches(text, pattern);

            foreach (Match emoji in emojies)
            {
                GroupCollection test = emoji.Groups;
                string testEmoji = test[2].Value;
                int sum = 0;
                for (int i = 0; i < testEmoji.Length; i++)
                {
                    sum += testEmoji[i];
                }
                if (sum > threshold)
                {
                    coolEmojies.Add(emoji.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {threshold}");

            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");

            foreach (string item in coolEmojies)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
