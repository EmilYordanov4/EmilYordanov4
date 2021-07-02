using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "Input.txt");
            var dest = Path.Combine("data", "Output.txt");

            string[] text = File.ReadAllLines(path);

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = $"{i + 1}. {text[i]}";
            }
            File.WriteAllLines(dest, text);
        }
    }
}
