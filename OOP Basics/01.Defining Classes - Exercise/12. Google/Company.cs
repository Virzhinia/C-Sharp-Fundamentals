﻿using System;
using System.Collections.Generic;
using System.Text;


public class Company
{
    private string name;
    private string department;
    private decimal salary;

    public Company()
    {

    }

    public Company(string name,string department, decimal salary)
    {
        this.Name = name;
        this.Department = department;
        this.Salary = salary;
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}

