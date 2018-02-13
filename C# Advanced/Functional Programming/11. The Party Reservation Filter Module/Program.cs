using System;
using System.Collections.Generic;
using System.Linq;


namespace Rextester
{
    public class Program
    {
        public static List<string> removedNames = new List<string>();

        public static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "Print")
            {

                var action = command[0];
                var criteria = command[1];
                var value = command[2];

                switch (criteria)
                {
                    case "Starts with":
                        ChangePartyReservation(names, action, n => n.StartsWith(value));
                        break;
                    case "Ends with":
                        ChangePartyReservation(names, action, n => n.EndsWith(value));
                        break;
                    case "Length":
                        int valueLength = int.Parse(value);
                        ChangePartyReservation(names, action, n => n.Length == valueLength);
                        break;
                    case "Contains":
                        ChangePartyReservation(names, action, n => n.Contains(value));
                        break;
                }

                command = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.WriteLine(string.Join(" ", names));
        }

        private static void ChangePartyReservation(List<string> names, string action, Func<string, bool> func)
        {
            if (action == "Add filter")
            {
                for (int i = names.Count - 1; i >= 0; i--)
                {
                    if (func(names[i]))
                    {
                        removedNames.Add(names[i]);
                        names.RemoveAt(i);
                    }
                }
            }
            else if (action == "Remove filter")
            {
                for (int i = 0; i < removedNames.Count; i++)
                {
                    if (func(removedNames[i]))
                    {

                        names.Add(removedNames[i]);
                    }

                }
            }



        }
    }
}
