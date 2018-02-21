using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] rectanglesInput = Console.ReadLine().Split()
            .Select(int.Parse).ToArray();
        int numRectangles = rectanglesInput[0];
        int intersectionChecks = rectanglesInput[1];
        Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

        for (int i = 0; i < numRectangles; i++)
        {
            string[] rectangle = Console.ReadLine().Split();
            string id = rectangle[0];
            double width = double.Parse(rectangle[1]);
            double height = double.Parse(rectangle[2]);
            double x = double.Parse(rectangle[3]);
            double y = double.Parse(rectangle[4]);

            rectangles.Add(id, new Rectangle(id, width, height, new Point(x, y)));
        }

        for (double i = 0; i < intersectionChecks; i++)
        {
            string[] pairsId = Console.ReadLine().Split();
            var firstId = pairsId[0];
            var secondId = pairsId[1];

            if(rectangles.ContainsKey(firstId))
            {
                Rectangle firstRectangle = rectangles[firstId];

                if(rectangles.ContainsKey(secondId))
                {
                    Rectangle secondRectangle = rectangles[secondId];
                    Console.WriteLine(firstRectangle.IsIntersect(secondRectangle).ToString().ToLower());
                }
            }

        }
    }
}

