using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace _12.Google
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var command =
                Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            var persons = new Dictionary<string, Person>();
            while (command.Length > 1)
            {
                var name = command[0];
                var collection = command[1];

                Person person = new Person();

                person.Name = name;

                if (!persons.ContainsKey(name))
                {
                    persons[name] = new Person();
                    
                }

                switch (collection)
                {
                    case "company":
                        var cName = command[2];
                        var cDep = command[3];
                        var cSal = double.Parse(command[4]);

                        Company company = new Company(cName, cDep, cSal);

                        persons[name].Company = company;

                        break;
                    case "car":
                        var carModel = command[2];
                        var speed = int.Parse(command[3]);

                        Car car = new Car(carModel, speed);

                        persons[name].Car = car;
                        break;
                    case "pokemon":
                        var pName = command[2];
                        var pType = command[3];

                        Pokemon pokemon = new Pokemon(pName, pType);

                        persons[name].Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        var parName = command[2];
                        var parBd = command[3];

                        Parent parent = new Parent(parName, parBd);

                        persons[name].Parents.Add(parent);
                        break;
                    case "children":
                        var chName = command[2];
                        var chBd = command[3];

                        Children child = new Children(chName, chBd);

                        persons[name].Children.Add(child);
                        break;
                }

                command =
                    Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
            }

            var nameInfo = Console.ReadLine();

            var currPer = persons[nameInfo];
            Console.WriteLine(nameInfo);
            Console.WriteLine("Company:");
            if (persons[nameInfo].Company != null)
            {
                var comp = persons[nameInfo].Company;
                Console.WriteLine($"{comp.Name} {comp.Department} {comp.Salary:f2}");
            }
            Console.WriteLine("Car:");
            if (currPer.Car != null)
            {
                var car = persons[nameInfo].Car;
                Console.WriteLine($"{car.Model} {car.Speed}");
            }
            Console.WriteLine("Pokemon:");
            if (currPer.Pokemons != null)
            {
                var pok = persons[nameInfo].Pokemons;

                foreach (var pokemon in pok)
                {
                    Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
                }
            }
            Console.WriteLine("Parents:");
            if (currPer.Parents != null)
            {
                var parents = persons[nameInfo].Parents;
                foreach (var parent in parents)
                {
                    Console.WriteLine($"{parent.Name} {parent.Birthday}");
                }
            }
            Console.WriteLine("Children:");
            if (currPer.Children != null)
            {
                var children = persons[nameInfo].Children;
                foreach (var child in children)
                {
                    Console.WriteLine($"{child.Name} {child.Birthday}");
                }
            }
        }
    }
}
