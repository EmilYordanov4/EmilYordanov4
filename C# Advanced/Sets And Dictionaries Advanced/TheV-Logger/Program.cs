using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "Statistics")
            {
                string followingVlogger = tokens[0];
                string command = tokens[1];
                string followedVlogger = tokens[2];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(followingVlogger))
                    {
                        vloggers[followingVlogger] = new Dictionary<string, SortedSet<string>>();
                        vloggers[followingVlogger].Add("followers", new SortedSet<string>());
                        vloggers[followingVlogger].Add("following", new SortedSet<string>());
                    }
                }
                else if (command == "followed" && followingVlogger != followedVlogger && vloggers.ContainsKey(followedVlogger) && vloggers.ContainsKey(followingVlogger))
                {
                    vloggers[followedVlogger]["followers"].Add(followingVlogger);
                    vloggers[followingVlogger]["following"].Add(followedVlogger);
                }


                tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            vloggers = vloggers.OrderByDescending(a => a.Value["followers"].Count).ThenBy(a => a.Value["following"].Count).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var item in vloggers)
            {
                if (count == 1)
                {
                    Console.WriteLine($"1. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                    if (item.Value["followers"].Count == 0)
                    {

                    }
                    else
                    {
                        foreach (var follower in item.Value["followers"])
                        {
                            Console.WriteLine($"*  {follower}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{count}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                }
                count++;
            }
        }
    }
}
