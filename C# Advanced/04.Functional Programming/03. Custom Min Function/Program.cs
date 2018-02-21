using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minFunc = FindMinNum;

            Console.WriteLine(minFunc(numbers));
        }

        private static int FindMinNum(int[] inputArr)
        {
            int minValueNum = int.MaxValue;

            foreach (var num in inputArr)
            {
                if (num <minValueNum)
                {
                    minValueNum = num;
                }
            }
            return minValueNum;
        }
    }
}
