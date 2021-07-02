using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>[0-9]+\.*[0-9]*)!(?<quantity>\d+)";
            List<string> furniture = new List<string>();
            decimal sum = 0;
            string input = Console.ReadLine();
            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string item = match.Groups["furniture"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    sum += quantity * price;
                    furniture.Add(item);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");
            foreach (string item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
