using System;
using System.Linq;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            if (n < 5 || n > 20)
            {
                return;
            }

            char[,] field = new char[n, n];

            int marioCol = -1;
            int marioRow = -1;

            for (int i = 0; i < n; i++)
            {
                string fieldRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    if (fieldRow[j] == 'M')
                    {
                        marioCol = i;
                        marioRow = j;
                    }
                    field[i, j] = fieldRow[j];
                }
            }

            bool isDead = false;
            bool isSaved = false;


            int destinationCol = marioCol;
            int destinationRow = marioRow;


            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (true)
            {
                string direction = tokens[0];
                int enemyCol = int.Parse(tokens[1]);
                int enemyRow = int.Parse(tokens[2]);

                field[enemyCol, enemyRow] = 'B';

                destinationCol = marioCol;
                destinationRow = marioRow;
                lives--;

                switch (direction)
                {
                    case "W":
                        destinationCol--;
                        break;
                    case "S":
                        destinationCol++;
                        break;
                    case "A":
                        destinationRow--;
                        break;
                    case "D":
                        destinationRow++;
                        break;
                }

                if (destinationCol >= n || destinationCol < 0 || destinationRow >= n || destinationRow < 0)
                {
                    if (lives <= 0)
                    {
                        field[marioCol, marioRow] = 'X';
                        Console.WriteLine($"Mario died at {marioCol};{marioRow}.");
                        break;
                    }
                    tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                else
                {
                    field[marioCol, marioRow] = '-';
                }

                if (field[destinationCol, destinationRow] == 'B')
                {
                    lives -= 2;
                }
                else if (field[destinationCol, destinationRow] == 'P')
                {
                    field[destinationCol, destinationRow] = '-';
                    isSaved = true;
                    break;
                }

                if (lives <= 0)
                {
                    field[destinationCol, destinationRow] = 'X';
                    isDead = true;
                    break;
                }

                field[destinationCol, destinationRow] = 'M';

                marioCol = destinationCol;
                marioRow = destinationRow;
                tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (isSaved == true)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else if (isDead == true)
            {
                Console.WriteLine($"Mario died at {destinationCol};{destinationRow}.");
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
