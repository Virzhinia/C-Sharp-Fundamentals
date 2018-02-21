using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4 };
            var newEvenNumbers = numbers
                .Where(n => n % 2 == 0).ToList();

        }
    }
}
