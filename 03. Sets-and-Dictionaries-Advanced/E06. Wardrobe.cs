using System;
using System.Collections.Generic;

namespace E006._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>>  result = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split(" -> ");

                string color = command[0];

                string[] clothes = command[1].Split(",");

                //Blue->dress,jeans,hat

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentCloth = clothes[j];

                    if (!result.ContainsKey(color))
                    {
                        result[color] = new Dictionary<string, int>();
                    }
                    if (!result[color].ContainsKey(currentCloth))
                    {
                        result[color][currentCloth] = 0;
                    }

                    result[color][currentCloth]++;
                }
            }

            string[] foundCloth = Console.ReadLine().Split();

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var clothAndCount in kvp.Value)
                {
                    if (kvp.Key == foundCloth[0] && clothAndCount.Key == foundCloth[1])
                    {
                        Console.WriteLine($"* {clothAndCount.Key} - {clothAndCount.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothAndCount.Key} - {clothAndCount.Value}");
                    }
                }

            }
        }
    }
}
