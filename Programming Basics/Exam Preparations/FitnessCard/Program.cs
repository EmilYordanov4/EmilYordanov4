using System;
using System.Runtime.InteropServices.ComTypes;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double cost = 0;

            if (gender == 'm')
            {
                switch (sport)
                {
                    case "Gym":
                        cost += 42;
                        break;
                    case "Boxing":
                        cost += 41;
                        break;
                    case "Yoga":
                        cost += 45;
                        break;
                    case "Zumba":
                        cost += 34;
                        break;
                    case "Dances":
                        cost += 51;
                        break;
                    case "Pilates":
                        cost += 39;
                        break;
                }
            }
            else if (gender == 'f')
            {
                switch (sport)
                {
                    case "Gym":
                        cost += 35;
                        break;
                    case "Boxing":
                        cost += 37;
                        break;
                    case "Yoga":
                        cost += 42;
                        break;
                    case "Zumba":
                        cost += 31;
                        break;
                    case "Dances":
                        cost += 53;
                        break;
                    case "Pilates":
                        cost += 37;
                        break;
                }
            }
            if (age <= 19)
            {
                cost -= cost * 20 / 100;
            }
            if (sum >= cost)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport:F2}.");
            }
            else if (sum < cost)
            {
                Console.WriteLine($"You don't have enough money! You need ${cost - sum:F2} more.");
            }
        }
    }
}
