using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split(" ").ToList();
            string[] input = Console.ReadLine().Split(" ");
            
            while (input[0] != "end")
            {
                string command = input[0];

                if (command == "reverse")
                {
                    int startingIndex = int.Parse(input[2]);
                    int count = int.Parse(input[4]);
                    int endingIndex = startingIndex + count - 1;
                    
                    for (int i = 0; i < count / 2; i++)
                    {
                        string startingInfo = array[startingIndex + i];
                        string endingInfo = array[endingIndex - i];
                        array.RemoveAt(startingIndex + i);
                        array.Insert(endingIndex - i, startingInfo);
                        array.RemoveAt(endingIndex - i - 1);
                        array.Insert(startingIndex + i, endingInfo);
                    }
                }
                else if (command == "sort")
                {
                    int startingIndex = int.Parse(input[2]);
                    int count = int.Parse(input[4]);
                    int endingIndex = startingIndex + count - 1;
                    
                    List<string> sortingList = new List<string>();

                    for (int i = startingIndex; i <= endingIndex; i++)
                    {
                        sortingList.Add(array[i]);
                    }
                    sortingList = sortingList.OrderBy(x => x).ToList();
                    int sortingListCount = 0;
                    for (int i = startingIndex; i <= endingIndex; i++)
                    {
                        array.RemoveAt(i);
                        array.Insert(i, sortingList[sortingListCount]);


                        sortingListCount++;
                    }
                }
                else if (command == "remove")
                {
                    int count = int.Parse(input[1]);
                    
                    for (int i = 0; i < count; i++)
                    {
                        array.RemoveAt(0);
                    }
                }
                input = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
