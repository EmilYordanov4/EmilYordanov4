using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            DecidingGoingOrNot(numberOfCommands, names);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        private static void DecidingGoingOrNot(int numberOfCommands, List<string> names)
        {
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> input = Console.ReadLine().Split(" ", 2).ToList();

                if (input[1] == "is going!")
                {
                    IsGoing(names, input);
                }
                else if (input[1] == "is not going!")
                {
                    IsNotGoing(names, input);
                }
            }
        }

        private static void IsNotGoing(List<string> names, List<string> input)
        {
            bool isNotInTheList = true;
            for (int j = 0; j < names.Count; j++)
            {
                if (input[0] == names[j])
                {
                    isNotInTheList = false;
                    names.RemoveAt(j);
                    break;
                }
                else
                {
                    isNotInTheList = true;
                }
            }
            if (isNotInTheList == true)
            {
                Console.WriteLine($"{input[0]} is not in the list!");
            }
        }

        private static void IsGoing(List<string> names, List<string> input)
        {
            bool ifInTheList = false;

            for (int j = 0; j < names.Count; j++)
            {
                if (input[0] == names[j])
                {
                    Console.WriteLine($"{input[0]} is already in the list!");
                    ifInTheList = true;
                    break;
                }
            }
            if (ifInTheList == false)
            {
                names.Add(input[0]);
            }
        }
    }
}
