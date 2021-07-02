using System;
using System.Linq;
using System.Text;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] beach = new char[n][];

            int myTokens = 0;
            int opponentTokens = 0;

            for (int i = 0; i < n; i++)
            {
                char[] rows = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                beach[i] = new char[rows.Length];
                for (int j = 0; j < rows.Length; j++)
                {
                    beach[i][j] = rows[j];
                }
            }

            string[] cmds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (cmds[0] != "Gong")
            {

                if (cmds[0] == "Find")
                {
                    int row = int.Parse(cmds[1]);
                    int col = int.Parse(cmds[2]);

                    if (row < 0 || row >= n || col < 0 || col >= beach[row].Length)
                    {
                        
                    }
                    else
                    {
                        if (beach[row][col] == 'T')
                        {
                            myTokens++;
                            beach[row][col] = '-';
                        }
                    }
                }
                else if (cmds[0] == "Opponent")
                {
                    int row = int.Parse(cmds[1]);
                    int col = int.Parse(cmds[2]);
                    string direction = cmds[3];

                    int endDistanationRow = row;
                    int endDistanationCol = col;

                    if (row < 0 || row >= n || col < 0 || col >= beach[row].Length)
                    {
                        cmds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else
                    {
                        if (beach[row][col] == 'T')
                        {
                            opponentTokens++;
                            beach[row][col] = '-';
                        }
                    }

                    switch (direction)
                    {
                        case "up":
                            endDistanationRow -= 3;
                            for (int i = row - 1; i >= endDistanationRow; i--)
                            {
                                if (i < 0 || i >= n || col < 0 || col >= beach[i].Length)
                                {
                                    if (beach[i][beach[i].Length] == 'T')
                                    {
                                        opponentTokens++;
                                        beach[i][beach[i].Length] = '-';
                                    }
                                }
                                else
                                {
                                    if (beach[i][col] == 'T')
                                    {
                                        opponentTokens++;
                                        beach[i][col] = '-';
                                    }
                                }
                            }
                            break;
                        case "down":
                            endDistanationRow += 3;
                            for (int i = row; i < endDistanationRow; i++)
                            {
                                if (i < 0 || i >= n || col < 0 || col >= beach[i].Length)
                                {
                                    if (beach[i][beach[i].Length] == 'T')
                                    {
                                        opponentTokens++;
                                        beach[i][beach[i].Length] = '-';
                                    }
                                }
                                else
                                {
                                    if (beach[i][col] == 'T')
                                    {
                                        opponentTokens++;
                                        beach[i][col] = '-';
                                    }

                                }
                            }
                            break;
                        case "left":
                            endDistanationCol -= 3;
                            for (int j = col - 1; j >= endDistanationCol; j--)
                            {
                                if (row < 0 || row >= n || j < 0 || j >= beach[row].Length)
                                {
                                    
                                }
                                else
                                {
                                    if (beach[row][j] == 'T')
                                    {
                                        opponentTokens++;
                                        beach[row][j] = '-';
                                    }

                                }
                            }
                            break;
                        case "right":
                            endDistanationCol += 3;
                            for (int j = col; j < endDistanationCol; j++)
                            {
                                if (row < 0 || row >= n || j < 0 || j >= beach[row].Length)
                                {
                                    
                                }
                                else
                                {
                                    if (beach[row][j] == 'T')
                                    {
                                        opponentTokens++;
                                        beach[row][j] = '-';
                                    }

                                }
                            }
                            break;
                    }
                }


                cmds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < beach[i].Length; k++)
                {
                    sb.Append(beach[i][k] + " ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString().Trim());
            Console.WriteLine($"Collected tokens: {myTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }
    }
}
