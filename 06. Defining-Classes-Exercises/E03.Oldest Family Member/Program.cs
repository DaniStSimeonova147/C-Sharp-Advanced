using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                string inputName = input[0];
                int inputAge = int.Parse(input[1]);

                Person person = new Person(inputName, inputAge);

                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
