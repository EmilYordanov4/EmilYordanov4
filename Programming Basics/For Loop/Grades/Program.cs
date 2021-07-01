using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double averageGrade = 0;

            double topStudents = 0;
            double almostTopStudents = 0;
            double averageStudents = 0;
            double failedStudents = 0;

            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5.00)
                {
                    topStudents++;
                    averageGrade += grade;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    almostTopStudents++;
                    averageGrade += grade;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    averageStudents++;
                    averageGrade += grade;
                }
                else if (grade < 3.00)
                {
                    failedStudents++;
                    averageGrade += grade;
                }
            }
            Console.WriteLine($"Top students: {topStudents / n * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {almostTopStudents / n * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {averageStudents / n * 100:F2}%");
            Console.WriteLine($"Fail: {failedStudents / n * 100:F2}%");
            Console.WriteLine($"Average: {averageGrade / n:F2}");
        }
    }
}
