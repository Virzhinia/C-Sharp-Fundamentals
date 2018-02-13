using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            List<int> numbers = new List<int>();

            Func<int, bool> FindNums = CreatePredicate(divisors);

            for (int i = 1; i <= end; i++)
            {
                if (FindNums(i))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static Func<int, bool> CreatePredicate(int[] divisors)
        {
            return num =>
            {
                foreach (var divisor in divisors)
                {
                    if (num % divisor != 0)
                    {
                        return false;
                    }
                }

                return true;

            };
        }
    }
}
