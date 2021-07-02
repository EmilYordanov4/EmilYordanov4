using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; } = 0;
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Pokemons.Add(pokemon);
        }
    }
}
