using System;
using System.Linq;

namespace E04.GenericSwapMethodIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> result = new Box<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int currentItem = int.Parse(Console.ReadLine());

                result.Add(currentItem);
            }

            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            result.Swap(tokens[0], tokens[1]);

            Console.WriteLine(result.ToString());
        }
    }
}
