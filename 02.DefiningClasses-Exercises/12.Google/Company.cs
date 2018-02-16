﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _12.Google
{
    public class Company
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }

        public Company(string name, string department, double salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }
    }
}
