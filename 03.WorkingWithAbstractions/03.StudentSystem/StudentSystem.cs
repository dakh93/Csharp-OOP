using System;
using System.Collections.Generic;
using System.Text;

namespace _03.StudentSystem
{
    class StudentSystem
    {
        public Dictionary<string, Student> Repo = new Dictionary<string, Student>();

        public void ParseCommand(string[] args)
        {

            if (args[0] == "Create")
            {
                var name = args[1];
                var age = int.Parse(args[2]);
                var grade = double.Parse(args[3]);
                if (!Repo.ContainsKey(name))
                {
                    var student = new Student(name, age, grade);
                    Repo[name] = student;
                }
            }
            else if (args[0] == "Show")
            {
                var name = args[1];
                if (Repo.ContainsKey(name))
                {
                    
                    var commentary = AddCommentary(name);

                    Console.WriteLine(Repo[name].ToString() + commentary);
                }
            }
           
        }

        private string AddCommentary(string name)
        {
            if (Repo[name].Grade >= 5.00)
            {
                return  "Excellent student.";
            }
            else if (Repo[name].Grade < 5.00 && Repo[name].Grade >= 3.50)
            {
                return "Average student.";
            }
            else
            {
                return "Very nice person.";
            }
        }
    }
}
