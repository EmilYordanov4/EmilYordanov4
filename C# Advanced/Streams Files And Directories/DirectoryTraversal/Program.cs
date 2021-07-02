using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string extention = ".";
            string path = "./";
            string[] info = Directory.GetFiles(path, $"*{extention}*");

            Dictionary<string, Dictionary<string, long>> allFiles = new Dictionary<string, Dictionary<string, long>>();

            foreach (string item in info)
            {
                FileInfo fileInfo = new FileInfo(item);

                string fileExtention = fileInfo.Extension;
                string fileName = fileInfo.Name;
                long fileSize = fileInfo.Length;
                if (!allFiles.ContainsKey(fileExtention))
                {
                    allFiles.Add(fileExtention, new Dictionary<string, long>());
                }
                allFiles[fileExtention].Add(fileName, fileSize);

            }

            List<string> output = new List<string>();

            foreach (var item in allFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                output.Add($"{item.Key}");
                foreach (var kvp in item.Value.OrderBy(x => x.Value))
                {
                    output.Add($"--{kvp.Key} - {kvp.Value}kb");
                }
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string outputPath = Path.Combine(desktopPath, "report.txt");
            File.WriteAllLines(outputPath, output);

        }
    }
}
