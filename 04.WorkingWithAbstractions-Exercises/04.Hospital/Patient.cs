using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Hospital
{
    class Patient
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public Doctor Doctor { get; set; }

        public Patient(string name, string department, Doctor doctor)
        {
            Name = name;
            Department = department;
            Doctor = doctor;
        }
    }
}
