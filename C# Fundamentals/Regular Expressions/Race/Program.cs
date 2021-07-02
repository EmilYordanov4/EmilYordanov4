using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> winners = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string patternForName = @"([A-Za-z])";
            string patternForKm = @"([0-9])";
            string encryptedInfo = Console.ReadLine();
            while (encryptedInfo != "end of race")
            {
                int sumOfKm = 0;
                MatchCollection letters = Regex.Matches(encryptedInfo, patternForName);
                StringBuilder name = new StringBuilder();
                for (int i = 0; i < letters.Count; i++)
                {
                    name.Append(letters[i]);
                }

                if (winners.Contains(name.ToString()))
                {
                    MatchCollection digits = Regex.Matches(encryptedInfo, patternForKm);
                    for (int i = 0; i < digits.Count; i++)
                    {
                        sumOfKm += int.Parse(digits[i].ToString());
                    }

                    if (!racers.ContainsKey(name.ToString()))
                    {
                        racers.Add(name.ToString(), sumOfKm);
                    }
                    else
                    {
                        racers[name.ToString()] += sumOfKm;
                    }
                }

                encryptedInfo = Console.ReadLine();
            }
            racers = racers.OrderByDescending(x => x.Value).Take(3).ToDictionary(a => a.Key, b => b.Value);

            int place = 0;
            foreach (var item in racers)
            {
                if (place == 0)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (place == 1)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                place++;
            }
        }
    }
}
