using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] items = input[1].Split(",");

                for (int j = 0; j < items.Length; j++)
                {

                    if (!clothes.ContainsKey(color))
                    {
                        clothes[color] = new Dictionary<string, int>();
                    }
                    if (!clothes[color].ContainsKey(items[j]))
                    {
                        clothes[color][items[j]] = 0;
                    }
                    clothes[color][items[j]]++;
                }
            }

            string[] neededItems = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorNeeded = neededItems[0];
            string clothNeeded = neededItems[1];

            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");
                    if (item.Key == colorNeeded && cloth.Key == clothNeeded)
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
