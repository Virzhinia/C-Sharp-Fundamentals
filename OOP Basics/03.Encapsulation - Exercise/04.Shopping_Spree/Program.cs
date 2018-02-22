using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>();
        var products = new List<Product>();

        var personAndMoney = Console.ReadLine()
            .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        CreatePerson(personAndMoney, people);

        var productAndCost = Console.ReadLine()
            .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        CreateProducts(productAndCost, products);

        string comand;
        while ((comand = Console.ReadLine()) != "END")
        {
            AddProductsInBag(people, products, comand);
        }

        PrintResults(people);
    }

    private static void CreatePerson(List<string> personAndMoney, List<Person> people)
    {

        foreach (var currentPerson in personAndMoney)
        {
            try
            {
                var currentPersonInfo = currentPerson.Split('=');
                var name = currentPersonInfo[0];
                var money = decimal.Parse(currentPersonInfo[1]);
                var person = new Person(name, money);
                people.Add(person);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
    }

    private static void CreateProducts(List<string> productAndCost, List<Product> products)
    {
        foreach (var currentProduct in productAndCost)
        {
            try
            {
                var currentProductInfo = currentProduct.Split('=');
                var productName = currentProductInfo[0];
                var cost = decimal.Parse(currentProductInfo[1]);
                var product = new Product(productName, cost);
                products.Add(product);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

        }
    }

    private static void AddProductsInBag(List<Person> people, List<Product> products, string comand)
    {
        var tokens = comand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var person = people.FirstOrDefault(x => x.Name == tokens[0]);
        var product = products.FirstOrDefault(x => x.ProductName == tokens[1]);

        if (person != null && product != null)
        {
            if (product.Cost <= person.Money)
            {
                person.BagOfProducts.Add(product);
                person.Money -= product.Cost;

                Console.WriteLine($"{person.Name} bought {product.ProductName}");
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.ProductName}");
            }
        }
    }

    private static void PrintResults(List<Person> people)
    {
        foreach (var person in people)
        {
            if (!person.BagOfProducts.Any())
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
                continue;
            }

            Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
        }
    }
}
