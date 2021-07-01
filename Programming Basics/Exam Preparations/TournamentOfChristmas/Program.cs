using System;
using System.Runtime.InteropServices.ComTypes;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double budget = 0;
            double totalBudget = 0;

            int gamesWon = 0;
            int gamesLost = 0;

            int totalGamesWon = 0;
            int totalGamesLost = 0;

            for (int i = 1; i <= n; i++)
            {
                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        totalGamesWon++;
                        gamesWon++;
                        budget += 20;
                    }
                    else if (result == "lose")
                    {
                        totalGamesLost++;
                        gamesLost++;
                    }
                    sport = Console.ReadLine();
                }
                if (gamesWon > gamesLost)
                {
                    totalBudget += budget + budget * 10 / 100;
                }
                else if (gamesWon < gamesLost)
                {
                    totalBudget += budget;
                }
                budget = 0;
                gamesLost = 0;
                gamesWon = 0;
            }
            if (totalGamesWon > totalGamesLost)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {totalBudget + totalBudget * 20 / 100:F2}");
            }
            else if (totalGamesLost > totalGamesWon)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalBudget:F2}");
            }
        }
    }
}
