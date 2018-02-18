using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Department> departments = new List<Department>();


        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string depName = input[3];

            if (!departments.Any(d => d.Name == depName))
            {
                Department dep = new Department(depName);
                departments.Add(dep);
            }
            var department = departments.FirstOrDefault(d => d.Name == depName);
            Employee employee = ParseEmployee(input);
            department.AddEmployee(employee);
        }

        var highestAvgDep = departments.OrderByDescending(d => d.AverageSalar).First();

        Console.WriteLine($"Highest Average Salary: {highestAvgDep.Name}");

        foreach (var emp in highestAvgDep.Employees.OrderByDescending(e=>e.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
        }
    }
    static Employee ParseEmployee(string[] input)
    {
        string name = input[0];
        decimal salary = decimal.Parse(input[1]);
        string position = input[2];
        string email = "n/a";
        int age=-1;

        if (input.Length == 6)
        {
            email = input[4];
            age = int.Parse(input[5]);
        }

        else if (input.Length == 5)
        {
            bool isAge = int.TryParse(input[4], out age);
            if (!isAge)
            {
                email = input[4];
                age = -1;
            }
        }

        Employee employee = new Employee(name, position, salary, age, email);
        return employee;
    }
}
