using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] information = input.Split(" -> ");

                if (!companies.ContainsKey(information[0]))
                {
                    companies[information[0]] = new List<string>();
                }
                if (companies[information[0]].Contains(information[1]))
                {

                }
                else
                {
                    companies[information[0]].Add(information[1]);
                }

                input = Console.ReadLine();
            }

            companies = companies.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var IDs in item.Value)
                {
                    Console.WriteLine($"-- {IDs}");
                }
            }
        }
    }
}
