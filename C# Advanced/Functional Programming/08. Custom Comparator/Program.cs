using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            Func<int, bool> evenNum = n => n % 2 == 0;

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            foreach (var num in inputNumbers)
            {
                if(evenNum(num))
                {
                    evenNumbers.Add(num);
                }
                else
                {
                    oddNumbers.Add(num);
                }
            }

            evenNumbers.Sort();
            oddNumbers.Sort();

            Console.WriteLine(string.Join(" ", evenNumbers.Concat(oddNumbers)));

        }
    }
}
