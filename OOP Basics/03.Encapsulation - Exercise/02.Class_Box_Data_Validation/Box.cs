using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    private double length;

    public double Length
    {
        get { return length; }
        private set
        {
            ValidateValues("Length", value);
            length = value;
        }
    }

    private double width;

    public double Width
    {
        get { return width; }
        private set
        {
            ValidateValues("Width", value);
            this.width = value;
        }
    }

    private double height;

    public double Height
    {
        get { return height; }
        private set
        {
            ValidateValues("Height", value);
            this.height = value;
        }
    }

    private void ValidateValues(string fieldName, double fieldValue)
    {
        if (fieldValue <= 0)
        {
            throw new ArgumentException($"{fieldName} cannot be zero or negative.");
        }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public void SurfaceArea()
    {
        var surfaceArea = 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
        Console.WriteLine($"Surface Area - {surfaceArea:f2}");
    }

    public void LateralSurfaceArea()
    {
        var lateralArea = 2 * (this.Length * this.Height + this.Width * this.Height);
        Console.WriteLine($"Lateral Surface Area - {lateralArea:f2}");
    }

    public void Volume()
    {
        var volume = this.Height * this.Width * this.Length;
        Console.WriteLine($"Volume - {volume:f2}");
    }
}
