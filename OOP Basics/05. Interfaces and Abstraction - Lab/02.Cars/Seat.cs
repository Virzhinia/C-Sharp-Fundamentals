using System;
using System.Collections.Generic;
using System.Text;


public class Seat:ICar
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

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
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
        sb.AppendLine($"{this.Color} {GetType().Name} {this.Model}");
        sb.AppendLine($"Engine start");
        sb.AppendLine($"Breaaak!");
        return sb.ToString().Trim();
    }
}

