using System;
using System.Collections.Generic;
using System.Linq;

namespace C01._Trojan_Invasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWaves = int.Parse(Console.ReadLine());

            int[] platesOfSpartanInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> platesOfSpartan = new List<int>(platesOfSpartanInput);

            Stack<int> warriorsOfTroya = new Stack<int>();

             

            for (int i = 1; i <= countOfWaves; i++)
            {
                int[] warriorsOfTroyaInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                foreach (var warrior in warriorsOfTroyaInput)
                {
                    warriorsOfTroya.Push(warrior);
                }

                if (i % 3 == 0)
                {
                    int newPlates = int.Parse(Console.ReadLine());
                    platesOfSpartan.Add(newPlates);
                } 
                // 3
                //10 20 30
                //4 5 1
                //10 5 5
                //10 10 10
                //4

                while (platesOfSpartan.Count > 0 && warriorsOfTroya.Count > 0)
                {
                    int currentWarrior = warriorsOfTroya.Pop();

                    int currentPlate = platesOfSpartan[0];

                    if (currentWarrior > currentPlate)
                    {
                        currentWarrior -= currentPlate;
                        warriorsOfTroya.Push(currentWarrior);
                        platesOfSpartan.RemoveAt(0);
                    }
                    else if (currentWarrior == currentPlate)
                    {
                        platesOfSpartan.RemoveAt(0);
                    }
                    else if (currentWarrior < currentPlate)
                    {
                        platesOfSpartan[0] -= currentWarrior;
                    }
                }

                if (platesOfSpartan.Count == 0)
                {
                    break;
                }
            }

            if (warriorsOfTroya.Count > 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                
            }
            else if (platesOfSpartan.Count > 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            }
            if (warriorsOfTroya.Count > 0)
            {
                Console.WriteLine($"Warriors left: {string.Join(", ", warriorsOfTroya)}");

            }
            if (platesOfSpartan.Count > 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", platesOfSpartan)}");
            }
        }
    }
}
