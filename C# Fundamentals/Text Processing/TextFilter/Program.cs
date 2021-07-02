using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string replaceWord = new string('*', word.Length);
                text = text.Replace(word, replaceWord);
            }

            Console.WriteLine(text);
        }
    }
}
