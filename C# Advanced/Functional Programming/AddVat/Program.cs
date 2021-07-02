using System;
using System.Linq;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => decimal.Parse(x) * 1.20M)
                .ToArray();

            foreach (var item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
