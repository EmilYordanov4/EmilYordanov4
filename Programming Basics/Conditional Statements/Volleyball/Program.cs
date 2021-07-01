using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsTravelling = int.Parse(Console.ReadLine());
            int weekends = 48;
            int daysPlaying = (weekends - weekendsTravelling) * 3 / 4;
            Console.WriteLine(daysPlaying);
        }
    }
}
