using System;

namespace CareОfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgFood = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int totalFoodInGrams = kgFood * 1000;
            int sum = 0;

            while (input != "Adopted")
            {
                int eatenFood = int.Parse(input);
                
                sum += eatenFood;

                input = Console.ReadLine();
            }

            if (totalFoodInGrams >= sum)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalFoodInGrams - sum} grams.");
            }
            else if (totalFoodInGrams < sum)
            {
                Console.WriteLine($"Food is not enough. You need {sum - totalFoodInGrams} grams more.");
            }
        }
    }
}
