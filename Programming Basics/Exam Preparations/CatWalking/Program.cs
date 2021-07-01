using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForWalk = int.Parse(Console.ReadLine());
            int walkForTheDay = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int totalCaloriesBurned = timeForWalk * walkForTheDay * 5;
            int caloriesNeeded = calories * 50 / 100;

            if (caloriesNeeded <= totalCaloriesBurned)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurned}.");
            }
        }
    }
}
