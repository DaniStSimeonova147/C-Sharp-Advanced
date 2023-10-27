using System;

namespace E02.GenericBoxInteger
{
    public class StrtUp
    {
        static void Main(string[] args)
        {
            Box<int> result = new Box<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int currentItem = int.Parse(Console.ReadLine());

                result.Add(currentItem);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
