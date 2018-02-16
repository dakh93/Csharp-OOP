using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _13.FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedPerson = Console.ReadLine();


            var input =
                Console.ReadLine()
                    .Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            var parentsDates = new List<string>();
            var childrenDates = new List<string>();

            var data = new Dictionary<string, string>();
            var personBd = new Dictionary<string, string>();

            while (input[0] != "End")
            {


                if (input.Length == 2)
                {
                    var parent = input[0];
                    var child = input[1];
                    data[parent.Trim()] = child.Trim();
                }
                else if (input.Length == 1)
                {
                    var split = input[0].Split(' ');

                    var personName = $"{split[0]} {split[1]}";
                    var personBirth = split[2];

                    personBd[personName] = personBirth.Trim();
                }


                input = Console.ReadLine()
                    .Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }



            Dictionary<string, string> dataSecond = new Dictionary<string, string>();
            foreach (var fill in data)
            {
                var parent = fill.Key;
                var child = fill.Value;

                foreach (var people in personBd)
                {
                    //CHANGE KEY
                    var keySwap = string.Empty;
                    var valueSwap = string.Empty;
                    if (parent.Contains('/'))
                    {
                        //DATE
                        keySwap = personBd.Where(x => x.Value == parent).Select(x => x.Key).First();

                    }
                    else
                    {
                        //NAME
                        keySwap = personBd.Where(x => x.Key == parent).Select(x => x.Value).First();

                    }

                    if (child.Contains('/'))
                    {
                        //DATE
                        valueSwap = personBd.Where(x => x.Value == child).Select(x => x.Key).First();

                    }
                    else
                    {
                        //NAME
                        valueSwap = personBd.Where(x => x.Key == child).Select(x => x.Value).First();

                    }

                    dataSecond[keySwap] = valueSwap;
                }

            }

            var final = new List<Person>();
            foreach (var curr in data)
            {
                var parent = curr.Key;
                var child = curr.Value;

                bool isDatefirst = false;
                if (parent.Contains('/'))
                {
                    isDatefirst = true;
                }

                bool isDateSecond = false;
                if (child.Contains('/'))
                {
                    isDateSecond = true;
                }


                Person person = new Person();
                if (isDatefirst)
                {
                    var name = personBd.Where(x => x.Value == parent).Select(x => x.Key).First();
                    person.Name = name;
                    person.Date = parent;
                }
                else
                {
                    var date = personBd.Where(x => x.Key == parent).Select(x => x.Value).First();
                    person.Name = parent;
                    person.Date = date;
                }
                Person chPerson = new Person();
                if (isDateSecond)
                {
                    var name = personBd.Where(x => x.Value == child).Select(x => x.Key).First();
                    chPerson.Name = name;
                    chPerson.Date = child;
                }
                else
                {
                    var date = personBd.Where(x => x.Key == child).Select(x => x.Value).First();
                    chPerson.Name = parent;
                    chPerson.Date = date;
                }


                if (!final.Any(x => x.Date.Equals(person.Date)))
                {
                    person.Children.Add(chPerson);
                    final.Add(person);
                }
                else
                {
                    if (!person.Children.Any(x => x.Date.Equals(chPerson.Date)))
                    {
                        person.Children.Add(chPerson);
                        final.Add(person);
                    }
                }

                if (!final.Any(x => x.Date.Equals(chPerson.Date)))
                {
                    chPerson.Parents.Add(person);
                   // final.Add(chPerson);
                    
                }
                else
                {
                    if (!chPerson.Parents.Any(x => x.Date.Equals(person.Date)))
                    {
                        chPerson.Parents.Add(person);
                        //final.Add(chPerson);
                    }
                }
            }

           
            
        }

        private static string SearchForParentByName(
            Dictionary<string, string> personBd, string name)
        {
            var result = String.Empty;
            foreach (var person in personBd)
            {
                if (person.Key == name)
                {
                    result = person.Value;
                    break;
                }

            }
            return result;
        }

        private static string SearchForParentByDate(
            Dictionary<string, string> personBd, string date)
        {
            var result = String.Empty;
            foreach (var person in personBd)
            {
                if (person.Value == date)
                {
                    result = person.Key;
                    break;
                }

            }
            return result;
        }
    }

    
    
}
