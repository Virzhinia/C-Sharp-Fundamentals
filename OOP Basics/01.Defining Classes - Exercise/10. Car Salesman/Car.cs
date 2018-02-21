using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public Car (string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = "n/a";
        this.Color = "n/a";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Model}:");
        sb.AppendLine($"  {this.Engine.Model}:");
        sb.AppendLine($"    Power: {this.Engine.Power}");
        sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
        sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
        sb.AppendLine($"  Weight: {this.Weight}");
        sb.AppendLine($"  Color: {this.Color}");

        return sb.ToString().Trim();
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

}
