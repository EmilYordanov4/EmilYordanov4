using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<one>=|\/)(?<country>[A-Z][A-Za-z]{2,})\1";

            List<string> countries = new List<string>();

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            int points = 0;

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;

                string country = groups[2].Value;

                countries.Add(country);
                points += country.Length;
            }

            Console.Write($"Destinations: ");
            if (countries.Count == 0)
            {

            }
            else
            {
                Console.Write($"{countries[0]}");
                for (int i = 1; i < countries.Count; i++)
                {
                    Console.Write($", {countries[i]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
