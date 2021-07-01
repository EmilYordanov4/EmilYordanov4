using System;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double litresFuelNeededPerHundred = double.Parse(Console.ReadLine());

            int distance = 384400;
            int totalDistance = distance * 2;

            double totalHours = totalDistance / averageSpeed;
            totalHours += 3;

            double fuelNeeded = (litresFuelNeededPerHundred * totalDistance) / 100;

            Console.WriteLine($"{Math.Ceiling(totalHours)}");
            Console.WriteLine($"{fuelNeeded}");
        }
    }
}
