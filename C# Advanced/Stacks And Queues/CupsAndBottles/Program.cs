using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] allBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int wastedWater = 0;

            Queue<int> cups = new Queue<int>(allCups);
            Stack<int> bottles = new Stack<int>(allBottles);

            while (cups.Count != 0 && bottles.Count != 0)
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Pop();

                currentCup -= currentBottle;
                if (currentCup <= 0)
                {
                    wastedWater += Math.Abs(currentCup);
                    cups.Dequeue();
                }
                else
                {
                    while (currentCup > 0)
                    {
                        currentBottle = bottles.Pop();

                        currentCup -= currentBottle;
                    }
                    if (currentCup <= 0)
                    {
                        wastedWater += Math.Abs(currentCup);
                        cups.Dequeue();
                    }
                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
