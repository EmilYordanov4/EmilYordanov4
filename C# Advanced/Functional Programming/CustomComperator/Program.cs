using System;
using System.Linq;

namespace CustomComperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Array.Sort(numbers, (x,y) => 
            {
                if (Math.Abs(x) % 2 == 0 && Math.Abs(y) % 2 == 1)
                    return -1;
                else if (Math.Abs(x) % 2 == 1 && Math.Abs(y) % 2 == 0)
                    return 1;
                else
                    return x.CompareTo(y);
            });

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
