using System;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int totalHours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double price = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (timeOfDay == "day")
                {
                    price += 10.50;
                }
                else if (timeOfDay == "night")
                {
                    price += 8.40;
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (timeOfDay == "day")
                {
                    price += 12.60;
                }
                else if (timeOfDay == "night")
                {
                    price += 10.20;
                }
            }
            if (people >= 4)
            {
                price -= price * 10 / 100;
            }
            if (totalHours >= 5)
            {
                price -= price * 50 / 100;
            }

            Console.WriteLine($"Price per person for one hour: {price:F2}");
            Console.WriteLine($"Total cost of the visit: {price * people * totalHours:F2}");
        }
    }
}
