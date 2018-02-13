using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Sequence_With_Queue
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Queue<long> numbers = new Queue<long>();
            Queue<long> numbersQue = new Queue<long>();
            numbers.Enqueue(n);
            numbersQue.Enqueue(n);

            while (numbersQue.Count < 50)
            {
                long y = numbers.Peek();
                numbers.Enqueue(y + 1);
                numbers.Enqueue(2 * y + 1);
                numbers.Enqueue(y + 2);

                if (numbersQue.Count < 50)
                {
                    numbersQue.Enqueue(y + 1);
                }
                if (numbersQue.Count < 50)
                {
                    numbersQue.Enqueue(2 * y + 1);
                }
                if (numbersQue.Count < 50)
                {
                    numbersQue.Enqueue(y + 2);
                }
                numbers.Dequeue();
            }

            Console.WriteLine(string.Join(" ",numbersQue));
        }
    }
}
