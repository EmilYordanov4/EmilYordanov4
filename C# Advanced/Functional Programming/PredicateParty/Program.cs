using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Party!")
            {
                string action = input[0];
                string typeOfAction = input[1];
                string condition = input[2];

                if (action == "Remove")
                {
                    if (typeOfAction == "StartsWith")
                    {
                        names = names.Where(x => !x.StartsWith(condition)).ToList();
                    }
                    else if (typeOfAction == "EndsWith")
                    {
                        names = names.Where(x => !x.EndsWith(condition)).ToList();
                    }
                    else if (typeOfAction == "Length")
                    {
                        names = names.Where(x => x.Length == int.Parse(condition)).ToList();
                    }
                }
                else if (action == "Double")
                {
                    Func<List<string>, List<string>> addingNames = s =>
                    {
                        Adding(s, typeOfAction, condition);
                        return s;
                    };
                    names = addingNames(names);
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (names.Count != 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine($"Nobody is going to the party!");
            }
        }

        private static void Adding(List<string> s, string typeOfAction, string condition)
        {
            int length = s.Count;
            if (typeOfAction == "StartsWith")
            {
                for (int i = 0; i < length; i++)
                {
                    if (s[i].StartsWith(condition))
                    {
                        s.Add(s[i]);
                    }
                }
            }
            else if (typeOfAction == "EndsWith")
            {
                for (int i = 0; i < length; i++)
                {
                    if (s[i].EndsWith(condition))
                    {
                        s.Add(s[i]);
                    }
                }
            }
            else if (typeOfAction == "Length")
            {
                for (int i = 0; i < length; i++)
                {
                    if (s[i].Length == int.Parse(condition))
                    {
                        s.Add(s[i]);
                    }
                }
            }
        }
    }
}
