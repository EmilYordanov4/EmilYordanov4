using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rs = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            MatchCollection matches = rs.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}
