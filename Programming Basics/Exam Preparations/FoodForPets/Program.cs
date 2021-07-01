using System;

namespace FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double quantityEatenFood = double.Parse(Console.ReadLine());

            double sum = 0;
            double sumDog = 0;
            double sumCat = 0;
            double bonus = 0;
            double biscuits = 0;

            for (int i = 1; i <= n; i++)
            {
                double quantityEatenFoodDog = double.Parse(Console.ReadLine());
                double quantityEatenFoodCat = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    bonus = (quantityEatenFoodCat + quantityEatenFoodDog);
                    biscuits += bonus / 10;
                }
                bonus = 0;
                sumDog += quantityEatenFoodDog;
                sumCat += quantityEatenFoodCat;
                sum = sumCat + sumDog;
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{sum / quantityEatenFood * 100:F2}% of the food has been eaten.");
            Console.WriteLine($"{sumDog / sum * 100:F2}% eaten from the dog.");
            Console.WriteLine($"{sumCat / sum * 100:F2}% eaten from the cat.");
        }
    }
}
