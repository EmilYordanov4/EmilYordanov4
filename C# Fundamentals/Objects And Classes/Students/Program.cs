using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Students> allStudents = new List<Students>();

            while (input != "end")
            {
                string[] information = input.Split().ToArray();

                Students newStudent = new Students();

                newStudent.FirstName = information[0];
                newStudent.LastName = information[1];
                newStudent.Age = information[2];
                newStudent.Hometown = information[3];

                allStudents.Add(newStudent);

                input = Console.ReadLine();
            }

            string hometownNeeded = Console.ReadLine();

            foreach (Students newStudent in allStudents.Where(x => x.Hometown == hometownNeeded))
            {
                Console.WriteLine($"{newStudent.FirstName} {newStudent.LastName} is {newStudent.Age} years old.");
            }
        }
    }
}
