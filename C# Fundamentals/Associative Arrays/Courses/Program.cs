using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] information = input.Split(" : ");
                string courseName = information[0];
                string studentName = information[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(studentName);

                input = Console.ReadLine();
            }

            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(a => a.Key, b => b.Value);
            
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value.OrderBy(x => x).ToList())
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
