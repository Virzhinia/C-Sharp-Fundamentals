using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            string command = Console.ReadLine().ToLower();

            int start = inputNumbers[0];
            int end = inputNumbers[1];

            Predicate<int> predicate = new Predicate<int>(EvenNums);

            for (int num = start; num <= end; num++)
            {
                if (command == "even" && predicate(num))
                {
                    Console.Write($"{num} ");
                }
                else if (command== "odd" && !predicate(num))
                {
                    Console.Write($"{num} ");
                }

            }
            Console.WriteLine();

        }

        private static bool EvenNums(int number)
        {
            return number % 2 == 0;
        }
    }
}
