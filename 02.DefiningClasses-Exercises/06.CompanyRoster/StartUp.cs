using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRoster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var input =
                    Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                Employee currentEmp = new Employee(
                    name, salary, position, department);

                if (input.Length == 5)
                {
                    if (input[4].Contains("@"))
                    {
                         currentEmp.Email = input[4];
                    }
                    else
                    {
                        currentEmp.Age = int.Parse(input[4]);
                    }
                }
                else if (input.Length > 5)
                {
                    currentEmp.Email = input[4];
                    currentEmp.Age = int.Parse(input[5]);
                }
                employees.Add(currentEmp);

            }


            var result = employees
                .GroupBy(x => x.Department)
                .Select(d => new
                {
                    Department = d.Key,
                    AverageSalary = d.Average(s => s.Salary),
                    Employees = d.OrderByDescending(emp => emp.Salary)
                })
                .OrderByDescending(x => x.AverageSalary)
                .FirstOrDefault();
            
            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
