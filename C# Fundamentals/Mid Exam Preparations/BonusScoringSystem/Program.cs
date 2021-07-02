using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double countOfLecturers = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());

            double maxBonus = double.MinValue;
            double maxAttendances = double.MinValue;
            double totalAttendances = 0;

            for (int i = 0; i < n; i++)
            {
                double attendances = double.Parse(Console.ReadLine());
                totalAttendances += attendances;
                double totalBonus = attendances / countOfLecturers * (5 + bonus);
                if (totalBonus >= maxBonus)
                {
                    maxBonus = totalBonus;
                }

                if (attendances > maxAttendances)
                {
                    maxAttendances = attendances;
                }

            }
            if (maxBonus == double.MinValue)
            {
                maxBonus = 0;
            }
            if (maxAttendances == double.MinValue)
            {
                maxAttendances = 0;
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
