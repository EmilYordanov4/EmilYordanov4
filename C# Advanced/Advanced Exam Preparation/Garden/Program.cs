using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int gardenRow = size[0];
            int gardenCol = size[1];

            Dictionary<int, int> flowers = new Dictionary<int, int>();

            int[,] garden = new int[gardenRow, gardenCol];

            for (int i = 0; i < gardenRow; i++)
            {
                for (int j = 0; j < gardenCol; j++)
                {
                    garden[i, j] = 0;
                }
            }

            string input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                int[] coords = input.Split().Select(int.Parse).ToArray();
                int row = coords[0];
                int col = coords[1];

                if (row < 0 || row >= gardenRow || col < 0 || col >= gardenCol)
                {
                    Console.WriteLine($"Invalid coordinates.");
                }
                else
                {
                    flowers[row] = col;
                    garden[row, col]++;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < gardenRow; i++)
            {
                for (int j = 0; j < gardenCol; j++)
                {
                    if (flowers.ContainsKey(i) && flowers[i] == j)
                    {
                        AffectFlowers(garden, i, j);
                    }
                }
            }


            for (int i = 0; i < gardenRow; i++)
            {
                for (int j = 0; j < gardenCol; j++)
                {
                    Console.Write(garden[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void AffectFlowers(int[,] garden, int row, int col)
        {
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                if (i == row)
                {

                }
                else
                {
                    garden[i, col]++;
                }
            }
            for (int i = 0; i < garden.GetLength(1); i++)
            {
                if (i == col)
                {

                }
                else
                {
                    garden[row, i]++;
                }
            }
        }
    }
}
