using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = 255;
            int n = int.Parse(Console.ReadLine());

            int totalAdded = 0;

            for (int i = 0; i < n; i++)
            {
                int addedWater = int.Parse(Console.ReadLine());
                if (addedWater <= maxCapacity)
                {
                    totalAdded += addedWater;
                    maxCapacity -= addedWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine($"{totalAdded}");
        }
    }
}
