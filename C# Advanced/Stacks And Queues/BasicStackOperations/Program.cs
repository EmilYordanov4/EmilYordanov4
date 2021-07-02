using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = info[0];
            int s = info[1];
            int x = info[2];

            int[] stackNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(stackNumbers[i]);
            }
            for (int j = 0; j < s; j++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }
            if (stack.Contains(x))
            {
                Console.WriteLine($"true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
