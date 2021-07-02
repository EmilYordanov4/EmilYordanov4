using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> legendaryMaterials = new Dictionary<string, int>();

            legendaryMaterials.Add("shards", 0);
            legendaryMaterials.Add("fragments", 0);
            legendaryMaterials.Add("motes", 0);

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string itemObtained = string.Empty;

            while (true)
            {
                bool isObtained = false;
                string[] input = Console.ReadLine().Split(" ");
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string itemName = input[i + 1].ToLower();
                    if (legendaryMaterials.ContainsKey(itemName))
                    {
                        legendaryMaterials[itemName] += quantity;

                        if (legendaryMaterials["shards"] >= 250)
                        {
                            itemObtained = "Shadowmourne";
                            legendaryMaterials[itemName] -= 250;
                            isObtained = true;
                            break;
                        }
                        else if (legendaryMaterials["fragments"] >= 250)
                        {
                            itemObtained = "Valanyr";
                            legendaryMaterials[itemName] -= 250;
                            isObtained = true;
                            break;
                        }
                        else if (legendaryMaterials["motes"] >= 250)
                        {
                            itemObtained = "Dragonwrath";
                            legendaryMaterials[itemName] -= 250;
                            isObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(itemName))
                        {
                            junk[itemName] = 0;
                        }
                        junk[itemName] += quantity;
                    }

                }
                if (isObtained == true)
                {
                    break;
                }
            }

            legendaryMaterials = legendaryMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            junk = junk.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine($"{itemObtained} obtained!");

            foreach (var item in legendaryMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
