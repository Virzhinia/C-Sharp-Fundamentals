using System;
using System.Collections.Generic;
using System.Linq;


namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "Party!")
            {

                var action = command[0];
                var criteria = command[1];
                var value = command[2];

                switch (criteria)
                {
                    case "StartsWith":ChangePartyList(names, action, n => n.StartsWith(value));
                        break;
                    case "EndsWith":ChangePartyList(names, action, n => n.EndsWith(value));
                        break;
                    case "Length":int valueLength = int.Parse(command[2]);
                        ChangePartyList(names, action, n=>n.Length==valueLength);
                        break;
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (names.Count() == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(string.Join(", ", names));
                Console.WriteLine(" are going to the party!");
            }
        }

        private static void ChangePartyList(List<string> names, string action, Func<string,bool> func)
        {
            for (int i = names.Count - 1; i >= 0; i--)
            {
                if (func(names[i]))
                {
                    if (action == "Double")
                    {
                        names.Add(names[i]);
                    }
                    else if (action == "Remove")
                    {
                        names.RemoveAt(i);
                    }
                }
            }
        }
    }
}