using System;

namespace E02.KnightsHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names
                => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(inputNames);
        }
    }
}
