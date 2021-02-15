﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] inputArgs = input.Split();
                string trainerName = inputArgs[0];
                string pokemonName = inputArgs[1];
                string pokemonElement = inputArgs[2];
                int pokemonHealth = int.Parse(inputArgs[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.ContainsKey(trainerName) == false)
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }
                trainers[trainerName].Pokemons.Add(pokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                switch (input)
                {
                    case "Fire":
                        CheckTrainer(trainers, input);
                        break;
                    case "Water":
                        CheckTrainer(trainers, input);
                        break;
                    case "Electricity":
                        CheckTrainer(trainers, input);
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine(trainer);
            }
        }

        private static void CheckTrainer(Dictionary<string, Trainer> trainers, string input)
        {
            foreach (Trainer trainer in trainers.Values)
            {
                if (trainer.Pokemons.Any(p => p.Element == input))
                {
                    trainer.Badges++;
                }
                else
                {
                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }
            }

            foreach (Trainer trainer in trainers.Values)
            {
                for (int i = 0; i < trainer.Pokemons.Count; i++)
                {
                    if (trainer.Pokemons[i].Health <= 0)
                    {
                        trainer.Pokemons.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
    }
}
