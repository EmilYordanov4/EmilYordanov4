using System;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\*|@{1})([A-Z][a-z]{2,})\1: \[([A-z]{1})\]\|\[([A-z]{1})\]\|\[([A-z]{1})\]\|$";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    GroupCollection groups = match.Groups;

                    string name = groups[2].Value;
                    char lettterOne = char.Parse(groups[3].Value);
                    char lettterTwo = char.Parse(groups[4].Value);
                    char lettterThree = char.Parse(groups[5].Value);

                    int letterOneInt = lettterOne;
                    int letterTwoInt = lettterTwo;
                    int letterThreeInt = lettterThree;

                    Console.WriteLine($"{name}: {letterOneInt} {letterTwoInt} {letterThreeInt}");
                }
                else
                {
                    Console.WriteLine($"Valid message not found!");
                }
            }
        }
    }
}
