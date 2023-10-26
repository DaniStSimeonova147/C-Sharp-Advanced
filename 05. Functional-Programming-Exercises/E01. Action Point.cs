using System;

namespace E01._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names =>
            Console.WriteLine(string.Join(Environment.NewLine, names));

            string[] inputNames = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(inputNames);

        }
    }
}
