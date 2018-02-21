using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int carsCount = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < carsCount; i++)
        {
            string[] input = Console.ReadLine().Split();
            string model = input[0];
            int engineSpeed = int.Parse(input[1]);
            int enginePower = int.Parse(input[2]);
            var engine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(input[3]);
            string cargoType = input[4];
            var cargo = new Cargo(cargoWeight, cargoType);

            var tires = new Tire[4];
            double tire1Pressure = double.Parse(input[5]);
            int tire1Age = int.Parse(input[6]);
            var tire1 = new Tire(tire1Pressure, tire1Age);
            tires[0] = tire1;

            double tire2Pressure = double.Parse(input[7]);
            int tire2Age = int.Parse(input[8]);
            var tire2 = new Tire(tire2Pressure, tire2Age);
            tires[1] = tire2;

            double tire3Pressure = double.Parse(input[9]);
            int tire3Age = int.Parse(input[10]);
            var tire3 = new Tire(tire3Pressure, tire3Age);
            tires[2] = tire3;

            double tire4Pressure = double.Parse(input[11]);
            int tire4Age = int.Parse(input[12]);
            var tire4 = new Tire(tire4Pressure, tire4Age);
            tires[3] = tire4;

            var currentCar = new Car(model, engine, cargo);
            currentCar.Tires = tires;
            cars.Add(currentCar);
        }

        string command = Console.ReadLine();
        var resultCars = new List<Car>();

        switch (command)
        {
            case "fragile":
                resultCars = cars.Where(c => c.Cargo.CargoType.Equals("fragile") && c.Tires.Any(t => t.Pressure < 1)).ToList();
                break;
            case "flamable":
                resultCars = cars.Where(c => c.Cargo.CargoType.Equals("flamable") && c.Engine.EnginePower > 250).ToList();
                break;
        }

        PrintResultCars(resultCars);
    }

    private static void PrintResultCars(List<Car> resultCars)
    {
        foreach (var car in resultCars)
        {
            Console.WriteLine(car.Model);
        }
    }
}

