using System;
using System.Linq;

namespace _1._Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] indexes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = indexes[0];
            int columns = indexes[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = (alphabet[row]).ToString();
                    matrix[row, col]+= alphabet[col + row].ToString();
                    matrix[row,col] += alphabet[row].ToString();
                    Console.Write( matrix[row,col] +" ");
                }
                Console.WriteLine();
            }


        }
    }
}
