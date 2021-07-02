using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList();

            products.ForEach(x => Console.WriteLine(x));
        }
    }
}
