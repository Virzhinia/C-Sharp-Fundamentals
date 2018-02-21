using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        string input;
        var people = new List<Person>();

        while ((input = Console.ReadLine()) != "End")
        {
            string[] splitInput = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Where(t => t != string.Empty).ToArray();
            var personName = splitInput[0];

            if (!people.Any(p => p.PersonName == personName))
            {
                var newPerson = new Person(personName);
                people.Add(newPerson);
            }

            var currentPerson = people.FirstOrDefault(p => p.PersonName == personName);
            var typeClass = splitInput[1];

            GenerateClasses(splitInput, currentPerson, typeClass);
        }

        string name = Console.ReadLine().Trim();
        var person = people.FirstOrDefault(p => p.PersonName == name);
        Console.WriteLine(person);
    }

    private static void GenerateClasses(string[] splitInput, Person currentPerson, string typeClass)
    {
        switch (typeClass)
        {
            case "company":
                var companyName = splitInput[2];
                var department = splitInput[3];
                decimal salary = decimal.Parse(splitInput[4]);
                currentPerson.Company.Name = companyName;
                currentPerson.Company.Department = department;
                currentPerson.Company.Salary = salary;
                break;
            case "pokemon":
                var pokemonName = splitInput[2];
                var pokemonType = splitInput[3];
                var pokemon = new Pokemon(pokemonName, pokemonType);
                currentPerson.Pokemon.Add(pokemon);
                break;
            case "parents":
                var parentName = splitInput[2];
                var parentBirthday = splitInput[3];
                var parents = new Parents(parentName, parentBirthday);
                currentPerson.Parents.Add(parents);
                break;
            case "children":
                var childrenName = splitInput[2];
                var childrenBirthday = splitInput[3];
                var children = new Children(childrenName, childrenBirthday);
                currentPerson.Children.Add(children);
                break;
            case "car":
                var model = splitInput[2];
                var speed = double.Parse(splitInput[3]);
                currentPerson.Car.Model = model;
                currentPerson.Car.Speed = speed;
                break;
        }
    }
}
