using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> manipulatedList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> input = Console.ReadLine().Split().ToList();
            List<int> startingList = new List<int>();
            for (int i = 0; i < manipulatedList.Count; i++)
            {
                startingList.Add(manipulatedList[i]);
            }
            string command = input[0];

            while (command != "end")
            {
                switch (command)
                {
                    case "Add":
                        manipulatedList.Add(int.Parse(input[1]));
                        break;
                    case "Remove":
                        manipulatedList.Remove(int.Parse(input[1]));
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(input[1]);
                        manipulatedList.RemoveAt(removeAt);
                        break;
                    case "Insert":
                        int index = int.Parse(input[2]);
                        manipulatedList.Insert(index, int.Parse(input[1]));
                        break;
                    case "Contains":
                        ContainingNumber(manipulatedList, int.Parse(input[1]));
                        break;
                    case "PrintEven":
                    case "PrintOdd":
                        PrintingEvenOrOddNumbers(command, manipulatedList);
                        break;
                    case "GetSum":
                        Console.WriteLine(manipulatedList.Sum());
                        break;
                    case "Filter":
                        FilteringNumbers(manipulatedList, input[1], int.Parse(input[2]));
                        break;
                }
                input = Console.ReadLine().Split().ToList();
                command = input[0];
            }
            if (manipulatedList.Sum() == startingList.Sum())
            {

            }
            else
            {
                Console.WriteLine(string.Join(" ", manipulatedList));
            }
        }

        static void ContainingNumber(List<int> list, int number)
        {
            if (list.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintingEvenOrOddNumbers(string command, List<int> list)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    evenNumbers.Add(list[i]);
                }
                else
                {
                    oddNumbers.Add(list[i]);
                }
            }
            if (command == "PrintEven")
            {
                Console.WriteLine(string.Join(" ", evenNumbers));
            }
            else
            {
                Console.WriteLine(string.Join(" ", oddNumbers));
            }
        }

        static void FilteringNumbers(List<int> list, string condition, int number)
        {
            List<int> filteredList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                switch (condition)
                {
                    case ">":
                        if (list[i] > number)
                        {
                            filteredList.Add(list[i]);
                        }
                        break;
                    case "<":
                        if (list[i] < number)
                        {
                            filteredList.Add(list[i]);
                        }
                        break;
                    case ">=":
                        if (list[i] >= number)
                        {
                            filteredList.Add(list[i]);
                        }
                        break;
                    case "<=":
                        if (list[i] <= number)
                        {
                            filteredList.Add(list[i]);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", filteredList));
        }
    }
}
