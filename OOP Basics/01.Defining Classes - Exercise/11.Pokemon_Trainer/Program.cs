using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = new List<Trainer>();
        string input;

        while ((input=Console.ReadLine()) != "Tournament")
        {
            CreateTrainersWithPokemons(trainers, input);
        }

        string element;
        while ((element = Console.ReadLine()) != "End")
        {
            CheckPokemonContainsInputElement(trainers, element);

        }

        trainers = trainers.OrderByDescending(t => t.Badges).ToList();

        foreach (var trainer in trainers)
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }

    private static void CreateTrainersWithPokemons(List<Trainer> trainers, string input)
    {
        string[] splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Where(e => e != string.Empty).ToArray();

        var trainerName = splitInput[0];
        var pokemonName = splitInput[1];
        var pokemonElement = splitInput[2];
        var pokemonHealth = double.Parse(splitInput[3]);


        if (!trainers.Any(t => t.Name == trainerName))
        {
            var trainer = new Trainer(trainerName);
            trainers.Add(trainer);
        }

        var currentTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);

        if (!currentTrainer.Pokemons.Any(p => p.Name == trainerName))
        {
            Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            currentTrainer.Pokemons.Add(currentPokemon);
        }
        else
        {
            currentTrainer.Pokemons.FirstOrDefault(p => p.Name == pokemonName).Element = pokemonElement;
            currentTrainer.Pokemons.FirstOrDefault(p => p.Name == pokemonName).Health += pokemonHealth;
        }
    }

    private static void CheckPokemonContainsInputElement(List<Trainer> trainers, string element)
    {
        for (int i = 0; i < trainers.Count; i++)
        {
            var currentTrainer = trainers[i];
            if (currentTrainer.Pokemons.Any(p => p.Element.Equals(element)))
            {
                currentTrainer.Badges++;
            }
            else
            {
                currentTrainer.Pokemons.ForEach(p => p.Health -= 10);
                for (int j = 0; j < currentTrainer.Pokemons.Count; j++)
                {
                    if (currentTrainer.Pokemons[j].Health <= 0)
                    {
                        currentTrainer.Pokemons.RemoveAt(j);
                        j--;
                    }
                }
            }

        }
    }
}

