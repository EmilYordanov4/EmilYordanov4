using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (info[0] != "Tournament")
            {
                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);

                Pokemon newPokemon = new Pokemon();
                newPokemon.Name = pokemonName;
                newPokemon.Element = pokemonElement;
                newPokemon.Health = pokemonHealth;
                Trainer newTrainer = new Trainer(trainerName, newPokemon);
                if (trainers.Any(x => x.Name == trainerName))
                {
                    trainers.FirstOrDefault(x => x.Name == trainerName).Pokemons.Add(newPokemon);
                }
                else
                {
                    trainers.Add(newTrainer);
                }


                info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string element = Console.ReadLine();
            while (element != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (trainers[i].Pokemons.Any(x => x.Element == element))
                    {
                        trainers[i].Badges++;
                    }
                    else
                    {
                        trainers[i].Pokemons.Select(x => x.Health -= 10).ToList();
                        trainers[i].Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
                element = Console.ReadLine();
            }

            foreach (var item in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{item.Name} {item.Badges} {item.Pokemons.Count}");
            }
        }
    }
}
