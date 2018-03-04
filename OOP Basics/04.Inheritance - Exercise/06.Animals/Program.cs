using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    var typeOfAnimal = inputLine;
                    var animalTokens = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var animalName = animalTokens[0];
                    var animalAge = int.Parse(animalTokens[1]);
                    var gender = animalTokens[2];
                    switch (typeOfAnimal)
                    {
                        case "Cat":
                            animals.Add(new Cat(animalName, animalAge, gender));
                            break;
                        case "Tomcat":
                            animals.Add(new Tomcat(animalName, animalAge, "Male"));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(animalName, animalAge, "Female"));
                            break;
                        case "Frog":
                            animals.Add(new Frog(animalName, animalAge, gender));
                            break;
                        case "Dog":
                            animals.Add(new Dog(animalName, animalAge, gender));
                            break;

                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            PrintAnimals(animals);
        }

        private static void PrintAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType());
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
