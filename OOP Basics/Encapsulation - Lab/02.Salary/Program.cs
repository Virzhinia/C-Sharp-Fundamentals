﻿using System;
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
            var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));

            people.Add(person);
        }

        var percentage = decimal.Parse(Console.ReadLine());
        people.ForEach(p => p.IncreaseSalary(percentage));
        people.ForEach(p => Console.WriteLine(p.ToString()));
    }
}

