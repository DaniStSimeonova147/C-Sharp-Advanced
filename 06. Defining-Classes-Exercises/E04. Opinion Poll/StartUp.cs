using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses

{
    public class StartUp

    {
        static void Main(string[] args)
        {
            HashSet<Person> people = GetPeople();
            PrintPeopleOlderThat30(people);
        }

        #region

        private static HashSet<Person> GetPeople()
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<Person> people = new HashSet<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] personDate = Console.ReadLine().Split();

                string currentName = personDate[0];
                int currentAge = int.Parse(personDate[1]);

                people.Add(new Person(currentName, currentAge));
            }

            return people;
        }

        private static void PrintPeopleOlderThat30(HashSet<Person> people)
        {
            Console.WriteLine(string.Join(Environment.NewLine, people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .Select(p => $"{p.Name} - {p.Age}")));
        }

        #endregion
    }
}
