using System;
using System.Collections.Generic;
using System.Linq;

namespace E07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Dictionary<string, Dictionary<string, List<int>>> result = new Dictionary<string, Dictionary<string, List<int>>>();

            while (input != "Statistics")
            {
                string[] tokens = input.Split();

                //Saffrona joined The V-Logger
                //Saffrona followed EmilConrad


                if (input.Contains("joined") && tokens.Length == 4)
                {
                    string currentName = tokens[0];

                    if (!result.ContainsKey(currentName))
                    {
                        result[currentName] = new Dictionary<string, List<int>>();
                    }
                    result[currentName][currentName] = new List<int>();
                    result[currentName][currentName].Add(0);
                    result[currentName][currentName].Add(0);

                }
                else if (input.Contains("followed") && tokens.Length == 3)
                {
                    string firstName = tokens[0];

                    string secondName = tokens[2];

                    if (result.ContainsKey(firstName) && result.ContainsKey(secondName))
                    {
                        if (!result[secondName].ContainsKey(firstName))
                        {
                            result[secondName][firstName] = new List<int>();

                            result[firstName][firstName][1]++;
                            result[secondName][secondName][0]++;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {result.Keys.Count} vloggers in its logs.");

            int num = 1;

          

            foreach (var kvp in result)
            {
                Console.Write($"{num}. {kvp.Key} : ");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"{item.Value} followers, {item.Value} following");
                    num++;
                }
            }
        }
    }
}
