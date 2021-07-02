using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }

                students[name].Add(grade);
            }

            students = students.Where(x => x.Value.Sum() / x.Value.Count >= 4.50).OrderByDescending(x => x.Value.Sum() / x.Value.Count).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Sum() / item.Value.Count:f2}");
            }
        }
    }
}
