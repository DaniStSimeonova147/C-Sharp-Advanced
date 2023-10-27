using System;

namespace E01.GenericBoxString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> input = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string currentText = Console.ReadLine();

                input.Add(currentText);
            }

            string result = input.ToString();

            Console.WriteLine(result);
        }
    }
}
