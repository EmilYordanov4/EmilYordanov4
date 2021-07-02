using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> startingNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            long sum = 0;

            while (startingNumbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int valueOfRemovedElement = 0;
                if (index < 0)
                {
                    index = 0;
                }
                if (index > startingNumbers.Count - 1)
                {
                    valueOfRemovedElement = startingNumbers[startingNumbers.Count - 1];
                    startingNumbers.Insert(startingNumbers.Count - 1, startingNumbers[0]);
                    startingNumbers.RemoveAt(startingNumbers.Count - 1);
                    index = startingNumbers.Count - 1;
                }
                else
                {
                    valueOfRemovedElement = startingNumbers[index];
                    startingNumbers.RemoveAt(index);
                }
                sum += valueOfRemovedElement;
                for (int i = 0; i < startingNumbers.Count; i++)
                {
                    if (valueOfRemovedElement >= startingNumbers[i])
                    {
                        startingNumbers[i] += valueOfRemovedElement;
                    }
                    else if (valueOfRemovedElement < startingNumbers[i])
                    {
                        startingNumbers[i] -= valueOfRemovedElement;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
