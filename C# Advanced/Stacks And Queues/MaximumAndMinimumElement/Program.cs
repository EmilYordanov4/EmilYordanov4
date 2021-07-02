using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int cmd = info[0];

                if (cmd == 1)
                {
                    int number = info[1];
                    stackOfNumbers.Push(number);

                }
                else if (cmd == 2)
                {
                    if (stackOfNumbers.Any())
                    {
                        stackOfNumbers.Pop();
                    }
                }
                else if (cmd == 3)
                {
                    if (stackOfNumbers.Any())
                    {
                        Console.WriteLine(stackOfNumbers.Max());
                    }
                }
                else if (cmd == 4)
                {
                    if (stackOfNumbers.Any())
                    {
                        Console.WriteLine(stackOfNumbers.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stackOfNumbers));
        }
    }
}
