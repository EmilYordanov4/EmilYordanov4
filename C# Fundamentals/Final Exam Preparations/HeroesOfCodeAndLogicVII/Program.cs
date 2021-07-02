using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroHP = new Dictionary<string, int>();
            Dictionary<string, int> heroMP = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            AddingHeroes(heroHP, heroMP, n);

            string[] cmd = Console.ReadLine().Split(" - ");

            while (cmd[0] != "End")
            {
                string action = cmd[0];

                if (action == "CastSpell")
                {
                    CastingSpell(heroMP, cmd);
                }
                else if (action == "TakeDamage")
                {
                    TakingDamage(heroHP, heroMP, cmd);
                }
                else if (action == "Recharge")
                {
                    RechargingMana(heroMP, cmd);
                }
                else if (action == "Heal")
                {
                    HealingHealth(heroHP, cmd);
                }
                cmd = Console.ReadLine().Split(" - ");
            }

            heroHP = heroHP.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in heroHP)
            {
                Console.WriteLine($"{kvp.Key}");
                Console.WriteLine($"  HP: {kvp.Value}");
                Console.WriteLine($"  MP: {heroMP[kvp.Key]}");
            }

        }

        private static void HealingHealth(Dictionary<string, int> heroHP, string[] cmd)
        {
            string heroName = cmd[1];
            int amount = int.Parse(cmd[2]);
            int startingHP = heroHP[heroName];
            heroHP[heroName] += amount;
            if (heroHP[heroName] > 100)
            {
                Console.WriteLine($"{heroName} healed for {100 - startingHP} HP!");
                heroHP[heroName] = 100;
            }
            else
            {
                Console.WriteLine($"{heroName} healed for {amount} HP!");

            }
        }

        private static void RechargingMana(Dictionary<string, int> heroMP, string[] cmd)
        {
            string heroName = cmd[1];
            int amount = int.Parse(cmd[2]);
            int startingMP = heroMP[heroName];
            heroMP[heroName] += amount;
            if (heroMP[heroName] > 200)
            {
                Console.WriteLine($"{heroName} recharged for {200 - startingMP} MP!");
                heroMP[heroName] = 200;
            }
            else
            {
                Console.WriteLine($"{heroName} recharged for {amount} MP!");
            }
        }

        private static void TakingDamage(Dictionary<string, int> heroHP, Dictionary<string, int> heroMP, string[] cmd)
        {
            string heroName = cmd[1];
            int damage = int.Parse(cmd[2]);
            string attacker = cmd[3];

            heroHP[heroName] -= damage;
            if (heroHP[heroName] > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroHP[heroName]} HP left!");
            }
            else
            {
                heroHP.Remove(heroName);
                heroMP.Remove(heroName);
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
            }
        }

        private static void CastingSpell(Dictionary<string, int> heroMP, string[] cmd)
        {
            string heroName = cmd[1];
            int manaNeeded = int.Parse(cmd[2]);
            string spellName = cmd[3];

            if (manaNeeded <= heroMP[heroName])
            {
                heroMP[heroName] -= manaNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMP[heroName]} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }

        private static void AddingHeroes(Dictionary<string, int> heroHP, Dictionary<string, int> heroMP, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] heroInfo = Console.ReadLine().Split();
                string heroName = heroInfo[0];
                int heroHealth = int.Parse(heroInfo[1]);
                int heroMana = int.Parse(heroInfo[2]);

                heroHP.Add(heroName, heroHealth);
                heroMP.Add(heroName, heroMana);
            }
        }
    }
}
