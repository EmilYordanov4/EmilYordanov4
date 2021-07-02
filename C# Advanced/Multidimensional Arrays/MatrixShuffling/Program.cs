using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "END")
            {
                if (tokens.Length != 5 || tokens[0] != "swap")
                {
                    Console.WriteLine($"Invalid input!");
                    tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                else
                {
                    int rowOne = int.Parse(tokens[1]);
                    int colOne = int.Parse(tokens[2]);
                    int rowTwo = int.Parse(tokens[3]);
                    int colTwo = int.Parse(tokens[4]);

                    bool isRowOneValid = ValidatingIndexes(matrix, rowOne, colOne);
                    bool isRowTwoValid = ValidatingIndexes(matrix, rowTwo, colTwo);

                    if (!isRowOneValid || !isRowTwoValid)
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                    else
                    {
                        string temp = matrix[rowOne, colOne];
                        matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                        matrix[rowTwo, colTwo] = temp;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }



                tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }


        }

        private static bool ValidatingIndexes(string[,] matrix, int row, int col)
        {
            bool isValid = false;

            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
