using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rs = new Regex(@"\+359( |-)2\1[\d]{3}\1[\d]{4}\b");

            MatchCollection allMatches = rs.Matches(input);
            List<string> output = new List<string>();
            foreach (Match match in allMatches)
            {
                output.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
