using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numsOfEngines = int.Parse(Console.ReadLine());
        var enginesList = new List<Engine>();

        for (int i = 0; i < numsOfEngines; i++)
        {
            string[] engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = engineInfo[0];
            var power = engineInfo[1];

            var engine = new Engine(model, power);

            if (engineInfo.Length >= 3)
            {
                if (engineInfo[2].All(e => char.IsDigit(e)))
                {
                    var displacement = engineInfo[2];
                    engine.Displacement = displacement;
                }
                else
                {
                    var efficiency = engineInfo[2];
                    engine.Efficiency = efficiency;
                }
            }

            if (engineInfo.Length == 4)
            {
                engine.Efficiency = engineInfo[3];
            }

            enginesList.Add(engine);
        }

        int carsNums = int.Parse(Console.ReadLine());
        var carsList = new List<Car>();

        for (int i = 0; i < carsNums; i++)
        {
            string[] carsInfo = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var model = carsInfo[0];
            var engineCar = carsInfo[1];
            var currentCar = new Car(model, enginesList.FirstOrDefault((e => e.Model.Equals(engineCar))));

            if (carsInfo.Length >= 3)
            {
                if (carsInfo[2].All(c => char.IsDigit(c)))
                {
                    var weight = carsInfo[2];
                    currentCar.Weight = weight;
                }
                else
                {
                    var color = carsInfo[2];
                    currentCar.Color = color;
                }


            }
            if (carsInfo.Length == 4)
            {
                var color = carsInfo[3];
                currentCar.Color = color;
            }

            carsList.Add(currentCar);
        }

        PrintCars(carsList);
    }

    private static void PrintCars(List<Car> carsList)
    {
        foreach (var car in carsList)
        {
            Console.WriteLine(car);
        }
    }
}

