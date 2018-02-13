using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
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

            var stackNumbers = new Queue<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stackNumbers.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stackNumbers.Dequeue();
            }

            if (stackNumbers.Contains(elementsToFind))
            {
                Console.WriteLine("true");
            }
            else if (stackNumbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int[] stackArr = stackNumbers.ToArray();
                Console.WriteLine(stackArr.Min());
            }
        }
    }
}
