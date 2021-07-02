using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> manipulatedList = Console.ReadLine().Split().ToList();
            List<string> input = Console.ReadLine().Split().ToList();

            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "Add":
                        manipulatedList.Add(input[1]);
                        break;
                    case "Remove":
                        manipulatedList.Remove(input[1]);
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(input[1]);
                        manipulatedList.RemoveAt(removeAt);
                        break;
                    case "Insert":
                        int index = int.Parse(input[2]);
                        manipulatedList.Insert(index, input[1]);
                        break;
                }
                input = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", manipulatedList));
        }
    }
}
