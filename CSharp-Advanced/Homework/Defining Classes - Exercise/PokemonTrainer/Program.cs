using System;
using System.Linq;
using System.Collections.Generic;
namespace PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            List<Trainer> trainers = new List<Trainer>();
            while (input[0] != "Tournament")
            {
                Trainer trainer = trainers.SingleOrDefault(n => n.Name == input[0]);
                if (trainer == null)
                {
                    trainer = new Trainer(input[0]);
                    trainer.Pokemons.Add(new Pokemon(input[1], input[2], int.Parse(input[3])));
                    trainers.Add(trainer);
                }
                else
                {
                    trainer.Pokemons.Add(new Pokemon(input[1], input[2], int.Parse(input[3])));
                }
                input = Console.ReadLine().Split().ToList();
            }
            string fightElle = Console.ReadLine();

            while (fightElle != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.CheckPokemon(fightElle);
                }
                fightElle = Console.ReadLine();
            }
            trainers= trainers.OrderByDescending(x => x.Badges).ToList();
            foreach (var tr in trainers)
            {
                Console.WriteLine($"{tr.Name} {tr.Badges} {tr.Pokemons.Count}");
            }
        }
    }
}
