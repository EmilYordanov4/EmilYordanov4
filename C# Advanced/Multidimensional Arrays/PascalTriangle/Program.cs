using System;
using System.Numerics;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] jagged = new long[n][];
            if (n > 0 && n < 2)
            {
                jagged[0] = new long[0 + 1];
                jagged[0][0] = 1;
            }
            else
            {

                for (int row = 0; row <= 1; row++)
                {
                    jagged[row] = new long[row + 1];
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] = 1;

                    }
                }

                for (int row = 2; row < jagged.Length; row++)
                {
                    jagged[row] = new long[row + 1];
                    jagged[row][0] = 1;
                    jagged[row][jagged[row].Length - 1] = 1;
                    for (int col = 1; col < jagged[row].Length - 1; col++)
                    {
                        jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
                    }
                }

            }
            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }
    }
}
