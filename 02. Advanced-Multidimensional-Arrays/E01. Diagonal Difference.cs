using System;
using System.Linq;

namespace E01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int columns = size;

            int[,] numbers = new int[rows, columns];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int[] currentNumber = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] += currentNumber[j];
                }
            }

            int firstSum = 0;

            int secondSum = 0;

            int count = 1;

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = row; col < numbers.GetLength(1);)
                {
                    firstSum += numbers[row, col];
                    break;

                }
                for (int reverseCol = numbers.GetLength(1) - count; reverseCol >= 0;)
                {
                    secondSum += numbers[row, reverseCol];
                    break;
                }
                count++;
            }
            Console.WriteLine(Math.Abs(firstSum - secondSum));
        }
    }
}
