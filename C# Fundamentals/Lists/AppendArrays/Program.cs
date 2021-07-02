using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            numbers.Reverse();

            string list = string.Join("|", numbers);

            List<string> finalList = list.Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            string finalString = string.Join(" ", finalList);

            List<string> finallyDone = finalString.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine(string.Join(" ", finallyDone));
        }
    }
}
