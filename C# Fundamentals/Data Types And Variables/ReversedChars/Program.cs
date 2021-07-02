using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstOne = char.Parse(Console.ReadLine());
            char secondOne = char.Parse(Console.ReadLine());
            char thirdOne = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdOne} {secondOne} {firstOne}");
        }
    }
}
