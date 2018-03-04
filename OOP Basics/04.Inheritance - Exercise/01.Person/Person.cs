using System;

public class Person
{
    private const int MIN_AGE = 0;
    private string name;
    private int age;

    public virtual int Age
    {
        get { return this.age; }
        set
        {
            if (value < MIN_AGE)
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }


    public virtual string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
            name = value;
        }
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        return $"Name: {this.Name}, Age: {this.Age}";
    }

}

