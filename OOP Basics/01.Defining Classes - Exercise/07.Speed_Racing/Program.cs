using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        string inputCommand;

        for (int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine().Split();
            string model = input[0];
            double fuel = double.Parse(input[1]);
            double fuelFor1km = double.Parse(input[2]);

            var car = new Car(model, fuel, fuelFor1km);
            cars.Add(car);
        }

        while ((inputCommand=Console.ReadLine())!="End")
        {
            string [] splitCommand = inputCommand.Split();
            string model = splitCommand[1];
            double distance = double.Parse(splitCommand[2]);

            CalculateDistance(cars, model, distance);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.Fuel:f2} {(int)car.Distance}");
        }
    }

    private static void CalculateDistance(List<Car> cars, string model, double distance)
    {
        var currentCar = cars.FirstOrDefault(c => c.Model == model);

        if(Car.ContinueDriving(currentCar,distance)==false)
        {
             Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}

