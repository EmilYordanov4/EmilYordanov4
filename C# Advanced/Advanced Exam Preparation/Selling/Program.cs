using System;
using System.Collections.Generic;
using System.Linq;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int playerRow = -1;
            int playerCol = -1;

            Dictionary<int, int> pillarsCoords = new Dictionary<int, int>();

            char[,] bakery = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string rows = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    if (rows[j] == 'S')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                    if (rows[j] == 'O')
                    {
                        pillarsCoords[i] = j;
                    }
                    bakery[i, j] = rows[j];
                }
            }

            int balance = 0;
            string movement = Console.ReadLine();

            while (true)
            {
                bakery[playerRow, playerCol] = '-';

                switch (movement)
                {
                    case "up":
                        playerRow--;
                        break;
                    case "down":
                        playerRow++;
                        break;
                    case "left":
                        playerCol--;
                        break;
                    case "right":
                        playerCol++;
                        break;
                }

                if (playerRow < 0 || playerRow >= n || playerCol < 0 || playerCol >= n)
                {
                    Console.WriteLine($"Bad news, you are out of the bakery.");
                    break;
                }

                if (bakery[playerRow, playerCol] == 'O')
                {
                    bakery[playerRow, playerCol] = '-';
                    foreach (var item in pillarsCoords.Where(x => x.Key != playerRow))
                    {
                        playerRow = item.Key;
                        playerCol = item.Value;
                    }
                }

                if (char.IsDigit(bakery[playerRow, playerCol]))
                {
                    balance += int.Parse(bakery[playerRow, playerCol].ToString());
                }

                bakery[playerRow, playerCol] = 'S';

                if (balance >= 50)
                {
                    Console.WriteLine($"Good news! You succeeded in collecting enough money!");
                    break;
                }

                movement = Console.ReadLine();
            }

            Console.WriteLine($"Money: {balance}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(bakery[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
