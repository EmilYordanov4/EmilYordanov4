using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int counter = n - 1;
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                primaryDiagonalSum += matrix[row, row];
                secondaryDiagonalSum += matrix[row,counter--];
                
            }

            Console.WriteLine($"{Math.Abs(primaryDiagonalSum - secondaryDiagonalSum)}");
        }
    }
}
