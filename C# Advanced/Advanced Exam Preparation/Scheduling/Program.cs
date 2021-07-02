using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputOne = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> tasks = new Stack<int>(inputOne);
            Queue<int> threads = new Queue<int>(inputTwo);

            int taskToKill = int.Parse(Console.ReadLine());

            while (tasks.Count > 0 && threads.Count > 0)
            {
                int thread = threads.Peek();
                int task = tasks.Peek();

                if (task == taskToKill)
                {
                    Console.WriteLine($"Thread with value {thread} killed task {taskToKill}");

                    break;
                }
                if (thread >= task)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine(string.Join(" ", threads));

        }
    }
}
