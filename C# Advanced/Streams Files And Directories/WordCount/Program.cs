using System;
using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathForLines = "text.txt";
            string pathForWords = "words.txt";
            string[] lines = File.ReadAllLines(pathForLines);
            string[] words = File.ReadAllLines(pathForWords);

            Dictionary<string, int> counter = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                counter.Add(words[i], 0);
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                for (int j = 0; j < line.Length; j++)
                {
                    if (counter.ContainsKey(line))
                    {

                    }
                }
            }
            
        }
    }
}
