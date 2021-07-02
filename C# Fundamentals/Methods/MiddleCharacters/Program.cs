using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            GettingMiddleCharacter(word);
        }

        static void GettingMiddleCharacter(string word) 
        {
            if (word.Length % 2 == 0)
            {
                char midOne = word[word.Length / 2 - 1];
                char midTwo = word[word.Length / 2];
                Console.WriteLine($"{midOne}{midTwo}");
            }
            else
            {
                char mid = word[word.Length / 2];
                Console.WriteLine(mid);
            }
        }
    }
}
