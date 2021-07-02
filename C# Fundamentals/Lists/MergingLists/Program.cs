using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split().ToList();
            List<string> secondList = Console.ReadLine().Split().ToList();
            List<string> finalResult = new List<string>();

            int longestList = Math.Max(firstList.Count, secondList.Count);
            int shortestList = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < shortestList; i++)
            {
                finalResult.Add(firstList[i]);
                finalResult.Add(secondList[i]);
            }
            for (int i = 0; i < longestList - shortestList; i++)
            {
                if (firstList.Count > secondList.Count)
                {
                    finalResult.Add(firstList[shortestList + i]);
                }
                else
                {
                    finalResult.Add(secondList[shortestList + i]);
                }
            }
            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}
