using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            int schoolGrade = 1;
            int failedGrade = 0;
            double allGrades = 0;

            while (schoolGrade != 13)
            {
                if (grade >= 4.00)
                {
                    schoolGrade++;
                    allGrades += grade;
                    if (schoolGrade >= 13)
                    {
                        break;
                    }
                }
                if (grade < 4)
                {
                    failedGrade++;
                    if (failedGrade == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {schoolGrade} grade");
                        Environment.Exit(0);
                    }
                }
                grade = double.Parse(Console.ReadLine());
            }
            double averageGrade = allGrades / 12; 
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
