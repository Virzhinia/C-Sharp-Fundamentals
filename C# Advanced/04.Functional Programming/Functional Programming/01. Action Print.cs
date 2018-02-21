using System;
using System.Linq;
using System.Collections.Generic;

namespace Functional_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string> printAction = s => Console.WriteLine(s);
            Array.ForEach(input, printAction);
        }
    }
}
