using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathFileOne = Path.Combine("data", "FileOne.txt");
            var pathFileTwo = Path.Combine("data", "FileTwo.txt");

            var dest = Path.Combine("data", "MergedFile.txt");

            int[] fileOne = File.ReadAllLines(pathFileOne).Select(int.Parse).ToArray();
            int[] fileTwo = File.ReadAllLines(pathFileTwo).Select(int.Parse).ToArray();

            List<int> merged = new List<int>();
            for (int i = 0; i < fileOne.Length; i++)
            {
                merged.Add(fileOne[i]);
            }
            for (int j = 0; j < fileTwo.Length; j++)
            {
                merged.Add(fileTwo[j]);
            }

            merged = merged.OrderBy(a => a).ToList();

            File.WriteAllLines(dest, merged.Select(a => a.ToString()));
        }
    }
}
