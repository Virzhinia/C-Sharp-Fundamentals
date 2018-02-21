using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] inputCommand = command.Split();
                var departament = inputCommand[0];
                var firstNameDoctor = inputCommand[1];
                var secondNameDoctor = inputCommand[2];
                var pacient = inputCommand[3];
                var doctorsName = firstNameDoctor + secondNameDoctor;

                if (!doctors.ContainsKey(firstNameDoctor + secondNameDoctor))
                {
                    doctors[doctorsName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int stai = 0; stai < 20; stai++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                CheckRooms(doctors, departments, departament, pacient, doctorsName);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                PrintResult(doctors, departments, command);

                command = Console.ReadLine();
            }
        }

        private static void CheckRooms(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string departament, string pacient, string doctorsName)
        {
            bool isNotFull = departments[departament].SelectMany(x => x).Count() < 60;
            if (isNotFull)
            {
                int room = 0;
                doctors[doctorsName].Add(pacient);
                for (int r = 0; r < departments[departament].Count; r++)
                {
                    if (departments[departament][r].Count < 3)
                    {
                        room = r;
                        break;
                    }
                }
                departments[departament][room].Add(pacient);
            }
        }

        private static void PrintResult(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string command)
        {
            string[] args = command.Split();

            if (args.Length == 1)
            {
                Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            }
            else if (args.Length == 2 && int.TryParse(args[1], out int room))
            {
                Console.WriteLine(string.Join("\n", departments[args[0]][room - 1].OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
            }
        }
    }
}
