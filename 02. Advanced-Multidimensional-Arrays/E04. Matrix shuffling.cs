using System;
using System.Linq;

namespace E04._Matrix_shuffling
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
            int columns = size[1];

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

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 5)
                {
                    string command = tokens[0];

                    int row1 = int.Parse(tokens[1]);
                    int col1 = int.Parse(tokens[2]);
                    int row2 = int.Parse(tokens[3]);
                    int col2 = int.Parse(tokens[4]);

                    if (row1 < 0 || row1 > matrix.GetLength(0) - 1 || col1 < 0 || col1 > matrix.GetLength(1) - 1
                        || row2 < 0 || row2 > matrix.GetLength(0) - 1 || col2 < 0 || col2 > matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string firstSymbol = matrix[row1, col1];
                        string secondSymbol = matrix[row2, col2];

                        matrix[row1, col1] = secondSymbol;
                        matrix[row2, col2] = firstSymbol;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write( matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


                input = Console.ReadLine();
            }
        }
    }
}
