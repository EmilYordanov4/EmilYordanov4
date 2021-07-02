using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "copyMe.png";
            string output = "copiedMe.png";
            using FileStream reader = new FileStream(path, FileMode.Open);
            using FileStream writer = new FileStream(output, FileMode.Create);

            byte[] buffer = new byte[4096];
            int counter = -1;

            while (counter != 0)
            {
                counter = reader.Read(buffer, 0, buffer.Length);
                writer.Write(buffer);
            }
        }
    }
}
