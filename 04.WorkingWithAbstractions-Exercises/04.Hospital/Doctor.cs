using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Hospital
{
    class Doctor
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Patient> Patients = new List<Patient>();

        public Doctor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
