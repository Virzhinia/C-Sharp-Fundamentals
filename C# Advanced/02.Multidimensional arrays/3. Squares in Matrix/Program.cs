using System;
using System.Linq;

namespace _3._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            string[,] matrix = new string[rows, columns];

            int sumMatrix = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] values = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = values[col];

                }

            }

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    string current = matrix[r, c];
                    if (current == matrix[r, c + 1] &&
                        current == matrix[r + 1, c] &&
                        matrix[r + 1, c + 1] == current)
                    {
                        sumMatrix++;
                    }
                }
            }

            Console.WriteLine(sumMatrix);
        }
    }
}
