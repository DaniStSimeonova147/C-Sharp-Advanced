using System;
using System.Collections.Generic;

namespace E04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!result.ContainsKey(currentNum))
                {
                    result[currentNum] = 1;
                }
                else
                {
                    result[currentNum]++;
                }
            }

            foreach (var kvp in result)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
