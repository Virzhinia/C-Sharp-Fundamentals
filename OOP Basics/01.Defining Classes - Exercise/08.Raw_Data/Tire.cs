using System;
using System.Collections.Generic;
using System.Text;


class Tire
{
    private double pressure;
    private int tireAge;

    public int TireAge
    {
        get { return tireAge; }
        set { tireAge = value; }
    }

    public double Pressure
    {
        get { return pressure; }
        set { pressure = value; }
    }

    public Tire(double pressure, int age)
    {
        this.Pressure = pressure;
        this.TireAge = age;
    }
}
