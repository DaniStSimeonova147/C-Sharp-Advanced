using System;
using System.Collections.Generic;
using System.Linq;

namespace A01.Socks
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] firstInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondInput = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();

            Stack<int> leftSocks = new Stack<int>(firstInput);

            Queue<int> rightSocks = new Queue<int>(secondInput);

            List<int> result = new List<int>();

            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int currentLeftSocks = leftSocks.Peek();

                int currentRightSocks = rightSocks.Peek();

                if (currentLeftSocks > currentRightSocks)
                {
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                    int pair = currentLeftSocks + currentRightSocks;
                    result.Add(pair);
                }
                else if (currentLeftSocks < currentRightSocks)
                {
                    leftSocks.Pop();
                }
                else if (currentLeftSocks == currentRightSocks)
                {
                    int newCurrentLeftSocks = currentLeftSocks + 1;
                    leftSocks.Pop();
                    leftSocks.Push(newCurrentLeftSocks);
                    rightSocks.Dequeue();
                }
            }
            Console.WriteLine(result.Max());
            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
