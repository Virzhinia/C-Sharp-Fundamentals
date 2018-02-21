using System;
using System.Linq;

namespace _2._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int rows = 0; rows < n; rows++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[rows, col] = rowValues[col]; 
                }
            }

            int sum1 = 0;
            int indexLeftRight = 0;
            int sum2 = 0;
            int indexRightLeft = n -1;
            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[indexLeftRight, indexLeftRight];
                indexLeftRight++;

                sum2 += matrix[i, indexRightLeft];
                indexRightLeft--;
            }

            int finalSum = Math.Abs(sum1 - sum2);
            Console.WriteLine(finalSum);

        }
    }
}
