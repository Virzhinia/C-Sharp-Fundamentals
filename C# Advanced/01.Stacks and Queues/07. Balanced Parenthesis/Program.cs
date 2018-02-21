using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }

            bool isBalanced = true;

            char[] openingElements = new[] { '(', '[', '{' };
            char[] closingElements = new[] { ')', ']', '}' };

            foreach (var element in input)
            {
                if (openingElements.Contains(element))
                {
                    stack.Push(element);
                }
                else if (closingElements.Contains(element))
                {
                    var lastOpeningElement = stack.Pop();
                    int openingIndex = Array.IndexOf(openingElements, lastOpeningElement);

                    int closingIndex = Array.IndexOf(closingElements, element);

                    if (openingIndex != closingIndex)
                    {
                        isBalanced = false;
                    }
                }

            }

            if (stack.Any())
            {
                isBalanced = false;
            }

            //  foreach (var item in input)
            //  {
            //      stack.Push(item);
            //      queue.Enqueue(item);
            //  }
            //
            //  int endLoop = stack.Count / 2;
            //
            //  for (int i = 0; i < endLoop; i++)
            //  {
            //      var opening = queue.Dequeue();
            //      var closing = stack.Pop();
            //
            //      switch (opening)
            //      {
            //          case '{': if (closing == '}')
            //                  {
            //                      isBalanced = true;
            //                  }
            //          else
            //                  {
            //                      isBalanced = false;
            //                  }
            //                  break;
            //              
            //          case '[': if (closing == ']')
            //              {
            //                  isBalanced = true;
            //              }
            //          else
            //              {
            //                  isBalanced = false;
            //              }
            //              break;
            //
            //          case '(': if (closing == ')')
            //              {
            //                  isBalanced = true;
            //              }
            //          else
            //              {
            //                  isBalanced = false;
            //              }
            //              break;
            //
            //      }
            //  }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
          else
            {
                Console.WriteLine("NO");

            }


        }
    }
}
