using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputOne = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> ingredients = new Queue<int>(inputOne);
            Stack<int> freshnessLevels = new Stack<int>(inputTwo);

            Dictionary<int, string> dishes = new Dictionary<int, string>()
            {
                {150, "Dipping sauce"},
                {250, "Green salad"},
                {300, "Chocolate cake"},
                {400, "Lobster"}
            };

            Dictionary<string, int> cookedDishes = new Dictionary<string, int>();


            while (ingredients.Count > 0 && freshnessLevels.Count > 0)
            {
                int ingredient = ingredients.Peek();
                int freshnessLevel = freshnessLevels.Peek();

                if (ingredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int sum = ingredient * freshnessLevel;

                if (dishes.ContainsKey(sum))
                {
                    if (!cookedDishes.ContainsKey(dishes[sum]))
                    {
                        cookedDishes[dishes[sum]] = 0;
                    }
                    cookedDishes[dishes[sum]]++;
                    ingredients.Dequeue();
                    freshnessLevels.Pop();
                }
                else
                {
                    freshnessLevels.Pop();
                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                }
            }

            if (cookedDishes.Count == 4)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine("Ingredients left: " + ingredients.Sum());
            }

            foreach (var item in cookedDishes.OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {item.Key} --> {item.Value}");
            }
        }
    }
}
