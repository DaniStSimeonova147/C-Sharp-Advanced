using System;
using System.Linq;

namespace E02._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int columns = input[1];

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] symbols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] += symbols[j];
                }

            }

            int count = 0;

            //A B B D
            //E B B B
            //I J B B


            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix[row + 1, col + 1] )
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
