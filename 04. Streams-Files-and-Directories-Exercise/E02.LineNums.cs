using System;
using System.IO;
using System.Linq;

namespace E02.LineNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string outputPath = "output.txt";

           string[] textLines = File.ReadAllLines(textPath);

            int lineCount = 1;

            foreach (var currentLine in textLines)
            {
                int lettersCount = currentLine.Count(char.IsLetter);
                int puncCount = currentLine.Count(char.IsPunctuation);

                File.AppendAllText(outputPath, $"Line {lineCount}: {currentLine} ({lettersCount})({puncCount})" +
                    $"{Environment.NewLine}");

                lineCount++;
            }
        }
    }
}
