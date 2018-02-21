using System;
using System.Linq;
using System.Collections.Generic;

namespace _13._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumInput = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> filter = (name, sum) => name.ToCharArray().Sum(c => c) >= sum;

            Console.WriteLine(names.FirstOrDefault(name => filter(name,sumInput)));

           // Console.WriteLine(names.FirstOrDefault(name => name.ToCharArray().Sum(c=>c)>=sum));
        }
    }
}
