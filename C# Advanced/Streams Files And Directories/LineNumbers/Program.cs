using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            string outputPath = "output.txt";
            string[] lines = File.ReadAllLines(path);

            int letterCounter = 0;
            int punctuationCounter = 0;
            int counter = 1;
            for (int i = 0; i < lines.Length; i++)
            {
                string word = lines[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (char.IsLetter(word[j]))
                    {
                        letterCounter++;
                    }
                    else if (char.IsPunctuation(word[j]))
                    {
                        punctuationCounter++;
                    }
                }
                lines[i] = $"Line{counter}: {word} ({letterCounter})({punctuationCounter})";
                letterCounter = 0;
                punctuationCounter = 0;
                counter++;
            }
            File.WriteAllLines(outputPath, lines);
        }
    }
}
