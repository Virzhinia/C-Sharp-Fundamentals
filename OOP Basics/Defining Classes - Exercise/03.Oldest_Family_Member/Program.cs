using System;


public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Family people = new Family();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);
            var person = new Person(name,age);

            people.AddMember(person);
        }

        var oldestMember = people.GetOldestMember(people.People);
        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}

