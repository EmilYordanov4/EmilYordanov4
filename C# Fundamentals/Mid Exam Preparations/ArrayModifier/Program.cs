using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            string[] input = Console.ReadLine().Split();


            while (input[0] != "end")
            {
                string command = input[0];

                if (command == "swap")
                {
                    Swap(arr, input);
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(input[1]);
                    int secondIndex = int.Parse(input[2]);

                    arr[firstIndex] *= arr[secondIndex];
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < arr.Count; i++)
                    {
                        arr[i]--;
                    }
                }


                input = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void Swap(List<int> arr, string[] input)
        {
            int firstIndex = int.Parse(input[1]);
            int secondIndex = int.Parse(input[2]);

            int temp = arr[firstIndex];
            arr.Insert(firstIndex, arr[secondIndex]);
            arr.RemoveAt(firstIndex + 1);
            arr.Insert(secondIndex, temp);
            arr.RemoveAt(secondIndex + 1);
        }
    }
}
