﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06.CompanyRoster
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        private Employee()
        {
            this.Email = "n/a";
            this.Age = -1;
        }

        public Employee
            (string name, decimal salary,
            string position, string department) : this()
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
        }

    }
}
