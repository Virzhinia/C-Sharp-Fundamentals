using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Stack<int> stackMax = new Stack<int>();
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int operation = input[0];

                switch (operation)
                {
                    case 1:
                        {
                            if (max < input[1])
                            {
                                max = input[1];
                                stackMax.Push(max);
                            }
                            stack.Push(input[1]);
                        }
                            break;
                    case 2:
                        {
                            if (stack.Peek() == stackMax.Peek() && stackMax.Count > 0)
                            {
                                stackMax.Pop();
                                if (stackMax.Count > 0)
                                {
                                    max = stackMax.Peek();
                                }
                                else
                                {
                                    max = int.MinValue;
                                }
                            }
                            stack.Pop();
                        }
                        break;

                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stackMax.Peek());
                        }
                        break;

                }

            }
        }
    }
}
