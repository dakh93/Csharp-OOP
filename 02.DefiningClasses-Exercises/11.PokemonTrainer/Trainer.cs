using System;
using System.Collections.Generic;
using System.Text;

namespace _11.PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons = new List<Pokemon>();

        public Trainer()
        {
            this.Badges = 0;
        }

        public Trainer(string name)
        {
            this.Name = name;

        }
    }
}
