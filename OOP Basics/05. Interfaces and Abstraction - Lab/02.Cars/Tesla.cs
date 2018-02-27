using System;
using System.Collections.Generic;
using System.Text;


public class Tesla:ICar,IElectricCar
{
    private string model;

    public string Model
    {
        get { return model; }
        private set { model = value; }
    }
    private string color;

    public string Color
    {
        get { return color; }
        private set { color = value; }
    }
    private int batteries;

    public int Batteries
    {
        get { return batteries; }
        private set { batteries = value; }
    }

    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Batteries = batteries;
    }

    public string Start()
    {
        throw new System.NotImplementedException();
    }

    public string Stop()
    {
        throw new System.NotImplementedException();
    }


    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {GetType().Name} {this.Model} with {this.Batteries} Batteries");
        sb.AppendLine($"Engine start");
        sb.AppendLine($"Breaaak!");
        return sb.ToString().Trim();
    }
}

