using System;
using System.Collections.Generic;
using System.Linq;

namespace E01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> result = new Stack<int>();

            int pushElements = input[0];
            int popElements = input[1];
            int containElement = input[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (pushElements > 0)
            {
                foreach (var number in numbers)
                {
                    int currentNum = number;

                    result.Push(currentNum);

                    pushElements--;
                }


            }

            while (popElements > 0)
            {
                result.Pop();

                popElements--;
            }

            if (result.Count > 0)
            {
                if (!result.Contains(containElement))
                {
                    int smallestNum = int.MaxValue;

                    foreach (var num in result)
                    {
                        int currentNum = num;
                        if (currentNum < smallestNum)
                        {
                            smallestNum = currentNum;
                        }
                    }
                    Console.WriteLine(smallestNum);
                }

                else
                {
                    Console.WriteLine("true");
                }
            }
            else
            {
                Console.WriteLine("0");
            }


        }
    }
}
