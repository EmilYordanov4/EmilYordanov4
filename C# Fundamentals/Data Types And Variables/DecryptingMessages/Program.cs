using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int letters = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < letters; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int characterKey = character + key;
                char finalCharacter = (char)characterKey;
                word += finalCharacter;
            }
            Console.WriteLine(word);
        }
    }
}
    