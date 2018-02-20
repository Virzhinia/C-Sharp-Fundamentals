using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
    private List<Person> firstTeam;

    public IReadOnlyList<Person> FirstTeam
    {
        get { return firstTeam; }
    }
    private List<Person> reserveTeam;

    public IReadOnlyList<Person> ReserveTeam
    {
        get { return reserveTeam; }
    }

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Team(string name)
    {
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
        this.name = name;
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }
}

