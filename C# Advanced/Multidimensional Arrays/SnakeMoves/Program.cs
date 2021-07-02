using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            string snake = Console.ReadLine();
            int snakeLength = 0;

            for (int col = 0; col < cols; col++)
            {
                if (snakeLength >= snake.Length)
                {
                    snakeLength = 0;
                }
                matrix[0, col] = snake[snakeLength];
                snakeLength++;
            }
                snakeLength--;
            for (int row = 1; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    snakeLength--;
                    if (snakeLength < 0)
                    {
                        snakeLength = snake.Length - 1;
                    }
                    matrix[row, col] = snake[snakeLength];
                }

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
