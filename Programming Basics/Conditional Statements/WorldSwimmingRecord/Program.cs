using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeForMetre = double.Parse(Console.ReadLine());

            double needToSwim = (distanceInMetres * timeForMetre);
            double added = Math.Floor(distanceInMetres / 15) * 12.5;

            double totalTime = needToSwim + added;

            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:F2} seconds slower.");
            }
        }
    }
}
