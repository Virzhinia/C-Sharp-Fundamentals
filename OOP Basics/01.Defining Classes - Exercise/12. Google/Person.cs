using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string personName;
    private Company company;
    private List<Pokemon> pokemon;
    private List<Parents> parents;
    private List<Children> children;
    private Car car;

    public Person(string name)
    {
        this.PersonName = name;
        this.Company = new Company();
        this.Pokemon = new List<Pokemon>();
        this.Parents = new List<Parents>();
        this.Children = new List<Children>();
        this.Car = new Car();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.PersonName);
        sb.AppendLine($"Company:");
        if (this.Company.Name != null)
        {
            sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:F2}");
        }

        sb.AppendLine($"Car:");

        if (this.Car.Model != null)
        {
            sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
        }

        sb.AppendLine($"Pokemon:");
        foreach (var pokemon in this.Pokemon)
        {
            sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
        }

        sb.AppendLine($"Parents:");
        foreach (var parent in this.Parents)
        {
            sb.AppendLine($"{parent.Name} {parent.Birthday}");
        }

        sb.AppendLine($"Children:");
        foreach (var child in this.Children)
        {
            sb.AppendLine($"{child.Name} {child.Birthday}");
        }

        return sb.ToString().Trim();
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }


    public List<Children> Children
    {
        get { return children; }
        set { children = value; }
    }


    public List<Parents> Parents
    {
        get { return parents; }
        set { parents = value; }
    }


    public List<Pokemon> Pokemon
    {
        get { return pokemon; }
        set { pokemon = value; }
    }


    public Company Company
    {
        get { return company; }
        set { company = value; }
    }

    public string PersonName
    {
        get { return personName; }
        set { personName = value; }
    }

}

