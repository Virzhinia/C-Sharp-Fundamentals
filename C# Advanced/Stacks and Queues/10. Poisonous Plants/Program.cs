using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] days = new int[n];
            int[] minElement = new int[n];

            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (plants[i] < min)
                {
                    min = plants[i];
                }
                minElement[i] = min;
            }

            int max = 0;
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (plants[i] > plants[i - 1])
                {
                    days[i] = 1;
                    if (days[i] >= max)
                    {
                        maxIndex = i;
                        max = days[i];
                    }
                    continue;
                }

                if (plants[i] > minElement[i])
                {
                    if (plants[i] > plants[maxIndex])
                    {
                        days[i] = days[i - 1] + 1;
                    }
                    else
                    {
                        days[i] = days[maxIndex] + 1;
                    }
                }
                if (plants[i] == minElement[i])
                {
                    max = 0;
                }

                if (days[i] >= max)
                {
                    maxIndex = i;
                    max = days[i];
                }
            }

            Console.WriteLine(days.Max());

            // int n = int.Parse(Console.ReadLine());
            //
            // int[] plants = Console.ReadLine()
            //     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //     .Select(int.Parse)
            //     .ToArray();
            //
            // int prevPlant = plants[0];
            // Stack<int> stackPlants = new Stack<int>();
            // stackPlants.Push(prevPlant);
            //
            // Stack<int> days = new Stack<int>();
            // days.Push(0);
            //
            // for (int i = 1; i < n; i++)
            // {
            //     int curentPlant = plants[i];
            //     if (curentPlant > prevPlant)
            //     {
            //         days.Push(1);
            //     }
            //     else if (curentPlant > stackPlants.Peek())
            //     {
            //         int day = days.Peek() + 1;
            //         days.Push(day);
            //     }
            //     else
            //     {
            //         stackPlants.Push(curentPlant);
            //         days.Push(0);
            //     }
            //     prevPlant = curentPlant;
            // }
            //
            // Console.WriteLine(days.Max());
        }
    }
}
