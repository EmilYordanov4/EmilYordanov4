using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                if (!IsPalindome(number))
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }

                number = Console.ReadLine();
            }
        }

        static bool IsPalindome(string number)
        {
            int lenght = number.Length - 1;

            for (int i = 0; i <= lenght / 2; i++)
            {
                char firstHalf = number[0 + i];
                char secondHalf = number[lenght - i];

                if (firstHalf != secondHalf)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
