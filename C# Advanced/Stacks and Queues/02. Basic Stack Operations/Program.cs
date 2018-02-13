using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            int[] operations = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsToPush = operations[0];
            int elementsToPop = operations[1];
            int elementsToFind = operations[2];
   
            var stackNumbers = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stackNumbers.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stackNumbers.Pop();
            }

            if (stackNumbers.Contains(elementsToFind))
            {
                Console.WriteLine("true");
            }
            else if(stackNumbers.Count==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int [] stackArr = stackNumbers.ToArray();
                Console.WriteLine(stackArr.Min());
            }
        }
    }
}
