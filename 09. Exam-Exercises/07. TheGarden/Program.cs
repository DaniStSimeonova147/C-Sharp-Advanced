using System;
using System.Linq;

namespace D01.The_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] garden = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                char[] input = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                garden[i] = input;
            }

            int harmedVegitablesCount = 0;
            // Carrots: 1
            //Potatoes: 1
            //Lettuce: 0
            int countOfCarrots = 0;
            int countOfPotatos = 0;
            int countOfLettuce = 0;

            string command = Console.ReadLine();

            while (command != "End of Harvest")
            {
                //•	"Harvest {row} {col}"

                if (command.Contains("Harvest"))
                {
                    string[] tokens = command.Split();

                    int indexRow = int.Parse(tokens[1]);

                    int indexCol = int.Parse(tokens[2]);

                    if (indexRow >= 0 && indexRow < rows && indexCol >= 0 && indexCol < garden[indexRow].Length && garden[indexRow][indexCol] != ' ')
                    {
                        if (garden[indexRow][indexCol] == 'C')
                        {
                            countOfCarrots++;
                        }
                        else if (garden[indexRow][indexCol] == 'P')
                        {
                            countOfPotatos++;
                        }
                        else if (garden[indexRow][indexCol] == 'L')
                        {
                            countOfLettuce++;
                        }

                        garden[indexRow][indexCol] = ' ';

                    }

                }
                //•	"Mole {row} {col} {direction}"

                else if (command.Contains("Mole"))
                {
                    string[] tokens = command.Split();

                    int indexRow = int.Parse(tokens[1]);

                    int indexCol = int.Parse(tokens[2]);

                    string direction = tokens[3];

                    if (indexRow >= 0 && indexRow < rows && indexCol >= 0 && indexCol < garden[indexRow].Length )
                    {
                        if (direction == "up")
                        {
                            for (int i = indexRow; i >= 0; i -= 2)
                            {
                                if (garden[i][indexCol] == 'C' || garden[i][indexCol] == 'P' || garden[i][indexCol] == 'L')
                                {
                                    harmedVegitablesCount++;
                                    garden[i][indexCol] = ' ';
                                }
                               
                            }
                        }
                        else if (direction == "down")
                        {
                            for (int i = indexRow ; i < rows; i += 2)
                            {
                                if (garden[i][indexCol] == 'C' || garden[i][indexCol] == 'P' || garden[i][indexCol] == 'L')
                                {
                                    harmedVegitablesCount++;
                                    garden[i][indexCol] = ' ';
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            for (int i = indexCol ; i >= 0; i -= 2)
                            {
                                if (garden[indexRow][i] == 'C' || garden[indexRow][i] == 'P' || garden[indexRow][i] == 'L')
                                {
                                    harmedVegitablesCount++;
                                    garden[indexRow][i] = ' ';
                                }

                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = indexCol; i < garden[indexRow].Length ; i += 2)
                            {
                                if (garden[indexRow][i] == 'C' || garden[indexRow][i] == 'P' || garden[indexRow][i] == 'L')
                                {
                                    harmedVegitablesCount++;
                                    garden[indexRow][i] = ' ';
                                }
                            }
                        }

                    }

                }
                command = Console.ReadLine();
            }

            foreach (var row in garden)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.WriteLine($"Carrots: {countOfCarrots}");
            Console.WriteLine($"Potatoes: {countOfPotatos}");
            Console.WriteLine($"Lettuce: {countOfLettuce}");
            Console.WriteLine($"Harmed vegetables: {harmedVegitablesCount}");
        }
    }
}
