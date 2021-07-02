using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Students> allStudents = new List<Students>();
            bool ifStudentExists = false;


            while (input != "end")
            {
                string[] information = input.Split().ToArray();
                int age = int.Parse(information[2]);
                ifStudentExists = false;

                Students newStudent = new Students();

                for (int i = 0; i < allStudents.Count; i++)
                {
                    if (information[0] == allStudents[i].FirstName && information[1] == allStudents[i].LastName)
                    {
                        allStudents[i].Age = age;
                        allStudents[i].City = information[3];
                        ifStudentExists = true;
                        break;
                    }
                }
                if (ifStudentExists == false)
                {
                    newStudent.FirstName = information[0];
                    newStudent.LastName = information[1];
                    newStudent.Age = age;
                    newStudent.City = information[3];

                    allStudents.Add(newStudent);
                }

                input = Console.ReadLine();
            }

            string neededCity = Console.ReadLine();

            foreach (Students newStudent in allStudents.Where(x => x.City == neededCity))
            {
                Console.WriteLine($"{newStudent.FirstName} {newStudent.LastName} is {newStudent.Age} years old.");
            }
        }
    }
}
