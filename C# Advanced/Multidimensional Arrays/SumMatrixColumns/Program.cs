using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[info[0], info[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rows = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rows[col];
                }
            }


            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfCol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfCol += matrix[row, col];
                }
                Console.WriteLine(sumOfCol);
            }


        }
    }
}
