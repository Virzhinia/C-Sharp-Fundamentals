using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    const decimal MIN_SALARY = 460;

    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            ValidateFieldLength(value, "First");
            firstName = value;
        }
    }

    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set
        {
            ValidateFieldLength(value, "Last");
            lastName = value;
        }
    }
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }

    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < MIN_SALARY)
            {
                throw new ArgumentException($"Salary cannot be less than {MIN_SALARY} leva!");
            }
            salary = value;
        }
    }


    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public Person(string firstName, string lastName, int age, decimal salary)
        : this(firstName, lastName, age)
    {
        this.Salary = salary;
    }

    private void ValidateFieldLength(string fieldValue, string fieldName)
    {
        if (fieldValue?.Length < 3)
        {
            throw new ArgumentException($"{fieldName} name cannot contain fewer than 3 symbols!");
        }
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age > 30)
        {
            this.Salary += this.Salary * percentage / 100;
        }
        else
        {
            this.Salary += this.Salary * percentage / 200;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:f2} leva.";
    }
}

