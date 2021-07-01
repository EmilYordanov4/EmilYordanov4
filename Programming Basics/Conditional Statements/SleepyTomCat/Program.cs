using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int year = 365;
            int workDays = year - restDays;
            int neededRest = 30000;

            int restDaysPlayTime = restDays * 127;
            int workDaysPlayTime = workDays * 63;
            int playTime = restDaysPlayTime + workDaysPlayTime;
            int lessTime = neededRest - playTime;
            int hours = lessTime / 60;
            int minutes = lessTime % 60;
            double minus = -1;

            if (neededRest >= playTime )
            {
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else if (neededRest < playTime)
            {
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{hours * minus} hours and {minutes * minus} minutes more for play");
            }
        }
    }
}
