using System;
using System.Collections.Generic;
using System.Text;


public class Animal
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 0 || string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public string Gender
    {
        get { return gender; }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return string.Empty;
    }
}

