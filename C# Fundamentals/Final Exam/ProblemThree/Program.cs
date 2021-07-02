using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> personHealth = new Dictionary<string, int>();
            Dictionary<string, int> personEnergy = new Dictionary<string, int>();

            string[] cmds = Console.ReadLine().Split(":");

            while (cmds[0] != "Results")
            {
                string action = cmds[0];

                if (action == "Add")
                {
                    AddingPersons(personHealth, personEnergy, cmds);
                }
                else if (action == "Attack")
                {
                    Attacking(personHealth, personEnergy, cmds);
                }
                else if (action == "Delete")
                {
                    string name = cmds[1];

                    if (name == "All")
                    {
                        personHealth.Clear();
                        personEnergy.Clear();
                    }
                    else
                    {
                        if (personHealth.ContainsKey(name))
                        {
                            personHealth.Remove(name);
                            personEnergy.Remove(name);
                        }
                    }
                }
                cmds = Console.ReadLine().Split(":");
            }

            personHealth = personHealth.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine($"People count: {personHealth.Count}");

            foreach (var kvp in personHealth)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} - {personEnergy[kvp.Key]}");
            }
        }

        private static void Attacking(Dictionary<string, int> personHealth, Dictionary<string, int> personEnergy, string[] cmds)
        {
            string attacker = cmds[1];
            string defender = cmds[2];
            int damage = int.Parse(cmds[3]);

            if (personHealth.ContainsKey(attacker) && personHealth.ContainsKey(defender))
            {
                personHealth[defender] -= damage;
                if (personHealth[defender] <= 0)
                {
                    personHealth.Remove(defender);
                    personEnergy.Remove(defender);
                    Console.WriteLine($"{defender} was disqualified!");
                }

                personEnergy[attacker]--;

                if (personEnergy[attacker] <= 0)
                {
                    personHealth.Remove(attacker);
                    personEnergy.Remove(attacker);
                    Console.WriteLine($"{attacker} was disqualified!");
                }
            }
        }
        
        private static void AddingPersons(Dictionary<string, int> personHealth, Dictionary<string, int> personEnergy, string[] cmds)
        {
            string personName = cmds[1];
            int health = int.Parse(cmds[2]);
            int energy = int.Parse(cmds[3]);

            if (!personHealth.ContainsKey(personName))
            {
                personHealth[personName] = 0;
                personEnergy.Add(personName, energy);
            }
            personHealth[personName] += health;
        }
    }
}
