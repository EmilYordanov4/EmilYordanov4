using System;
using System.Collections.Generic;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "Input.txt");
            var dest = Path.Combine("data", "Output.txt");

            string[] reading = File.ReadAllLines(path);
            List<string> text = new List<string>();
            for (int i = 0; i < reading.Length; i++)
            {
                if (i % 2 != 0)
                {
                    text.Add(reading[i]);
                }
            }

            File.WriteAllLines(dest, text);
        }
    }
}
