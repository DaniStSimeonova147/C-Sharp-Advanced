using System;
using System.Collections.Generic;
using System.Linq;

namespace E03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> result = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                    result.Add(input[j]);
                }
            }

            foreach (var item in result.OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
        }
    }
}
