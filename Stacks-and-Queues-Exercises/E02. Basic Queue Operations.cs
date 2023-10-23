using System;
using System.Collections.Generic;
using System.Linq;

namespace E02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int enqueueElements = input[0];
            int dequeueElements = input[1];
            int containsElement = input[2];

            Queue<int> result = new Queue<int>();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (enqueueElements > 0)
            {
                foreach (var number in numbers)
                {
                    int currentNumber = number;

                    result.Enqueue(currentNumber);

                    enqueueElements--;
                }
            }

            while (dequeueElements > 0)
            {
                result.Dequeue();

                dequeueElements--;
            }

            if (result.Count > 0)
            {
                if (!result.Contains(containsElement))
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
