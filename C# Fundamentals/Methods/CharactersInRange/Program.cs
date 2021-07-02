using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());

            int startingInt = Math.Min(firstInput, secondInput);
            int endingInt = Math.Max(firstInput, secondInput);

            for (int i = startingInt + 1; i < endingInt; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }

        }
    }
}
