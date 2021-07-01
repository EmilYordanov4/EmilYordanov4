using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";
            string type = "";

            if (budget <= 100)
            {
                place = "Bulgaria";

                if (season == "summer")
                {
                    type = "Camp";
                    budget *= 0.30;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    budget *= 0.70;
                }
            }
            else if (budget <= 1000)
            {
                place = "Balkans";

                if (season == "summer")
                {
                    type = "Camp";
                    budget *= 0.40;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    budget *= 0.80;
                }
            }
            else if (budget > 1000)
            {
                place = "Europe";

                if (season == "summer")
                {
                    type = "Hotel";
                    budget *= 0.90;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    budget *= 0.90;
                }
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{type} - {budget:F2}");
        }
    }
}
