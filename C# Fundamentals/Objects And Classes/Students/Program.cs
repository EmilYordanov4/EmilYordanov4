using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<StudentInfo> allStudents = new List<StudentInfo>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ");
                StudentInfo newStudent = new StudentInfo(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));

                allStudents.Add(newStudent);
            }
            List<StudentInfo> sortedStudents = allStudents.OrderByDescending(x => x.Grade).ToList();

            sortedStudents.ForEach(x => Console.WriteLine(x));
        }
    }
}
