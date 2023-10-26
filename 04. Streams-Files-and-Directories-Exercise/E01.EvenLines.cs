using System;
using System.IO;
using System.Linq;

namespace E01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../../text.txt";

            int count = 0;

            using (var streamReader = new StreamReader(filePath))
            {
                string currentLine = streamReader.ReadLine();

                while (currentLine != null)
                {
                    if (count % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSpecialCharacters(currentLine);
                        string reversedWords = ReverseWords(replacedSymbols);

                        Console.WriteLine(reversedWords);
                    }

                    currentLine = streamReader.ReadLine();

                    count++;
                }
            }
        }
        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse().ToArray());
        }

        private static string ReplaceSpecialCharacters(string currentLine)
        {
            return currentLine.Replace(oldValue: "-", newValue: "@")
                 .Replace(oldValue: ",", newValue: "@")
                 .Replace(oldValue: ".", newValue: "@")
                 .Replace(oldValue: "!", newValue: "@")
                 .Replace(oldValue: "?", newValue: "@");
        }
    }
}
