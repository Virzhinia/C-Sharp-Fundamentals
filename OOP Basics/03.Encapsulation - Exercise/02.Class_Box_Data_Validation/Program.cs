using System;
class Program
{
    static void Main(string[] args)
    {

        try
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var box = new Box(length, width, height);

            box.SurfaceArea();
            box.LateralSurfaceArea();
            box.Volume();
        }
        catch (ArgumentException argEx)
        {

            Console.WriteLine(argEx.Message);

        }

    }
}

