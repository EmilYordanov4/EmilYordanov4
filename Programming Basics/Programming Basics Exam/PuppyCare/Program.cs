using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgsFood = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int totalEatenFood = 0;
            int totalFood = kgsFood * 1000;

            while (input != "Adopted")
            {
                int eatenFood = int.Parse(input);
                totalEatenFood += eatenFood;
                input = Console.ReadLine();
            }
            if (totalEatenFood <= totalFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalFood - totalEatenFood} grams.");
            }
            else if (totalEatenFood > totalFood)
            {
                Console.WriteLine($"Food is not enough. You need {totalEatenFood - totalFood} grams more.");
            }
        }
    }
}
