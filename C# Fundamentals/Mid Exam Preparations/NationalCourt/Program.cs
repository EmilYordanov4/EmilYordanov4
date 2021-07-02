using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoplePerHour = 0;
            for (int i = 0; i < 3; i++)
            {
                int oneEmploye = int.Parse(Console.ReadLine());
                peoplePerHour += oneEmploye;
            }
            int totalPeopleCount = int.Parse(Console.ReadLine());
            int hours = 0;
            while (totalPeopleCount > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                totalPeopleCount -= peoplePerHour;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
