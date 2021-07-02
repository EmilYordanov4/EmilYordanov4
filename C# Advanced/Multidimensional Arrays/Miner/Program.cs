using System;
using System.Collections.Generic;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] movements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> movings = new Queue<string>(movements);

            string[,] matrix = new string[n, n];

            int playerRow = -1;
            int playerCol = -1;
            int totalCoals = 0;
            for (int row = 0; row < n; row++)
            {
                string[] addingField = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    if (addingField[col] == "s")
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    if (addingField[col] == "c")
                    {
                        totalCoals++;
                    }
                    matrix[row, col] = addingField[col];
                }
            }
            int currentRow = -1;
            int currentCol = -1;
            int coalsCollected = 0;
            bool isEnded = false;
            while (movings.Count != 0)
            {
                string movement = movings.Dequeue();

                PlayerMovement(playerRow, playerCol, movement, ref currentRow, ref currentCol);

                if (currentRow >= 0 && currentRow < n && currentCol >= 0 && currentCol < n)
                {
                    playerRow = currentRow;
                    playerCol = currentCol;
                    if (matrix[playerRow, playerCol] == "c")
                    {
                        coalsCollected++;
                        matrix[playerRow, playerCol] = "*";
                        if (coalsCollected == totalCoals)
                        {
                            Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                            isEnded = true;
                            break;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                        isEnded = true;
                        break;
                    }
                }
                else
                {
                    continue;
                }

            }
            if (movings.Count == 0 && isEnded == false)
            {
                Console.WriteLine($"{totalCoals - coalsCollected} coals left. ({currentRow}, {currentCol})");
            }


        }

        private static void PlayerMovement(int playerRow, int playerCol, string movement, ref int movingRow, ref int movingCol)
        {
            if (movement == "up")
            {
                movingRow = playerRow - 1;
                movingCol = playerCol;
            }
            else if (movement == "down")
            {
                movingRow = playerRow + 1;
                movingCol = playerCol;
            }
            else if (movement == "left")
            {
                movingRow = playerRow;
                movingCol = playerCol - 1;
            }
            else if (movement == "right")
            {
                movingRow = playerRow;
                movingCol = playerCol + 1;
            }
        }
    }
}
