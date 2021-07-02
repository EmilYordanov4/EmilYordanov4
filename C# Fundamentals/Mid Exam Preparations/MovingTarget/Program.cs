using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] cmd = Console.ReadLine().Split(" ");

            while (cmd[0] != "End")
            {
                int index = int.Parse(cmd[1]);
                int value = int.Parse(cmd[2]);
               
                if (cmd[0] == "Shoot")
                {
                    Shoot(targets, index, value);
                }
                else if (cmd[0] == "Add")
                {
                    Add(targets, index, value);
                }
                else if (cmd[0] == "Strike")
                {
                    if (index - value < 0 || index + value > targets.Count - 1)
                    {
                        Console.WriteLine($"Strike missed!");
                        cmd = Console.ReadLine().Split(" ");
                        continue;
                    }
                    else
                    {
                        for (int i = index; i < index + value; i++)
                        {
                            targets.RemoveAt(index);
                        }
                        for (int i = index; i >= index - value; i--)
                        {
                            targets.RemoveAt(i);

                        }
                    }
                }
                cmd = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join("|", targets));
        }

        private static void Add(List<int> targets, int index, int value)
        {
            if (index < 0 || index > targets.Count - 1)
            {
                Console.WriteLine($"Invalid placement!");
            }
            else
            {
                targets.Insert(index, value);
            }
        }

        private static void Shoot(List<int> targets, int index, int value)
        {
            if (index < 0 || index > targets.Count - 1)
            {

            }
            else if (targets[index] - value <= 0)
            {
                targets.RemoveAt(index);
            }
            else
            {
                targets[index] -= value;
            }
        }
    }
}
