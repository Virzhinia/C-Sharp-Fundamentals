using System;

namespace _01.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var heigh = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, heigh);

            circle.Draw();
            rect.Draw();
        }
    }
}
