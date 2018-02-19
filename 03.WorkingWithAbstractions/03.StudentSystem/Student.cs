using System;
using System.Collections.Generic;
using System.Text;

namespace _03.StudentSystem
{
    public class Student
    {
        public double Grade { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Commentary { get; set; }

        

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }


        public override string ToString()
        {
            return $"{Name} is {Age} years old. ";
        }
    }
    
}
