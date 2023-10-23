using System;
using System.Collections.Generic;
using System.Linq;

namespace E03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> result = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string command = tokens[0];

                if (command == "1")
                {
                    int pushNum = int.Parse(tokens[1]);

                    result.Push(pushNum);
                }
                else if (command == "2" && result.Count > 0)
                {
                    result.Pop();
                }
                else if (command == "3" && result.Count > 0)
                {
                    Console.WriteLine(result.Max());
                }
                else if (command == "4" && result.Count > 0)
                {
                    Console.WriteLine(result.Min());
                }

                
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
