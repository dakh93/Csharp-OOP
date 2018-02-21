using System;


    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Team team = new Team("SoftUni");
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var firstName = input[0];
                var lastName = input[1];
                var age = int.Parse(input[2]);
                var salary = decimal.Parse(input[3]);

                Person person =
                    new Person(firstName, lastName, age, salary);

                team.AddPlayer(person); 
            }

            team.GetPlayersCount();
        }
    }

