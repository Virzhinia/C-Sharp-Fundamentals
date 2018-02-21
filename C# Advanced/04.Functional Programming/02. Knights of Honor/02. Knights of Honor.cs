using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string> printAction = s => Console.WriteLine("Sir " + s);
            Array.ForEach(names, printAction);
        }
    }
}
