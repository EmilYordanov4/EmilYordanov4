using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceTeams = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] inputArgs = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Contains("|"))
                {
                    string forceSide = inputArgs[0];
                    string forceUser = inputArgs[1];
                    if (!forceTeams.ContainsKey(forceSide))
                    {
                        forceTeams[forceSide] = new List<string>();
                    }
                    if (!forceTeams.Values.Any(x => x.Contains(forceUser)))
                    {
                        forceTeams[forceSide].Add(forceUser);
                    }
                }
                else
                {
                    string forceSide = inputArgs[1];
                    string forceUser = inputArgs[0];

                    bool isExisting = false;
                    foreach (var item in forceTeams)
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            string name = item.Value[i];
                            if (name == forceUser)
                            {
                                forceTeams[item.Key].RemoveAt(i);
                                forceTeams[forceSide].Add(forceUser);
                                isExisting = true;
                                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                                break;
                            }
                        }
                    }
                    if (isExisting == false)
                    {
                        if (!forceTeams.ContainsKey(forceSide))
                        {
                            forceTeams[forceSide] = new List<string>();
                        }
                        forceTeams[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
            }

            forceTeams = forceTeams.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in forceTeams)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
