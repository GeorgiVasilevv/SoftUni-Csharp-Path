using System;
using System.Collections.Generic;
using System.Linq;

namespace E09.PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            List<Pokemon> pokemons = new List<Pokemon>();
            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInfo = command.Split();
                string trainerName = trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string pokemonElement = trainerInfo[2];
                int pokemonHealth = int.Parse(trainerInfo[3]);

                Trainer trainer = trainers.Find(t => t.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    trainers.Add(trainer);
                }
                else
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }


            }
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var currTrainer in trainers)
                {
                    currTrainer.CheckPokemon(command);
                }
            }

            foreach (var currTrainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine(currTrainer);
            }
        }
    }
}
