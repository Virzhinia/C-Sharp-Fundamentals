using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            
            Stack<long> fibonacciStack = new Stack<long>();

            fibonacciStack.Push(0);
            fibonacciStack.Push(1);

            while (fibonacciStack.Count <= n )
            {
                long popElement = fibonacciStack.Pop();
                long peekElement = fibonacciStack.Peek();
                long newElement = popElement + peekElement;

                fibonacciStack.Push(popElement);
                fibonacciStack.Push(newElement);
            }
            
            Console.WriteLine(fibonacciStack.Peek());
        }
    }
}
