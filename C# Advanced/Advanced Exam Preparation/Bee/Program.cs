using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];

            int beeRow = -1;
            int beeCol = -1;

            for (int i = 0; i < n; i++)
            {
                string fieldRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    if (fieldRow[j] == 'B')
                    {
                        beeCol = i;
                        beeRow = j;
                    }
                    field[i, j] = fieldRow[j];
                }
            }

            int pollinatedFlowers = 0;
            string direction = Console.ReadLine();

            while (direction != "End")
            {
                field[beeCol, beeRow] = '.';
                switch (direction)
                {
                    case "up":
                        beeCol--;
                        break;
                    case "down":
                        beeCol++;
                        break;
                    case "left":
                        beeRow--;
                        break;
                    case "right":
                        beeRow++;
                        break;
                }

                if (beeCol >= n || beeCol < 0 || beeRow >= n || beeRow < 0)
                {
                    Console.WriteLine($"The bee got lost!");
                    break;
                }

                if (field[beeCol, beeRow] == 'O')
                {
                    field[beeCol, beeRow] = '.';
                    switch (direction)
                    {
                        case "up":
                            beeCol--;
                            break;
                        case "down":
                            beeCol++;
                            break;
                        case "left":
                            beeRow--;
                            break;
                        case "right":
                            beeRow++;
                            break;
                    }
                }
                if (field[beeCol, beeRow] == 'f')
                {
                    pollinatedFlowers++;
                    field[beeCol, beeRow] = 'B';
                }
                else
                {
                    field[beeCol, beeRow] = 'B';
                }

                direction = Console.ReadLine();
            }


            if (pollinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
