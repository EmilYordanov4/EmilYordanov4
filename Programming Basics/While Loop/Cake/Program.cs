using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int cake = width * lenght;
            int sumPieces = 0;

            while (input != "STOP")
            {
                int pieces = int.Parse(input);
                sumPieces += pieces;

                if (sumPieces > cake)
                {
                    Console.WriteLine($"No more cake left! You need {sumPieces - cake} pieces more.");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{cake - sumPieces} pieces are left.");
        }
    }
}
