﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCOunt = int.Parse(Console.ReadLine());
            Stack<string> oldVersions = new Stack<string>();
            oldVersions.Push("");

            var text = new StringBuilder();

            for (int i = 0; i < commandsCOunt; i++)
            {
                string [] commandInput = Console.ReadLine().Split();
                int command = int.Parse(commandInput[0]);


                switch (command)
                {
                    case 1:
                        oldVersions.Push(text.ToString());
                        string newStr = commandInput[1];
                        text.Append(newStr);
                        break;
                    case 2:
                        oldVersions.Push(text.ToString());
                        int length = int.Parse(commandInput[1]);
                        text.Remove(text.Length - length, length);
                        break;
                    case 3:
                        int index = int.Parse(commandInput[1]);
                        Console.WriteLine(text[index - 1]); 
                        break;
                    case 4:
                        text.Clear();
                        text.Append(oldVersions.Pop());
                        break;
                }
            }
        }
    }
}
