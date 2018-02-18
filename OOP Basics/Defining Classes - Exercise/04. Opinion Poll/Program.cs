using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] personalInformation = Console.ReadLine().Split(' ');
            string name = personalInformation[0];
            int age = int.Parse(personalInformation[1]);
            if (age > 30)
            {
                Person person = new Person(name, age);
                people.Add(person);
            }
        }

        var peopleOver30 = people.OrderBy(p => p.Name).ToList();

        foreach (var person in peopleOver30)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

