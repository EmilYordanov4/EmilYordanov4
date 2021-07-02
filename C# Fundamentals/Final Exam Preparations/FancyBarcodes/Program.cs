using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainPattern = @"@[#]{1,}(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@[#]{1,}";
            string digitPattern = @"(?<number>[\d])";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, mainPattern);

                if (match.Success)
                {
                    string barcode = match.Groups["barcode"].Value;

                    MatchCollection matches = Regex.Matches(barcode, digitPattern);

                    string digits = string.Empty;

                    foreach (Match digit in matches)
                    {
                        digits += digit;
                    }
                    if (digits.Length == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {digits}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid barcode");
                }

            }
        }
    }
}
