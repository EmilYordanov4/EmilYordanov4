using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> startingList = Console.ReadLine().Split().ToList();
            List<string> input = Console.ReadLine().Split().ToList();

            while (input[0] != "3:1")
            {
                if (input[0] == "merge")
                {
                    startingList = MergingLists(startingList, input);
                }
                else if (input[0] == "divide")
                {
                    int index = int.Parse(input[1]);
                    int parts = int.Parse(input[2]);
                    string wordDividing = startingList[index];
                    int letterCount = 0;
                    string[] dividedWord = new string[parts];

                    for (int i = 0; i < parts; i++)
                    {
                        int count = wordDividing.Length / parts;
                        for (int j = 0; j < wordDividing.Length; j++)
                        {
                            count--;
                            dividedWord[i] += wordDividing[letterCount];
                            letterCount++;
                            if (count == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", startingList));
        }

        private static List<string> MergingLists(List<string> startingList, List<string> input)
        {
            List<string> mergedList = new List<string>();
            int start = int.Parse(input[1]);
            int end = int.Parse(input[2]);
            if (end > startingList.Count - 1)
            {
                end = startingList.Count - 1;
            }
            if (start < 0)
            {
                start = 0;
            }

            string merged = string.Empty;

            for (int i = start; i <= end; i++)
            {
                merged += startingList[i];
            }
            for (int i = end + 1; i < startingList.Count; i++)
            {
                if (start == i)
                {
                    mergedList.Add(merged);
                }
                else
                {

                    mergedList.Add(startingList[i]);
                }
            }
            if (mergedList[0] != "")
            {
                startingList = mergedList;

            }

            return startingList;
        }
    }
}
