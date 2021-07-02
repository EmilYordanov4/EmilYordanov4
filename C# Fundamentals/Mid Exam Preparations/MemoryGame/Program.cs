using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> twins = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberOfMoves = 0;
            string match = Console.ReadLine();
            while (match != "end" && twins.Count != 0)
            {
                numberOfMoves++;
                string[] matches = match.Split(" ");
                int indexOne = int.Parse(matches[0]);
                int indexTwo = int.Parse(matches[1]);
                if (indexOne < 0 || indexOne >= twins.Count)
                {
                    twins.Insert(twins.Count/2, $"-{numberOfMoves}a");
                    twins.Insert(twins.Count/2, $"-{numberOfMoves}a");
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    match = Console.ReadLine();
                    continue;
                }
                if (indexTwo < 0 || indexTwo >= twins.Count)
                {
                    twins.Insert(twins.Count / 2, $"-{numberOfMoves}a");
                    twins.Insert(twins.Count / 2, $"-{numberOfMoves}a");
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    match = Console.ReadLine();
                    continue;
                }
                if (twins[indexOne] == twins[indexTwo])
                {
                    CorrectGuess(twins, indexOne);
                }
                else if (twins[indexOne] != twins[indexTwo])
                {
                    Console.WriteLine($"Try again!");
                }

                match = Console.ReadLine();
            }

            if (twins.Count == 0)
            {
                Console.WriteLine($"You have won in {numberOfMoves} turns!");
            }
            else
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", twins));
            }
        }

        private static void CorrectGuess(List<string> twins, int indexOne)
        {
            int count = 0;
            Console.WriteLine($"Congrats! You have found matching elements - {twins[indexOne]}!");
            string elementNeeded = twins[indexOne];
            for (int i = 0; i < twins.Count; i++)
            {
                if (count == 2)
                {
                    break;
                }
                if (twins[i] == elementNeeded )
                {
                    count++;
                    twins.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
