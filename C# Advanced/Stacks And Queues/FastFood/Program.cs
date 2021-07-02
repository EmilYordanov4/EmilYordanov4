using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> allOrders = new Queue<int>(orders);

            Console.WriteLine(allOrders.Max());
            while (allOrders.Count >= 1)
            {
                int order = allOrders.Peek();
                if (foodQuantity >= order)
                {
                    foodQuantity -= order;
                    allOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (allOrders.Count == 0)
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", allOrders)}");
            }
        }
    }
}
