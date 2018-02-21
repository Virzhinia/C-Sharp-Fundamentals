using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int namesCount = int.Parse(Console.ReadLine());
        var team = new Team("my team");

        for (int i = 0; i < namesCount; i++)
        {
            var input = Console.ReadLine().Split();
            try
            {
                var player = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                team.AddPlayer(player);

            }
            catch (ArgumentException argEx)
            {

                Console.WriteLine(argEx.Message);
            }

        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

    }
}

