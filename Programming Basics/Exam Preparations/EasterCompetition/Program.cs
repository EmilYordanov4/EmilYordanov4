using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string bestGrade = "";
            int maxPoints = int.MinValue;
            int gradeNumber = 0;
            int points = 0;

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                string grade = Console.ReadLine();

                while (grade != "Stop")
                {
                    gradeNumber = int.Parse(grade);

                    points += gradeNumber;

                    grade = Console.ReadLine();
                }
                Console.WriteLine($"{name} has {points} points.");

                if (points > maxPoints)
                {
                    maxPoints = points;
                    bestGrade = name;
                    Console.WriteLine($"{bestGrade} is the new number 1!");
                }
                points = 0;
            }
            Console.WriteLine($"{bestGrade} won competition with {maxPoints} points!");
        }
    }
}
