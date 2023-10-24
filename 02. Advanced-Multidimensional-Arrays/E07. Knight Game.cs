using System;

namespace E07.__Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;

            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    

                    matrix[i, j] += symbols[j];
                }
            }
            int count = 0;

            while (true)
            {

                int maxCount = 0;

                int indexRow = 0;
                int indexCol = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int currentCount = 0;

                        if (matrix[row, col] == 'K')
                        {
                            if (row - 2 >= 0 && row - 2 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1)
                                && matrix[row - 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (row - 2 >= 0 && row - 2 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1)
                              && matrix[row - 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (row + 2 >= 0 && row + 2 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1)
                              && matrix[row + 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (row + 2 >= 0 && row + 2 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1)
                              && matrix[row + 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col + 2 >= 0 && col + 2 < matrix.GetLength(1)
                              && matrix[row - 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col - 2 >= 0 && col - 2 < matrix.GetLength(1)
                              && matrix[row - 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col + 2 >= 0 && col + 2 < matrix.GetLength(1)
                              && matrix[row + 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col - 2 >= 0 && col - 2 < matrix.GetLength(1)
                              && matrix[row + 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                        }
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            indexRow = row;
                            indexCol = col;
                        }
                    }
                }

                if (maxCount == 0)
                {
                    break;
                }
                matrix[indexRow, indexCol] = '0';
                count++;
            }

            Console.WriteLine(count);
            



            //int rows = int.Parse(Console.ReadLine());

            //char[,] board = new char[rows, rows];

            //for (int row = 0; row < rows; row++)
            //{
            //    char[] inputRow = Console.ReadLine()
            //        .ToCharArray();

            //    for (int col = 0; col < rows; col++)
            //    {
            //        board[row, col] += inputRow[col];
            //    }
            //}
            //int count = 0;

            //while (true)
            //{
            //    int maxCount = 0;

            //    int indexRow = 0;
            //    int indexCol = 0;

            //    for (int row = 0; row < board.GetLength(0); row++)
            //    {
            //        for (int col = 0; col < board.GetLength(1); col++)
            //        {
            //            int currentCount = 0;

            //            if (board[row, col] == 'K')
            //            {
            //                if (IsInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
            //                {
            //                    currentCount++;
            //                }
            //                if (IsInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
            //                {
            //                    currentCount++;
            //                }
            //                if (IsInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
            //                {
            //                    currentCount++;
            //                }
            //                if (IsInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
            //                {
            //                    currentCount++;
            //                }
            //                if (IsInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
            //                {
            //                    currentCount++;
            //                }
            //                if (IsInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
            //                {
            //                    currentCount++;
            //                }
            //                if (IsInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
            //                {
            //                    currentCount++;
            //                }
            //                if (IsInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
            //                {
            //                    currentCount++;
            //                }
            //            }
            //            if (currentCount > maxCount)
            //            {
            //                maxCount = currentCount;
            //                indexRow = row;
            //                indexCol = col;

            //            }
            //        }
            //    }
            //    if (maxCount == 0)
            //    {
            //        break;
            //    }

            //    board[indexRow, indexCol] = '0';
            //    count++;
            //}
            //Console.WriteLine(count);
        }

        //private static bool IsInside(char[,] board, int desiredRow, int desiredCol)
        //{
        //   return desiredRow < board.GetLength(0) && desiredRow >= 0
        //         && desiredCol < board.GetLength(1) && desiredCol >= 0;

        //}
    }
}
