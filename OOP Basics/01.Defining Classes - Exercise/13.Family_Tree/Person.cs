using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string firstName;
    private string lastName;
    private string birthday;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
    }

    public Person(string firstName, string lastName, string birthday)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Birthday = birthday;
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.FirstName} {this.LastName} {this.Birthday}");
        sb.AppendLine($"Parents:");

        foreach (var parent in this.Parents)
        {
            sb.AppendLine($"{parent.FirstName} {parent.LastName} {parent.Birthday}");
        }

        sb.AppendLine($"Children:");
        foreach (var child in this.Children)
        {
            sb.AppendLine($"{child.FirstName} {child.LastName} {child.Birthday}");
        }

        return sb.ToString().Trim();
    }
    public List<Person> Children
    {
        get { return children; }
        set { children = value; }
    }

    public List<Person> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public string Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

}
