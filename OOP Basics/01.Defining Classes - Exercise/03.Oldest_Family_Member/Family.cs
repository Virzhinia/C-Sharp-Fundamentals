using System;
using System.Collections.Generic;
using System.Linq;

public class Family
{
    public Family()
    {
        this.People = new List<Person>();
    }
    public List<Person> People { get; set;}

    public void AddMember(Person member)
    {
        this.People.Add(member);
    }

    public Person GetOldestMember(List<Person> people)
    {
        return people.FirstOrDefault(p => p.Age == people.Max(x => x.Age));
    }
}
