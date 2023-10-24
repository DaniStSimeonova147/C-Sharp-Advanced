using System;
using System.Linq;

namespace E03._Maximal_Sum
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

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] += numbers[j];
                }
            }

            int maxSum = int.MinValue;

            int indexRow = -1;
            int indexCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum  = currentSum;

                        indexRow = row;
                        indexCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

          

            Console.WriteLine($"{matrix[indexRow, indexCol]} {matrix[indexRow, indexCol + 1]} {matrix[indexRow, indexCol + 2]}");
            Console.WriteLine($"{matrix[indexRow + 1, indexCol]} {matrix[indexRow + 1, indexCol + 1]} {matrix[indexRow + 1, indexCol + 2]}");
            Console.WriteLine($"{matrix[indexRow + 2, indexCol]} {matrix[indexRow + 2, indexCol + 1]} {matrix[indexRow + 2, indexCol + 2]}");
        }
    }
}
