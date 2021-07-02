using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            List<string> input = Console.ReadLine().Split().ToList();

            while (input[0] != "end")
            {
                AddingNewOrToExistingWagon(train, capacity, input);

                input = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", train));
        }

        private static void AddingNewOrToExistingWagon(List<int> train, int capacity, List<string> input)
        {
            if (input[0] == "Add")
            {
                train.Add(int.Parse(input[1]));
            }
            else
            {
                AddingToAnExistingWagon(train, capacity, input);
            }
        }

        private static void AddingToAnExistingWagon(List<int> train, int capacity, List<string> input)
        {
            for (int i = 0; i < train.Count; i++)
            {
                if (train[i] + int.Parse(input[0]) <= capacity)
                {
                    train[i] += int.Parse(input[0]);
                    break;
                }
            }
        }
    }
}
