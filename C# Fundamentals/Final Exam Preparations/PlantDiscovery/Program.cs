using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> numberOfRatings = new Dictionary<string, List<double>>();
            AddingPlants(n, plantRarity);

            string[] cmds = Console.ReadLine().Split(": ");

            while (cmds[0] != "Exhibition")
            {
                string action = cmds[0];
                if (action == "Rate")
                {
                    string[] info = cmds[1].Split(" - ");

                    string name = info[0];
                    double rating = double.Parse(info[1]);

                    if (plantRarity.ContainsKey(name))
                    {
                        if (!numberOfRatings.ContainsKey(name))
                        {
                            numberOfRatings[name] = new List<double>();
                        }
                        numberOfRatings[name].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }
                else if (action == "Update")
                {
                    string[] info = cmds[1].Split(" - ");

                    string name = info[0];
                    int rarity = int.Parse(info[1]);

                    if (plantRarity.ContainsKey(name))
                    {
                        plantRarity[name] = rarity;
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }
                else if (action == "Reset")
                {
                    string name = cmds[1];

                    if (plantRarity.ContainsKey(name))
                    {
                        numberOfRatings.Remove(name);
                        numberOfRatings[name] = new List<double>();
                        numberOfRatings[name].Add(0);
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }
                else
                {
                    Console.WriteLine($"error");
                }
                cmds = Console.ReadLine().Split(": ");
            }

            Dictionary<Dictionary<string, int>, Dictionary<string, List<double>>> pomosht = new Dictionary<Dictionary<string, int>, Dictionary<string, List<double>>>();
            foreach (var item in plantRarity)
            {
                
            }

        }

        private static void AddingPlants(int n, Dictionary<string, int> plantRarity)
        {
            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");

                string plantName = plantInfo[0];
                int plantRating = int.Parse(plantInfo[1]);
                if (!plantRarity.ContainsKey(plantName))
                {
                    plantRarity[plantName] = 0;

                }
                plantRarity[plantName] += plantRating;
            }
        }
    }
}
