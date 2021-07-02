using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, int, bool> isOlderOrYounger = (str, pAge, nAge) =>
            {
                switch (str)
                {
                    case "younger":
                        return pAge < nAge;
                    default:
                        return pAge >= nAge;
                }
            };

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(info[0], int.Parse(info[1]));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            people = people.Where(x => isOlderOrYounger(condition, x.Value, age))
                .ToDictionary(a => a.Key, b => b.Value);

            isPrinting(format, people);

        }
        static void isPrinting(string format, Dictionary<string, int> people) 
        {
            switch (format)
            {
                case "name":
                    foreach (var item in people)
                    {
                        Console.WriteLine(item.Key);
                    }
                    break;
                case "age":
                    foreach (var item in people)
                    {
                        Console.WriteLine(item.Value.ToString());
                    }
                    break;
                default:
                    foreach (var item in people)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                    break;
            }
        }
    }
}
