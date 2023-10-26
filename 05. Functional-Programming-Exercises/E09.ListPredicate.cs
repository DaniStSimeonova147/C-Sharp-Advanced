using System;
using System.Collections.Generic;
using System.Linq;

namespace E09.ListPredicate
{
    class Program
    {
        private static object hashSEt;

        static void Main(string[] args)
        {
            int upperBound = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1, upperBound).ToList();

            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToArray();
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var divider in dividers)
            {
                predicates.Add(x => x % divider == 0);
            }

            List<int> resultNumbers = new List<int>();

            foreach (var number in numbers)
            {
                bool isValid = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(number))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    resultNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
