using System;
using System.Collections.Generic;

namespace E05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!result.ContainsKey(text[i]))
                {
                    result[text[i]] = 1;
                }
                else
                {
                    result[text[i]]++;
                }
            }

            foreach (var kvp in result) //OrderBy()
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
