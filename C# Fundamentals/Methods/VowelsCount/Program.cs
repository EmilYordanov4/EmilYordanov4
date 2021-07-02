using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            int vowelsCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (IsVowel(word[i]))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
        }

        static bool IsVowel(char letter) 
        {
            return letter == 'a' || letter == 'i' || letter == 'o' || letter == 'e' || letter == 'u' || letter == 'y';
        }
    }
}
