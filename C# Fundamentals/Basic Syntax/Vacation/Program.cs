using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerPerson = 0;
            double sum = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    pricePerPerson += 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson += 9.80;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson += 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    pricePerPerson += 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson += 15.60;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson += 16;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerPerson += 15;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson += 20;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson += 22.50;
                }
            }
            
            sum = pricePerPerson * people;

            if (type == "Students" && people >= 30)
            {
                sum -= sum * 0.15;
            }
            else if (type == "Business" && people >= 100)
            {
                sum -= pricePerPerson * 10;
            }
            else if (type == "Regular" && people >= 10 && people <= 20)
            {
                sum -= sum * 0.05;
            }

            Console.WriteLine($"Total price: {sum:F2}");
        }
    }
}
