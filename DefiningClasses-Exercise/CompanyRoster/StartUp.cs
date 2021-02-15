﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string name = inputArgs[0];
                decimal salary = decimal.Parse(inputArgs[1]);
                string position = inputArgs[2];
                string department = inputArgs[3];

                Employee employee = new Employee(name, salary, position, department);

                if (inputArgs.Length == 5)
                {
                    if (inputArgs[4].Contains('@'))
                    {
                        employee.Email = inputArgs[4];
                    }
                    else
                    {
                        int age = int.Parse(inputArgs[4]);
                        employee.Age = age;
                    }
                }
                else if (inputArgs.Length == 6)
                {
                    employee.Email = inputArgs[4];
                    employee.Age = int.Parse(inputArgs[5]);
                }

                employees.Add(employee);
            }

            var topDepartment = employees.GroupBy(x => x.Department).ToDictionary(x => x.Key, y => y.Select(s => s)).OrderByDescending(x => x.Value.Average(s => s.Salary)).FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (var item in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:F2} {item.Email} {item.Age}");
            }
        }
    }
}
