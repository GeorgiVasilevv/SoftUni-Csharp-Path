using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E09.PokemonTrainer
{
    internal class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void CheckPokemon(string element)
        {
            if (Pokemons.Any(p => p.Element == element))
            {
                NumberOfBadges++;
            }
            else
            {
                for (int i = 0; i < Pokemons.Count; i++)
                {
                    Pokemon pokemon = Pokemons[i];

                    pokemon.Health -= 10;

                    if (pokemon.Health <=0)
                    {
                        Pokemons.Remove(pokemon);
                    }
                }
            }
        }

        public override string ToString()
        {
                return $"{this.Name} {this.NumberOfBadges} {this.Pokemons.Count}";
        }
    }
}
