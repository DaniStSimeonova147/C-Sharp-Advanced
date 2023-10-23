using System;
using System.Collections.Generic;
using System.Linq;

namespace E08.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<char> result = new Stack<char>();

            char[] symbols = new char[] {'(', '{', '[' };
            bool isValid = true;

            foreach (var item in input)
            {
                if (symbols.Contains(item))
                {
                    result.Push(item);
                    continue;
                }

                if (result.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (result.Peek() == '(' && item == ')')
                {
                    result.Pop();
                }
                else if (result.Peek() == '{' && item == '}')
                {
                    result.Pop();
                }
                else if (result.Peek() == '[' && item == ']')
                {
                    result.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
