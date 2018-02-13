using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int divisor = int.Parse(Console.ReadLine());

            inputNumbers = inputNumbers.Where(n => n % divisor != 0).ToList();
            inputNumbers.Reverse();

            Console.WriteLine(string.Join(" ", inputNumbers));
        }

        
    }
}
