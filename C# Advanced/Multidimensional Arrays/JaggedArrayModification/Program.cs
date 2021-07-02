using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int info = int.Parse(Console.ReadLine());
            int[][] jagged = new int[info][];

            for (int row = 0; row < info; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string[] tokens = Console.ReadLine().Split();
            while (tokens[0] != "END")
            {
                int rows = int.Parse(tokens[1]);
                int cols = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (rows < 0 || rows >= jagged.Length || cols < 0 || cols >= jagged[rows].Length )
                {
                    Console.WriteLine($"Invalid coordinates");
                }
                else if (tokens[0] == "Add")
                {
                    jagged[rows][cols] += value;
                }
                else if (tokens[0] == "Subtract")
                {
                    jagged[rows][cols] -= value;
                }

                tokens = Console.ReadLine().Split();
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
