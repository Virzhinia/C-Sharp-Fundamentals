﻿using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Employee> employees;
    string name;
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public Department(string name)
    {
        this.Employees = new List<Employee>();
        this.Name = name;
    }

    public List<Employee> Employees
    {
        get { return employees; }
        private set { this.employees = value; }
    }

    public void AddEmployee(Employee employee)
    {
        this.Employees.Add(employee);
    }

    public decimal AverageSalar
    {
        get
        {
            return this.Employees.Select(e => e.Salary).Average();
        }
    }

}