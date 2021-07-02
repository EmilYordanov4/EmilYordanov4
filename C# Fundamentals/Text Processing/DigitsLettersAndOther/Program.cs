using System;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string characters = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char test = input[i];
                
                if (char.IsDigit(test))
                {
                    digits += test;
                }
                else if (char.IsLetter(test))
                {
                    letters += test;
                }
                else
                {
                    characters += test;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}
