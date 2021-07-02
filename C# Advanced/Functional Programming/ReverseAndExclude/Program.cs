using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int diviser = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ",numbers.Where(x => x % diviser != 0).Reverse().ToList()));
        }
    }
}
