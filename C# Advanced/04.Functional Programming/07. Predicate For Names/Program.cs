using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<int, bool> funcName = n => n <= length;

            foreach (var item in names)
            {
                if(funcName(item.Length))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
