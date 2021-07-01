using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsTravelling = int.Parse(Console.ReadLine());
            double weekends = 48;

            double daysPlaying = (weekends - weekendsTravelling) * 3 / 4; //34,5

            daysPlaying += weekendsTravelling;
            daysPlaying += holidays * 2 / 3;

            if (year == "leap")
            {
                daysPlaying += daysPlaying * 0.15;
            }
            
            Console.WriteLine(Math.Floor(daysPlaying));
        }
    }
}
