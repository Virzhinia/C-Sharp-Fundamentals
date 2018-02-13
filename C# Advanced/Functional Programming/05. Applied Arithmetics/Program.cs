using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command;

            while ((command=Console.ReadLine().ToLower()) != "end")
            {
                switch (command)
                {
                    case "add": inputNumbers = inputNumbers
                            .Select(n => n+1).ToArray();
                        break;
                    case "multiply": inputNumbers = inputNumbers
                            .Select(n => n * 2).ToArray();
                        break;
                    case "subtract": inputNumbers = inputNumbers
                            .Select(n => n - 1).ToArray();
                        break;
                    case "print":Print(inputNumbers);
                        break;
                }

            }
        }

        private static void Print(int[] inputNumbers)
        {
            Action<int> PrintAction = n => Console.Write($"{n} ");
            Array.ForEach(inputNumbers,PrintAction);
            Console.WriteLine();
        }
    }
}
