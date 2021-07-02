using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cityPopulation = new Dictionary<string, int>();
            Dictionary<string, int> cityGold = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split("||");

            while (input[0] != "Sail")
            {
                string cityName = input[0];
                int people = int.Parse(input[1]);
                int gold = int.Parse(input[2]);

                if (!cityPopulation.ContainsKey(cityName))
                {
                    cityPopulation.Add(cityName, people);
                    cityGold.Add(cityName, gold);
                }
                else
                {
                    cityPopulation[cityName] += people;
                    cityGold[cityName] += gold;
                }
                input = Console.ReadLine().Split("||");
            }

            input = Console.ReadLine().Split("=>");

            while (input[0] != "End")
            {
                if (input[0] == "Plunder")
                {
                    string cityName = input[1];
                    int people = int.Parse(input[2]);
                    int gold = int.Parse(input[3]);

                    cityPopulation[cityName] -= people;
                    cityGold[cityName] -= gold;

                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cityPopulation[cityName] <= 0 || cityGold[cityName] <= 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        cityPopulation.Remove(cityName);
                        cityGold.Remove(cityName);
                    }

                }
                else if (input[0] == "Prosper")
                {
                    string cityName = input[1];
                    int gold = int.Parse(input[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        input = Console.ReadLine().Split("=>");
                        continue;
                    }
                    else
                    {
                        cityGold[cityName] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cityGold[cityName]} gold.");
                    }
                }

                input = Console.ReadLine().Split("=>");
            }

            cityGold = cityGold.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            if (cityGold.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityGold.Count} wealthy settlements to go to:");
                foreach (var item in cityGold)
                {
                    Console.WriteLine($"{item.Key} -> Population: {cityPopulation[item.Key]} citizens, Gold: {item.Value} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");

            }
        }
    }
}
