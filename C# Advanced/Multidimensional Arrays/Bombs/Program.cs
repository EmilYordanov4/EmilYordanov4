using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] dimentions = coordinates[i].Split(",").Select(int.Parse).ToArray();
                int row = dimentions[0];
                int col = dimentions[1];
                
                int explosingCell = matrix[row, col];

                if (explosingCell > 0)
                {
                    matrix[row, col] = 0;
                    for (int j = row - 1; j <= row + 1; j++)
                    {
                        for (int k = col - 1; k <= col + 1; k++)
                        {
                            int explosingRow = j;
                            int explosingCol = k;

                            if (explosingRow >= 0 && explosingRow < n && explosingCol >= 0 && explosingCol < n && matrix[explosingRow, explosingCol] > 0)
                            {
                                matrix[explosingRow, explosingCol] -= explosingCell;
                            }
                        }
                    }
                }
            }

            int counter = 0;
            int sum = 0;
            foreach (int item in matrix)
            {
                if (item > 0)
                {
                    counter++;
                    sum += item;
                }
            }
            Console.WriteLine($"Alive cells: {counter}");
            Console.WriteLine($"Sum: {sum}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
