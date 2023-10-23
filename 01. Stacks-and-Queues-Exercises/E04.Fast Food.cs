using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> result = new Queue<int>(orders);

            if (quantity >= result.Sum())
            {
                Console.WriteLine(result.Max());
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(result.Max());

                while (quantity > result.Peek())
                {
                    int dequeueOrder = result.Dequeue();
                    quantity -= dequeueOrder;
                }

                Console.WriteLine($"Orders left: {string.Join(" ", result)}");
            }

        }
    }
}
