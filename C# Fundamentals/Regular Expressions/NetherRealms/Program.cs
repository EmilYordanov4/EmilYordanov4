using System;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<!\S)([A-Za-z]{1}[A-Za-z.\-_0-9]+)@([A-Za-z]{1}[A-Za-z.\-0-9]+\.+[A-Za-z]{1}[A-Za-z.\-0-9]+)(?<!\.)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"{match}");
            }
        }
    }
}
