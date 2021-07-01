using System;
using System.Threading;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double bunnyPrice = 7;

            int count = 0;
            double clientBil = 0;
            double totalBil = 0;

            for (int i = 1; i <= n; i++)
            {
                string purchase = Console.ReadLine();

                while (purchase != "Finish")
                {
                    switch (purchase)
                    {
                        case "basket":
                            count++;
                            clientBil += basketPrice;
                            break;
                        case "wreath":
                            count++;
                            clientBil += wreathPrice;
                            break;
                        case "chocolate bunny":
                            count++;
                            clientBil += bunnyPrice;
                            break;
                    }

                    purchase = Console.ReadLine();

                }
                if (count % 2 == 0)
                {
                    clientBil -= clientBil * 20 / 100;
                }
                totalBil += clientBil;
                Console.WriteLine($"You purchased {count} items for {clientBil:F2} leva.");
                clientBil = 0;
                count = 0;
            }
            Console.WriteLine($"Average bill per client is: {totalBil / n:F2} leva.");
        }
    }
}
