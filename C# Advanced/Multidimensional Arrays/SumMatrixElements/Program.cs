using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] eachRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = eachRow[col];
                }
            }
            int sum = 0;

            foreach (int item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(rowsAndCols[0]);
            Console.WriteLine(rowsAndCols[1]);
            Console.WriteLine(sum);
        }
    }
}
