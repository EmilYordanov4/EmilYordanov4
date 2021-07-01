using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int volume = width * length * height;

            int allBoxes = 0;

            while (input != "Done")
            {
                int number = int.Parse(input);

                allBoxes += number;
                if (allBoxes > volume)
                {
                    Console.WriteLine($"No more free space! You need {allBoxes - volume} Cubic meters more.");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{volume - allBoxes} Cubic meters left.");
        }
    }
}
