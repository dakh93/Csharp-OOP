using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<Patient>> doctors = new Dictionary<string, List<Patient>>();
            Dictionary<string, List<Patient>> departments = new Dictionary<string, List<Patient>>();


            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] tokens = command.Split();
                var departament = tokens[0];
                var firstName = tokens[1];
                var secondName = tokens[2];
                var patientName = tokens[3];
                var fullName = firstName + secondName;

                Doctor doctor = new Doctor(firstName, secondName);

                Patient patient = new Patient(patientName, departament, doctor);


                if (!doctors.ContainsKey(fullName))
                {
                    doctors.Add(fullName, new List<Patient>());
                }
                if (!departments.ContainsKey(departament))
                {
                    departments.Add(departament, new List<Patient>());
                  
                }

                bool freeSpace = departments[departament].Count < 60;
                if (freeSpace)
                {
                    int room = 0;
                    doctors[fullName].Add(patient);
                   
                    departments[departament].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]].Select(x => x.Name)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    var start = 3 * room - 3;
                    var patients =
                        departments[args[0]]
                        .Skip(start).Take(3)
                        .Select(x => x.Name).OrderBy(x => x).ToList();
                    Console.WriteLine(string.Join("\n", patients));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].Select(x => x.Name).OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
