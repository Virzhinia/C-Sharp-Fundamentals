﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class CarSalesman
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();
        int engineCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < engineCount; i++)
        {
            AddEngines(engines);
        }

        int carCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carCount; i++)
        {
            AddCars(cars, engines);
        }

        PrintCars(cars);
    }

    private static void AddCars(List<Car> cars, List<Engine> engines)
    {
        string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string model = parameters[0];
        string engineModel = parameters[1];
        Engine engine = engines.FirstOrDefault(x => x.model == engineModel);

        int weight = -1;
        ChechParametresForCar(cars, parameters, model, engine, weight);
    }

    private static int ChechParametresForCar(List<Car> cars, string[] parameters, string model, Engine engine, int weight)
    {
        if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
        {
            cars.Add(new Car(model, engine, weight));
        }
        else if (parameters.Length == 3)
        {
            string color = parameters[2];
            cars.Add(new Car(model, engine, color));
        }
        else if (parameters.Length == 4)
        {
            string color = parameters[3];
            cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
        }
        else
        {
            cars.Add(new Car(model, engine));
        }

        return weight;
    }

    private static void AddEngines(List<Engine> engines)
    {
        string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string model = parameters[0];
        int power = int.Parse(parameters[1]);

        int displacement = -1;
        CheckParametresLenght(engines, parameters, model, power, displacement);
    }

    private static int CheckParametresLenght(List<Engine> engines, string[] parameters, string model, int power, int displacement)
    {
        if (parameters.Length == 3 && int.TryParse(parameters[2], out displacement))
        {
            engines.Add(new Engine(model, power, displacement));
        }
        else if (parameters.Length == 3)
        {
            string efficiency = parameters[2];
            engines.Add(new Engine(model, power, efficiency));
        }
        else if (parameters.Length == 4)
        {
            string efficiency = parameters[3];
            engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
        }
        else
        {
            engines.Add(new Engine(model, power));
        }

        return displacement;
    }

    private static void PrintCars(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}