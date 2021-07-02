using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "End")
            {
                int index = int.Parse(input);
                if (index > targets.Length - 1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                int targetShot = targets[index];
                if (targets[index] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    else if (targetShot < targets[i])
                    {
                        targets[i] -= targetShot;
                    }
                    else
                    {
                        targets[i] += targetShot;
                    }
                }
                targets[index] = -1;
                input = Console.ReadLine();
            }
            int count = 0;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    count++;
                }
            }
            Console.WriteLine($"Shot targets: {count} -> {String.Join(" ", targets)}");
        }
    }
}
