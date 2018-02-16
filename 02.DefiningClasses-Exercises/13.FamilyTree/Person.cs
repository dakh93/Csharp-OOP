using System;
using System.Collections.Generic;
using System.Text;

namespace _13.FamilyTree
{
    class Person
    {
        public string Name { get; set; }

        public string Date { get; set; }

        public List<Person> Parents = new List<Person>();

        public List<Person> Children = new List<Person>();
    }
}
