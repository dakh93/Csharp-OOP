using System;
using System.Collections.Generic;
using System.Text;

namespace _12.Google
{
    public class Person
    {
        public string Name { get; set; }

        public Car Car { get; set; }

        public Company Company { get; set; }

        public List<Pokemon> Pokemons = new List<Pokemon>();

        public List<Parent> Parents = new List<Parent>();

        public List<Children> Children = new List<Children>();


    }
}
