using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> calculatingChars = (s, i) =>
            {
                int sum = 0;
                foreach (char item in s)
                {
                    sum += item;
                }
                if (sum >= i)
                {
                    return true;
                }
                return false;
            };
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (string item in names)
            {
                if (calculatingChars(item, n))
                {
                    Console.WriteLine(item);
                    break;
                }
            }
        }
    }
}
