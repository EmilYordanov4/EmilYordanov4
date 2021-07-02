using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hatInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] scarfInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> sets = new List<int>();

            Stack<int> hats = new Stack<int>(hatInput);
            Queue<int> scarfs = new Queue<int>(scarfInput);

            while (hats.Count != 0 && scarfs.Count != 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if (hat > scarf)
                {
                    int set = scarf + hat;
                    sets.Add(set);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (scarf > hat)
                {
                    hats.Pop();
                }
                else if (scarf == hat)
                {
                    scarfs.Dequeue();
                    int count = hats.Count;
                    for (int i = 0; i < count; i++)
                    {
                        int temp = hats.Pop();
                        if (i == 0)
                        {
                            temp++;
                        }
                        hats.Push(temp);
                    }
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine($"{string.Join(" ", sets)}");
        }
    }
}
