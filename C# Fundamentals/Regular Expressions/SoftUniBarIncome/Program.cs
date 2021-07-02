using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<buyer>[A-Z]{1}[a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[0-9]+)\|[^|$%.]*?(?<price>[0-9]+\.*[0-9]*)\$";

            decimal sum = 0;

            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string buyer = match.Groups["buyer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal totalPrice = quantity * price;
                    if (totalPrice > 0)
                    {
                        sum += totalPrice;
                        Console.WriteLine($"{buyer}: {product} - {totalPrice:f2}");

                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
