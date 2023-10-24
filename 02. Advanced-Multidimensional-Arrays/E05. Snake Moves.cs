using System;
using System.Linq;

namespace E05._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int rows = size[0];
            int cols = size[1];

            string[,] result = new string[rows, cols];

            string text = Console.ReadLine();

            int count = 0;

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    result[row, col] += text[count];
                    count++;

                    if (count >= text.Length)
                    {
                        count = 0;
                    }
                }
            }
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
