using System;
using System.Linq;

namespace E08._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] += numbers[j];
                }
            }

            string[] coordinates = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < coordinates.Length; i++)
            {
                string[] tokens = coordinates[i].Split(",");

                int currentRow = int.Parse(tokens[0]);
                int currentCol = int.Parse(tokens[1]);

                int currentBomb = matrix[currentRow, currentCol];
                

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currentRow == row && currentCol == col)
                        {
                            if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1) 
                                && matrix[row - 1, col - 1] > 0)
                            {
                                matrix[row - 1, col - 1] -= currentBomb;
                            }
                            if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) 
                                && matrix[row - 1, col] > 0)
                            {
                                matrix[row - 1, col] -= currentBomb;
                            }
                            if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1) 
                                && matrix[row - 1, col + 1] > 0)
                            {
                                matrix[row - 1, col + 1] -= currentBomb;
                            }
                            if (col - 1 >= 0 && col - 1 < matrix.GetLength(1) 
                                && matrix[row, col - 1] > 0)
                            {
                                matrix[row, col - 1] -= currentBomb;
                            }
                            if (col + 1 >= 0 && col + 1 < matrix.GetLength(1) 
                                && matrix[row, col + 1] > 0)
                            {
                                matrix[row, col + 1] -= currentBomb;
                            }
                            if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1) 
                                && matrix[row + 1, col - 1] > 0)
                            {
                                matrix[row + 1, col - 1] -= currentBomb;
                            }
                            if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) 
                                && matrix[row + 1, col] > 0)
                            {
                                matrix[row + 1, col] -= currentBomb;
                            }
                            if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1) 
                                && matrix[row + 1, col + 1] > 0)
                            {
                                matrix[row + 1, col + 1] -= currentBomb;
                            }
                        }
                    }
                }
                matrix[currentRow, currentCol] = 0;
            }
            int count = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
