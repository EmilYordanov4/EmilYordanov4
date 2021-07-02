using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removableWord = Console.ReadLine().ToLower();
            string startingWord = Console.ReadLine();

            while (startingWord.IndexOf(removableWord) != -1)
            {
                int index = startingWord.IndexOf(removableWord);
                startingWord = startingWord.Remove(index, removableWord.Length);
            }
            Console.WriteLine(startingWord);
        }
    }
}
