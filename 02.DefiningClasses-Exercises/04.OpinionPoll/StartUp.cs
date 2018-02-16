using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OpinionPoll
{
    public class StartUp
    {
        public static void Main()
        {
            int peopleNum = int.Parse(Console.ReadLine());

            List<Person> listOfPersons = new List<Person>();

            for (int i = 0; i < peopleNum; i++)
            {
                string[] input =
                    Console.ReadLine()
                        .Split(' ')
                        .ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);

                listOfPersons.Add(new Person(name, age));
            }



            foreach (var person in listOfPersons.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }

}