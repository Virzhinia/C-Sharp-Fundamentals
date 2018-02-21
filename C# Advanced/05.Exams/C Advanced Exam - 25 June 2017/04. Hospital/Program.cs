using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            var input = "";

            while ((input = Console.ReadLine()) != "Output")
            {
                var patienData = input.Split();
                var department = patienData[0];
                var doctor = patienData[1] + " " + patienData[2];
                var patient = patienData[3];

                if (departments.ContainsKey(department) == false)
                {
                    departments.Add(department, new List<string>());

                }
                departments[department].Add(patient);

                if (doctors.ContainsKey(doctor) == false)
                {
                    doctors.Add(doctor, new List<string>());
                }
                doctors[doctor].Add(patient);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                var splitCommand = input.Split();
                if (splitCommand.Length == 1)
                {
                    foreach (var patient in departments[input])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    int roomNumber = 0;
                    if (int.TryParse(splitCommand[1], out roomNumber))
                    {
                        var skip = 3 * (roomNumber - 1);
                        foreach (var patient in departments[splitCommand[0]].Skip(skip).Take(3).OrderBy(p=>p))
                        {
                            Console.WriteLine(patient);
                        }
                    }

                    else
                    {
                        foreach (var patient in doctors[input].OrderBy(p=>p))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
            }
        }
    }
}
