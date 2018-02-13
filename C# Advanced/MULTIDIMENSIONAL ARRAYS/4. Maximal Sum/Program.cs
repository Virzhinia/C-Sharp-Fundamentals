using System;
using System.Linq;

namespace _4._Maximal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            int[,] matrix = new int[rows, columns];

            int sumMatrix = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] values = Console.ReadLine()
                    .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = values[col];

                }

            }

            int StartIndexRow = 0;
            int StartIndexCol = 0;

            for (int r = 0; r < matrix.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    int currentSum = matrix[r, c] + matrix[r,c+1] +matrix[r,c+2]
                        + matrix[r+1,c] + matrix[r+1,c+1] + matrix[r+1,c+2]
                        +matrix[r+2,c] +matrix[r+2,c+1] +matrix[r+2,c+2];
                    if (currentSum>sumMatrix)
                    {
                        sumMatrix=currentSum;
                        StartIndexRow = r;
                        StartIndexCol = c;
                    }
                }
            }

            Console.WriteLine($"Sum = {sumMatrix}");
            for (int r = StartIndexRow; r <StartIndexRow+3 ; r++)
            {
                for (int c = StartIndexCol; c < StartIndexCol+ 3; c++)
                {
                    Console.Write(matrix[r,c]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
