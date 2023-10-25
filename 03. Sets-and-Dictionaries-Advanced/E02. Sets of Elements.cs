using System;
using System.Collections.Generic;
using System.Linq;

namespace E02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstCount = input[0];
            int secondCount = input[1];

            HashSet<int> firstNums = new HashSet<int>();
            HashSet<int> secondNums = new HashSet<int>();

            for (int i = 0; i < firstCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                firstNums.Add(currentNum);
            }

            for (int i = 0; i < secondCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                secondNums.Add(currentNum);
            }

            foreach (var firstNum in firstNums)
            {
                foreach (var secondNum in secondNums)
                {
                    if (firstNum == secondNum)
                    {
                        Console.Write(firstNum + " ");
                    }
                }
            }
        }
    }
}
