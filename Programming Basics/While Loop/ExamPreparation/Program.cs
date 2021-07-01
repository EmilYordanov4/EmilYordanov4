using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedGrades = int.Parse(Console.ReadLine());
            int badGrades = 0;
            string problem = "";

            double averageGrade = 0;
            int problems = 0;

            while (true)
            {
                string name = Console.ReadLine();
                if (name != "Enough")
                {
                    problem = name;
                }
                if (name == "Enough")
                {
                    Console.WriteLine($"Average score: {averageGrade / problems:F2}");
                    Console.WriteLine($"Number of problems: {problems}");
                    Console.WriteLine($"Last problem: {problem}");
                    Environment.Exit(0);
                }

                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGrades++;
                    if (badGrades >= failedGrades)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        Environment.Exit(0);
                    }
                }
                problems++;
                averageGrade += grade;
            }
        }
    }
}
