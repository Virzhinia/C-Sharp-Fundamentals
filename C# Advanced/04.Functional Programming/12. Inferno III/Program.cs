using System;
using System.Linq;
using System.Collections.Generic;

namespace _12._Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gems = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Dictionary<string, Func<List<int>, List<int>>> filters = new Dictionary<string, Func<List<int>, List<int>>>();
            string command;

            while((command = Console.ReadLine()) != "Forge")
            {
                ParseCommand(command, filters);
            }
        }

        private static void ParseCommand(string commandInput, Dictionary<string, Func<List<int>, List<int>>> )
        {
            string[] tokens = commandInput.Split(';');
            string command = tokens[0];
            string filterType = tokens[1];
            int parameter = int.Parse
        }
    }
}
