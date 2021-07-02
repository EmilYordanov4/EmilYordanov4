using System;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = "./";
            string zipPath = "../copeMeAgain.zip";
            string extractPath = "../extract";

            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);

            
        }
    }
}
