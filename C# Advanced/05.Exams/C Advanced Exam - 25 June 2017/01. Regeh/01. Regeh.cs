using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\[[a-zA-Z]+<(\d+)REGEH(\d+)>[a-zA-Z]+\]";

            var input = Console.ReadLine();
            var regex = new Regex(pattern);

            var indexes = new List<int>();
            foreach (Match match in regex.Matches(input))
            {
                var number = int.Parse(match.Groups[1].Value);
                indexes.Add(number);

                var number2 = int.Parse(match.Groups[2].Value);
                indexes.Add(number2);
            }

            int currentIndex = 0;
            foreach (var index in indexes)
            {
                currentIndex += index;
                var charIndex = currentIndex % (input.Length - 1);
                Console.Write(input[charIndex]);
            }

            Console.WriteLine();
        }
    }
}
