using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double neededTime = distance * timeForOneMeter;
            double slopeTime = Math.Floor(distance / 50) * 30;
            double neededTimeWithSlope = neededTime + slopeTime;

            if (neededTimeWithSlope >= record)
            {
                Console.WriteLine($"No! He was {neededTimeWithSlope - record:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {neededTimeWithSlope:F2} seconds.");
            }
        }
    }
}
