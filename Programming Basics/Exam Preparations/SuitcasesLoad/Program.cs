using System;

namespace SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double totalVolume = 0;
            int count = 0;

            while (input != "End")
            {
                double volume = double.Parse(input);

                totalVolume += volume;

                count++;
                if (count % 3 == 0)
                {
                    totalVolume += volume * 10 / 100;
                }
                if (capacity < totalVolume)
                {
                    --count;
                    Console.WriteLine($"No more space!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (capacity >= totalVolume)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {count} suitcases loaded.");
        }
    }
}
