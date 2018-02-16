using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _11.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var trainList = new Dictionary<string, Trainer>();
            while (input.Length > 1)
            {

                var trainerName = input[0];
                var pName = input[1];
                var pElement = input[2];
                var pHealth = int.Parse(input[3]);
                Pokemon pokemon = new Pokemon(pName, pElement, pHealth);
                Trainer trainer = new Trainer(trainerName);

                if (!trainList.ContainsKey(trainerName))
                {
                    trainList[trainerName] = trainer;

                }
                trainList[trainerName].Pokemons.Add(pokemon);


                input = Console.ReadLine().Split(' ');
            }


            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainList)
                {

                    if (trainer.Value.Pokemons.Any(x => x.Element.Equals(command)))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        trainList[trainer.Key].Pokemons.ForEach(x => x.Health -= 10);
                        trainList[trainer.Key].Pokemons.RemoveAll(x => x.Health < 1);
                    }

                }
                command = Console.ReadLine();
            }

            foreach (var trainer in trainList.Values.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
