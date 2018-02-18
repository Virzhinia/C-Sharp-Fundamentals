using System;


class Program
{
    static void Main(string[] args)
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateModifier dateModif = new DateModifier(firstDate,secondDate);

        Console.WriteLine(dateModif.DaysDeffernce(firstDate,secondDate));
        
    }
}

