using System;
using System.Linq;

namespace E03.GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<string> result = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string currentItem = Console.ReadLine();

                result.Add(currentItem);
            }

            int[] token = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            result.Swap(token[0], token[1]);

            Console.WriteLine(result.ToString()); 
        }
    }
}
