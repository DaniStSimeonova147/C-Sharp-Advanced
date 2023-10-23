using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> clothes = new Stack<int>(input);

            int capacity = int.Parse(Console.ReadLine());

            int countBox = 1;

            while (clothes.Count > 0)
            {
                int currentCapacity = capacity;

                while (currentCapacity > 0 && clothes.Count > 0)
                {
                    if (clothes.Peek() < currentCapacity)
                    {
                        int currentClothes = clothes.Pop();
                        currentCapacity -= currentClothes;
                    }
                    else if (clothes.Peek() == currentCapacity)
                    {
                        int currentClotes = clothes.Pop();
                        currentCapacity -= currentClotes;

                        if (clothes.Count > 0)
                        {
                            countBox++;
                        }
                    }
                    else if (clothes.Peek() > currentCapacity)
                    {
                        countBox++;
                        break;
                    }
                }
            }
            Console.WriteLine(countBox);
        }
    }
}

