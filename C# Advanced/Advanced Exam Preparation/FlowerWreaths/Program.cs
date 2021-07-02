using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liliesInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] rosesInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> lilies = new Stack<int>(liliesInput);
            Queue<int> roses = new Queue<int>(rosesInput);

            int storedFlowers = 0;
            int wreaths = 0;
            while (lilies.Count != 0 && roses.Count != 0)
            {
                int lily = lilies.Peek();
                int rose = roses.Peek();

                int sum = lily + rose;

                if (sum == 15)
                {
                    wreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    List<int> temp = lilies.ToList();
                    temp[0] -= 2;
                    temp.Reverse();
                    lilies.Clear();
                    for (int i = 0; i < temp.Count; i++)
                    {
                        lilies.Push(temp[i]);
                    }
                }
                else if (sum < 15)
                {
                    storedFlowers += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            while (storedFlowers >= 15)
            {
                storedFlowers -= 15;
                wreaths++;
            }

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
