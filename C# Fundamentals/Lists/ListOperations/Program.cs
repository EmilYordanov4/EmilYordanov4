using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split().ToList();
            string input = commands[0];

            while (input != "End")
            {
                if (input == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                }
                else if (input == "Insert")
                {
                    if (int.Parse(commands[2]) < numbers.Count && int.Parse(commands[2]) >= 0)
                    {
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));

                    }
                    else
                    {
                        Console.WriteLine($"Invalid index");
                    }
                }
                else if (input == "Remove")
                {
                    if (int.Parse(commands[1]) < numbers.Count && int.Parse(commands[1]) >= 0)
                    {
                        numbers.RemoveAt(int.Parse(commands[1]));
                    }
                    else
                    {
                        Console.WriteLine($"Invalid index");
                    }
                }
                else if (input == "Shift")
                {
                    if (commands[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(commands[2]); i++)
                        {
                            numbers.Insert(numbers.Count, numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (commands[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(commands[2]); i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
                commands = Console.ReadLine().Split().ToList();
                input = commands[0];
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
//3 5 12 42 95 32 8 1
//1 3 5 12 42 95 32 8
