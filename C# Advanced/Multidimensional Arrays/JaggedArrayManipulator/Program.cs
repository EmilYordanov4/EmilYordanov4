using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int i = 0; i < n - 1; i++)
            {
                int firstLength = jagged[i].Length;
                int secondLength = jagged[i + 1].Length;

                if (firstLength == secondLength)
                {
                    jagged[i] = jagged[i].Select(e => e * 2).ToArray();
                    jagged[i + 1] = jagged[i + 1].Select(e => e * 2).ToArray();
                }
                else
                {
                    jagged[i] = jagged[i].Select(e => e / 2).ToArray();
                    jagged[i + 1] = jagged[i + 1].Select(e => e / 2).ToArray();
                }
            }

            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (tokens[0] !=  "End")
            {
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                {
                    if (tokens[0] == "Add")
                    {
                        jagged[row][col] += value; 
                    }
                    else if (tokens[0] == "Subtract")
                    {
                        jagged[row][col] -= value; 
                    }
                }
                else
                {

                }


                tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }


            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
