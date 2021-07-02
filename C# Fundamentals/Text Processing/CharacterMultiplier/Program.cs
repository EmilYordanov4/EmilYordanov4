using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string firstWord = words[0];
            string secondWord = words[1];
            int sum = 0;
            if (firstWord.Length >= secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length ; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }
                for (int j = secondWord.Length; j < firstWord.Length; j++)
                {
                    sum += firstWord[j];
                }
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }
                for (int j = firstWord.Length; j < secondWord.Length; j++)
                {
                    sum += secondWord[j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
