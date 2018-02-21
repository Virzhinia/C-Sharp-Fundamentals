using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            
            Console.Write(string.Join(" ", stack));
            Console.WriteLine();   
        }
    }
}
