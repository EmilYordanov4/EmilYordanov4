using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputOne = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> liquids = new Queue<int>(inputOne);
            Stack<int> ingredients = new Stack<int>(inputTwo);

            Dictionary<int, string> food = new Dictionary<int, string>()
            {
                { 25, "Bread" },
                { 50, "Cake" },
                { 75, "Pastry" },
                { 100, "Fruit Pie" },
            };

            Dictionary<string, int> foodCooked = new Dictionary<string, int>() 
            {
                {"Bread", 0 },
                {"Cake", 0 },
                {"Pastry", 0 },
                {"Fruit Pie" , 0 },
            };

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int liquid = liquids.Peek();
                int ingredient = ingredients.Peek();

                int sum = liquid + ingredient;

                if (food.ContainsKey(sum))
                {
                   
                    foodCooked[food[sum]]++;

                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Push(ingredients.Pop() + 3);
                }
            }

            if (!foodCooked.Any(x => x.Value == 0))
            {
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");
            }

            else
            {
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine($"Liquids left: none");
            }
            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine($"Ingredients left: none");
            }

            foreach (var item in foodCooked.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
