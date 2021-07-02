using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];

            int snakeCol = -1;
            int snakeRow = -1;


            int firstBurrowRow = -1;
            int firstBurrowCol = -1;
            int secondBurrowRow = -1;
            int secondBurrowCol = -1;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string fieldRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    if (count == 0 && fieldRow[j] == 'B')
                    {
                        firstBurrowCol = i;
                        firstBurrowRow = j;
                        count++;
                    }
                    else if (count == 1 && fieldRow[j] == 'B')
                    {
                        secondBurrowCol = i;
                        secondBurrowRow = j;
                    }

                    if (fieldRow[j] == 'S')
                    {
                        snakeCol = i;
                        snakeRow = j;
                    }

                    field[i, j] = fieldRow[j];
                }
            }
            bool isOutOfTerritory = false;
            int eatedFood = 0;

            while (eatedFood != 10)
            {
                string direction = Console.ReadLine();
                field[snakeCol, snakeRow] = '.';
                switch (direction)
                {
                    case "up":
                        snakeCol--;
                        break;
                    case "down":
                        snakeCol++;
                        break;
                    case "left":
                        snakeRow--;
                        break;
                    case "right":
                        snakeRow++;
                        break;
                }

                if (snakeRow < 0 || snakeRow >= n || snakeCol < 0 || snakeCol >= n)
                {
                    isOutOfTerritory = true;
                    break;
                }
                else if (field[snakeCol, snakeRow] == 'B')
                {
                    if (snakeCol == firstBurrowCol && snakeRow == firstBurrowRow)
                    {
                        field[firstBurrowCol, firstBurrowRow] = '.';
                        snakeCol = secondBurrowCol;
                        snakeRow = secondBurrowRow;
                    }
                    else
                    {
                        field[secondBurrowCol, secondBurrowRow] = '.';
                        snakeCol = firstBurrowCol;
                        snakeRow = firstBurrowRow;
                    }
                }
                else if (field[snakeCol, snakeRow] == '*')
                {
                    eatedFood++;
                }

                field[snakeCol, snakeRow] = 'S';
            }

            if (isOutOfTerritory)
            {
                Console.WriteLine($"Game over!");
            }
            else
            {
                Console.WriteLine($"You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {eatedFood}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
