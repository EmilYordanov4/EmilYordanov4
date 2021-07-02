using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> pile = new Stack<int>(clothes);
            int capacityOfRack = int.Parse(Console.ReadLine());
            int currentBoxCapacity = capacityOfRack;
            int boxCount = 0;
            if (pile.Any())
            {
                boxCount = 1;
            }

            while (pile.Count != 0)
            {
                int currentClothes = pile.Peek();

                if (currentBoxCapacity >= currentClothes)
                {
                    currentBoxCapacity -= currentClothes;
                    pile.Pop();
                }
                else
                {
                    boxCount++;
                    currentBoxCapacity = capacityOfRack;
                }
            }

            Console.WriteLine(boxCount);
        }
    }
}
