using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double sum = 0;

            if (season == "Spring")
            {
                sum = 3000;

                if (fishermans <= 6 )
                {
                    sum -= sum * 0.10;
                }
                else if (fishermans > 7 && fishermans <= 11)
                {
                    sum -= sum * 0.15;
                }
                else if (fishermans > 12)
                {
                    sum -= sum * 0.25;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                sum = 4200;

                if (fishermans <= 6)
                {
                    sum -= sum * 0.10;
                }
                else if (fishermans > 7 && fishermans <= 11)
                {
                    sum -= sum * 0.15;
                }
                else if (fishermans > 12)
                {
                    sum -= sum * 0.25;
                }
            }
            else if (season == "Winter")
            {
                sum = 2600;

                if (fishermans <= 6)
                {
                    sum -= sum * 0.10;
                }
                else if (fishermans > 7 && fishermans <= 11)
                {
                    sum -= sum * 0.15;
                }
                else if (fishermans > 12)
                {
                    sum -= sum * 0.25;
                }
            }

            if (fishermans % 2 == 0 && season != "Autumn" )
            {
                sum -= sum * 0.05;
            }

            if (budget >= sum)
            {
                Console.WriteLine($"Yes! You have {budget - sum:F2} leva left.");
            }
            else if (sum > budget)
            {
                Console.WriteLine($"Not enough money! You need {sum - budget:F2} leva.");
            }
        }
    }
}
