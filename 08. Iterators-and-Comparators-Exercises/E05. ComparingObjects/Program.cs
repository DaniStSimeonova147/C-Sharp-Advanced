using System;
using System.Collections.Generic;

namespace E05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                var person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            int countOfMaches = 1;
            int countOfNotEqualPeople = 0;

            Person targetPerson = people[n - 1];

            foreach (var item in people)
            {
                if (item == targetPerson)
                {
                    continue;
                }
                if (item.CompareTo(targetPerson) == 0)
                {
                    countOfMaches++;
                }
                else
                {
                    countOfNotEqualPeople++;
                }
            }

            if (countOfMaches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMaches} {countOfNotEqualPeople} {people.Count}");
            }
        }
    }
}
