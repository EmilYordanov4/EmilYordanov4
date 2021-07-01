using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedSum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int sum = 0;
            double averageCS = 0;
            double averageCC = 0;
            int csTimes = 0;
            int ccTimes = 0;

            int round = 0;
            while (input != "End")
            {
                int product = int.Parse(input);
                if (round % 2 == 0)
                {
                    if (product <= 100)
                    {
                        Console.WriteLine("Product sold!");
                        averageCS += product;
                        sum += product;
                        csTimes++;
                    }
                    else if (product > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if (product >= 10)
                    {
                        Console.WriteLine("Product sold!");
                        averageCC += product;
                        sum += product;
                        ccTimes++;
                    }
                    else if (product < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                if (sum >= expectedSum)
                {
                    Console.WriteLine($"Average CS: {averageCS / csTimes:F2}");
                    Console.WriteLine($"Average CC: {averageCC / ccTimes:F2}");
                    Environment.Exit(0);
                }
                round++;
                input = Console.ReadLine();
            }
            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
