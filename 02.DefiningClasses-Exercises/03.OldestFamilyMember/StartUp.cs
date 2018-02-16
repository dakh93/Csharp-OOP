
using System;
using System.Linq;

namespace _03.OldestFamilyMember
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                var input =
                    Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                var name = input[0];
                var age = int.Parse(input[1]);


                family.AddMember(new Person(name, age));

            }






            Console.WriteLine(family.GetOldestMember());


        }
    }

}