using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            List<string> info = new List<string>();
            using StreamReader reader = new StreamReader(path);
            int count = 0;
            while (!reader.EndOfStream)
            {
                string[] lines = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (count++ % 2 == 0)
                {
                    for (int i = 0; i < lines.Length / 2; i++)
                    {
                        string temp = lines[i];
                        lines[i] = lines[lines.Length - i - 1];
                        lines[lines.Length - i - 1] = temp;
                    }
                    string word = string.Join(" ", lines);
                    word = word.Replace('-', '@');
                    word = word.Replace(',', '@');
                    word = word.Replace('.', '@');
                    word = word.Replace('!', '@');
                    word = word.Replace('?', '@');

                    Console.WriteLine(word);
                }
            }
        }
    }
}
