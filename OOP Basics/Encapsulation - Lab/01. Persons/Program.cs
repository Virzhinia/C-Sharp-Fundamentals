using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int namesCount = int.Parse(Console.ReadLine());
        var people = new List<Person>();

        for (int i = 0; i < namesCount; i++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0], input[1], int.Parse(input[2]));

            people.Add(person);
        }

        people.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
    }
}

