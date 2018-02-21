using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    private double length;

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    private double width;

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    private double height;

    public double Height
    {
        get { return height; }
        set { height = value; }
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
