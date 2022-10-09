using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PokemonTrainer
{
    public class Trainer
    {

        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
            Badges = 0;
        }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        internal void CheckPokemon(string fightElle)
        {
            if (Pokemons.Any(p => p.Element == fightElle))
            {
                Badges++;
            }
            else
            {
                for (int i = 0; i < this.Pokemons.Count; i++)
                {
                    Pokemon currentPokemon = this.Pokemons[i];

                    currentPokemon.Health -= 10;

                    if (currentPokemon.Health <= 0)
                    {
                        this.Pokemons.Remove(currentPokemon);
                    }
                }
            }
        }
    }
}
