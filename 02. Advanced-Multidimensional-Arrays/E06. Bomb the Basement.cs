using System;
using System.Linq;

namespace E06._Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            int[] command = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int indexRow = command[0];
            int indexCol = command[1];
            int radius = command[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (Math.Pow(indexRow - row, 2) + Math.Pow(indexCol - col, 2) <= radius * radius)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int count = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row,col] == 1)
                    {
                        count++;

                        matrix[row, col] = 0;
                    }
                }
                for (int row = 0; row < count; row++)
                {
                    matrix[row, col] = 1;
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }


            

            //int[] dimensions = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //int rows = dimensions[0];
            //int cols = dimensions[1];

            //int[][] basement = new int[rows][];

            //for (int i = 0; i < basement.Length; i++)
            //{
            //    basement[i] = new int[cols];
            //}

            //int[] cordinates = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //int targetRow = cordinates[0];
            //int targetCol = cordinates[1];
            //int radius = cordinates[2];

            //for (int row = 0; row < basement.Length; row++)
            //{
            //    for (int col = 0; col < basement[row].Length; col++)
            //    {
            //        bool isInRadius = Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2) <= Math.Pow(radius, 2);

            //        if (isInRadius)
            //        {
            //            basement[row][col] = 1;
            //        }
            //    }
            //}
           

            //for (int col = 0; col < basement[0].Length; col++)
            //{
            //    int count = 0;

            //    for (int row = 0; row < basement.Length; row++)
            //    {
            //        if (basement[row][col] == 1)
            //        {
            //            count++;
            //            basement[row][col] = 0;
            //        }
            //    }
            //    for (int row = 0; row < count; row++)
            //    {
            //        basement[row][col] = 1;
            //    }
            //}
            //foreach (var row in basement)
            //{
            //    Console.WriteLine(string.Join("", row));
            //}
        }
    }
}
