using System;
using System.Linq;

namespace E04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse )
                .ToArray();

            Lake lake = new Lake(inputNumbers);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
