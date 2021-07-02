using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");

            for (int i = 0; i < words.Length; i++)
            {
                string testingWord = words[i];
                bool isValid = true;
                for (int j = 0; j < testingWord.Length; j++)
                {
                    if (!char.IsLetterOrDigit(testingWord[j]) && testingWord[j] != '-' && testingWord[j] != '_')
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid == true && words[i].Length >= 3 && words[i].Length <= 16)
                {
                    Console.WriteLine($"{words[i]}");
                }
            }
        }
    }
}
