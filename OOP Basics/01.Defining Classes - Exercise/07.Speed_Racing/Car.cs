using System;
using System.Collections.Generic;
using System.Linq;


public class Car
{
    private string model;
    private double fuel;
    private double fuelPer1km;
    private double distance;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }


    public double Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }

    public double FuelPer1km
    {
        get { return fuelPer1km; }
        set { fuelPer1km = value; }
    }

    public double Distance
    {
        get { return distance; }
        set { distance = value; }
    }


    public Car(string model, double fuel, double fuelPer1km)
    {
        this.Model = model;
        this.Fuel = fuel;
        this.FuelPer1km = fuelPer1km;
        this.Distance = 0;
    }

    public static bool ContinueDriving(Car car, double distance)
    {
        var driveKm = car.Fuel / car.FuelPer1km;
        if (driveKm >= distance)
        {
            car.Fuel -= distance * car.FuelPer1km;
            car.Distance += distance;
            return true;
        }

        return false;
    }

}

