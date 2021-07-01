using System;
using System.Runtime.ConstrainedExecution;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double sum = puzzles * puzzlePrice + dolls * dollPrice +
                bears * bearPrice + minions * minionPrice + trucks * truckPrice;
            double toys = puzzles + dolls + bears + minions + trucks;
            if (toys >= 50)
            {
                double profitWithSale = sum - sum * 0.25;
                double profit = profitWithSale - profitWithSale * 0.10;

                if (profit >= tripPrice)
                {
                    double remain = profit - tripPrice;
                    //Console.WriteLine($"Yes! {Math.Round(remain, 2)} lv left.");
                    Console.WriteLine($"Yes! {remain,0:F2} lv left.");
                }
                else
                {
                    double needed = tripPrice - profit;
                    Console.WriteLine($"Not enough money! {needed,0:F2} lv needed.");
                }

            }
            else
            {
                double profit = sum - sum * 0.10;
                if (profit > tripPrice)
                {
                    double remain = profit - tripPrice;
                    Console.WriteLine($"Yes! {remain,0:F2} lv left.");
                }
                else
                {
                    double needed = tripPrice - profit;
                    Console.WriteLine($"Not enough money! {needed,0:F2} lv needed.");
                }
            }
        }
    }
}
