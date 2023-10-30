using System;
using System.Linq;

namespace C02._Helen_s_Abduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int parisEnergy = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            char[,] matrix = new char[rows, input.Length];

            int parisRow = -1;
            int parisCol = -1;

            int helenaRow = -1;
            int helenaCol = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] += input[j];
                    if (matrix[i, j] == 'P')
                    {
                        parisRow = i;
                        parisCol = j;
                    }
                    else if (matrix[i, j] == 'H')
                    {
                        helenaRow = i;
                        helenaCol = j;
                    }

                }
                if (i < matrix.GetLength(0) - 1)
                {
                    input = Console.ReadLine();
                }

            }

            string[] tokens = Console.ReadLine().Split();

            while (true)
            {
                string command = tokens[0];

                int indexRow = int.Parse(tokens[1]);
                int indexCol = int.Parse(tokens[2]);

                matrix[indexRow, indexCol] = 'S';

                if (command == "up" && parisEnergy > 0)
                {
                    if (parisRow - 1 >= 0)
                    {
                        if (matrix[parisRow - 1, parisCol] == '-')
                        {
                            matrix[parisRow, parisCol] = '-';
                            matrix[parisRow - 1, parisCol] = 'P';
                            parisRow = parisRow - 1;
                            parisEnergy--;
                            if (parisEnergy <= 0)
                            {
                                matrix[parisRow, parisCol] = 'X';
                                break;
                            }
                        }
                        else if (matrix[parisRow - 1, parisCol] == 'S')
                        {
                            if (parisEnergy > 3)
                            {
                                matrix[parisRow, parisCol] = '-';
                                matrix[parisRow - 1, parisCol] = 'P';
                                parisRow = parisRow - 1;
                                parisEnergy -= 3;
                            }
                            else
                            {
                                matrix[parisRow, parisCol] = '-';
                                matrix[parisRow - 1, parisCol] = 'X';
                                parisRow = parisRow - 1;
                                break;
                            }
                        }
                        else if (matrix[parisRow - 1, parisCol] == 'H')
                        {
                            matrix[parisRow, parisCol] = '-';
                            matrix[helenaRow, helenaCol] = '-';
                            parisRow = parisRow - 1;
                            parisEnergy--;
                            break;
                        }
                    }
                    else
                    {
                        parisEnergy--;
                    }
                }
                else if (command == "down" && parisEnergy > 0)
                {
                    if (parisRow + 1 < rows)
                    {
                        if (matrix[parisRow + 1, parisCol] == '-')
                        {
                            matrix[parisRow, parisCol] = '-';
                            matrix[parisRow + 1, parisCol] = 'P';
                            parisRow = parisRow + 1;
                            parisEnergy--;
                            if (parisEnergy <= 0)
                            {
                                matrix[parisRow, parisCol] = 'X';
                                break;
                            }
                        }
                        else if (matrix[parisRow + 1, parisCol] == 'S')
                        {
                            if (parisEnergy > 3)
                            {
                                matrix[parisRow, parisCol] = '-';
                                matrix[parisRow + 1, parisCol] = 'P';
                                parisRow = parisRow + 1;
                                parisEnergy -= 3;
                            }
                            else
                            {
                                matrix[parisRow, parisCol] = '-';
                                matrix[parisRow + 1, parisCol] = 'X';
                                parisRow = parisRow + 1;
                                break;
                            }
                        }
                        else if (matrix[parisRow + 1, parisCol] == 'H')
                        {
                            matrix[parisRow, parisCol] = '-';
                            matrix[helenaRow, helenaCol] = '-';
                            parisRow = parisRow + 1;
                            parisEnergy--;
                            break;
                        }
                    }
                    else
                    {
                        parisEnergy--;
                    }
                }
                else if (command == "left" && parisEnergy > 0)
                {
                    if (parisCol - 1 >= 0)
                    {
                        if (matrix[parisRow, parisCol - 1] == '-')
                        {
                            matrix[parisRow, parisCol] = '-';
                            matrix[parisRow, parisCol - 1] = 'P';
                            parisCol = parisCol - 1;
                            parisEnergy--;
                            if (parisEnergy <= 0)
                            {
                                matrix[parisRow, parisCol] = 'X';
                                break;
                            }
                        }
                        else if (matrix[parisRow, parisCol - 1] == 'S')
                        {
                            if (parisEnergy > 3)
                            {
                                matrix[parisRow, parisCol] = '-';
                                matrix[parisRow, parisCol - 1] = 'P';
                                parisCol = parisCol - 1;
                                parisEnergy -= 3;
                            }
                            else
                            {
                                matrix[parisRow, parisCol] = '-';
                                matrix[parisRow, parisCol - 1] = 'X';
                                parisCol = parisCol - 1;
                                break;
                            }
                        }
                        else if (matrix[parisRow, parisCol - 1] == 'H')
                        {
                            matrix[parisRow, parisCol] = '-';
                            matrix[helenaRow, helenaCol] = '-';
                            parisCol = parisCol - 1;
                            parisEnergy--;
                            break;
                        }
                    }
                    else
                    {
                        parisEnergy--;
                    }
                }
                else if (command == "right" && parisEnergy > 0)
                {
                    if (parisCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[parisRow, parisCol + 1] == '-')
                        {
                            matrix[parisRow, parisCol] = '-';
                            matrix[parisRow, parisCol + 1] = 'P';
                            parisCol = parisCol + 1;
                            parisEnergy--;
                            if (parisEnergy <= 0)
                            {
                                matrix[parisRow, parisCol] = 'X';
                                break;
                            }
                        }
                        else if (matrix[parisRow, parisCol + 1] == 'S')
                        {
                            if (parisEnergy > 3)
                            {
                                matrix[parisRow, parisCol] = '-';
                                matrix[parisRow, parisCol + 1] = 'P';
                                parisCol = parisCol + 1;
                                parisEnergy -= 3;
                            }
                            else
                            {
                                matrix[parisRow, parisCol] = '-';
                                matrix[parisRow, parisCol + 1] = 'X';
                                parisCol = parisCol + 1;
                                break;
                            }
                        }
                        else if (matrix[parisRow, parisCol + 1] == 'H')
                        {
                            matrix[parisRow, parisCol] = '-';
                            matrix[helenaRow, helenaCol] = '-';
                            parisCol = parisCol + 1;
                            parisEnergy--;
                            break;
                        }
                    }
                    else
                    {
                        parisEnergy--;
                    }
                }


                tokens = Console.ReadLine().Split();
            }

            if (helenaRow == parisRow && helenaCol == parisCol)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
