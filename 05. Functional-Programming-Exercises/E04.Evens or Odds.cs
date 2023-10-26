using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lowerBound = input[0];
            int upperBound = input[1];

            List<int> numbers = new List<int>();

            string numberType = Console.ReadLine();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isOdd = number => number % 2 != 0;
            Predicate<int> isEven = number => number % 2 == 0;

            Action<List<int>> printNumbers = outputNumbers 
                =>  Console.WriteLine(string.Join(" ",outputNumbers));

            if (numberType == "odd")
            {
                numbers = numbers.Where(x => isOdd(x)).ToList();
            }
            else if (numberType == "even")
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }

            printNumbers(numbers);
        }
    }
}
