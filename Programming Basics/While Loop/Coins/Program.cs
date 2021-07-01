using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coins = 0;

            while (change != 0)
            {
                if (change >= 2)
                {
                    change -= 2M;
                    coins++;
                    continue;
                }
                if (change >= 1)
                {
                    change -= 1M;
                    coins++;
                    continue;
                }
                if (change >= 0.50M)
                {
                    change -= 0.50M;
                    coins++;
                    continue;
                }
                if (change >= 0.20M)
                {
                    change -= 0.20M;
                    coins++;
                    continue;
                }
                if (change >= 0.10M)
                {
                    change -= 0.10M;
                    coins++;
                    continue;
                }
                if (change >= 0.05M)
                {
                    change -= 0.05M;
                    coins++;
                    continue;
                }
                if (change >= 0.02M)
                {
                    change -= 0.02M;
                    coins++;
                    continue;
                }
                if (change >= 0.01M)
                {
                    change -= 0.01M;
                    coins++;
                    continue;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
