
using System.Collections.Generic;
using System.Linq;
using _03.OldestFamilyMember;

namespace _03.OldestFamilyMember
{
    class Family
    {
        public List<Person> People = new List<Person>();



        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldest = this.People.OrderByDescending(x => x.Age).First();
            return oldest;
        }
    }
}
