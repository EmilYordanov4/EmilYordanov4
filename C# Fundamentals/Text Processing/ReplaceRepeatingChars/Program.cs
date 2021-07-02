using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                int count = 0;
                for (int j = i + 1; j < input.Length; j++)
                {
                    char removableChar = input[j];
                    if (currChar == removableChar)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                input = input.Remove(i + 1, count);
            }
            Console.WriteLine(input);
        }
    }
}
