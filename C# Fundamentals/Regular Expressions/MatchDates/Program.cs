using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rs = new Regex(@"\b(?<day>[\d]{2})(.)(?<month>[\w]{3})(\1)(?<year>[\d]{4})\b");

            MatchCollection result = rs.Matches(input);

            foreach (Match match in result)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
