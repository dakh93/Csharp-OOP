using System;
using System.Collections.Generic;
using System.Text;


    public class Team
    {
        private string name;

        private List<Person> firstTeam = new List<Person>();

        private List<Person> reserveTeam = new List<Person>();

        public Team(string name)
        {
            this.name = name;
        }

        public List<Person> FirstTeam
        {
            get { return this.firstTeam; }
            
        }

        public List<Person> ReserveTeam
        {
            get { return this.reserveTeam; }
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        public void GetPlayersCount()
        {
            Console.WriteLine($"First team has {firstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {reserveTeam.Count} players.");
        }
    }

