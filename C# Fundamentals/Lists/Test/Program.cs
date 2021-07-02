using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        { 
            // 1 2 3 4 5 6
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Insert(3, 6);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
