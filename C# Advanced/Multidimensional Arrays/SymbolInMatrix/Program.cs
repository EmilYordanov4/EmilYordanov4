using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int info = int.Parse(Console.ReadLine());
            char[,] matrix = new char[info, info];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string tokens = Console.ReadLine();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = tokens[col];
                }
            }
            char symbolNeeded = char.Parse(Console.ReadLine());

            int symbolRow = -1;
            int symbolCol = -1;
            bool isFound = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == symbolNeeded)
                    {
                        symbolRow = row;
                        symbolCol = col;
                        isFound = true;
                        break;
                    }
                }
                if (isFound == true)
                {
                    break;
                }
            }

            if (symbolRow != -1)
            {
                Console.WriteLine($"({symbolRow}, {symbolCol})");
            }
            else
            {
                Console.WriteLine($"{symbolNeeded} does not occur in the matrix ");
            }

        }
    }
}
