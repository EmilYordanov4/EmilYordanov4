using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            string input = command[0];

            while (input != "end")
            {
                Functions(list, command, input);

                command = Console.ReadLine().Split().ToList();
                input = command[0];
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static void Functions(List<int> list, List<string> command, string input)
        {
            if (input == "Delete")
            {
                Remove(list, command);
            }
            else if (input == "Insert")
            {
                Insert(list, command);
            }
        }

        private static void Remove(List<int> list, List<string> command)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == int.Parse(command[1]))
                {
                    list.RemoveAt(i);
                }
            }
        }

        private static void Insert(List<int> list, List<string> command)
        {
            int element = int.Parse(command[1]);
            int index = int.Parse(command[2]);
            list.Insert(index, element);
        }
    }
}
