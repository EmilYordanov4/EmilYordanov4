using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < n; i++)
            {
                string[] grade = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string studentName = grade[0];
                decimal studentGrade = decimal.Parse(grade[1]);

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<decimal>();
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", students[item.Key].Select(e => e.ToString("F2")))} (avg: {students[item.Key].Average():f2})");
            }

        }
    }
}
