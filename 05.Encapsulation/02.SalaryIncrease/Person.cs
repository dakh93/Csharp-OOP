using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _02.SalaryIncrease
{



    public class Person
    {
        private string firstName;

        private string lastName;

        private int age;

        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public decimal Salary
        {
            get { return this.salary; }
        }

        public int Age
        {
            get { return this.age; }

        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public void IncreaseSalary(decimal percent)
        {
            var bonus = (salary * percent) / 100;
            if (this.age < 30)
            {
                this.salary += bonus / 2;
            }
            else
            {
                this.salary += bonus;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }

}