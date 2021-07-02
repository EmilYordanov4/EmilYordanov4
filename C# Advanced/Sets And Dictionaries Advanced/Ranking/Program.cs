using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwords = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(":");

            while (input[0] != "end of contests")
            {
                passwords.Add(input[0], input[1]);

                input = Console.ReadLine().Split(":");
            }

            input = Console.ReadLine().Split("=>");

            while (input[0] != "end of submissions")
            {
                string contestName = input[0];
                string contestPassword = input[1];
                string userName = input[2];
                int points = int.Parse(input[3]);
                if (!passwords.ContainsKey(contestName) || passwords[contestName] != contestPassword)
                {
                    input = Console.ReadLine().Split("=>");
                    continue;
                }
                if (!users.ContainsKey(userName))
                {
                    users[userName] = new Dictionary<string, int>();
                }
                if (!users[userName].ContainsKey(contestName))
                {
                    users[userName][contestName] = 0;
                }
                if (passwords[contestName] == contestPassword && points > users[userName][contestName])
                {
                    users[userName][contestName] = points;
                }
                input = Console.ReadLine().Split("=>");
            }

            string userWithMax = string.Empty;
            int maxTotalPoinst = -1;
            int sum = 0;
            foreach (var item in users)
            {
                foreach (var user in item.Value)
                {
                    sum += user.Value;
                }

                if (sum > maxTotalPoinst)
                {
                    maxTotalPoinst = sum;
                    userWithMax = item.Key;
                }
                sum = 0;
            }

            
            Console.WriteLine($"Best candidate is {userWithMax} with total {maxTotalPoinst} points.");
            Console.WriteLine($"Ranking:");
            foreach (var item in users.OrderBy(x => x.Key))
            {
                
                Console.WriteLine($"{item.Key}");
                foreach (var user in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {user.Key} -> {user.Value}");
                }
            }
        }
    }
}
