using System;
using System.Dynamic;

namespace TankFuel2
{
    class Program
    {
        static void Main(string[] args)
        {
            double benzin = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            string fuel = Console.ReadLine();
            double quantityFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            if (clubCard == "Yes")
            {
                benzin -= 0.18;
                diesel -= 0.12;
                gas -= 0.08;
            }
            if (fuel == "Gas" && quantityFuel <20)
            {
                double price = gas * quantityFuel;
                Console.WriteLine($"{price:F2} lv.");
            }
            else if (fuel == "Gas" && quantityFuel >= 20 && quantityFuel <= 25)
            {
                double price = gas * quantityFuel;
                double priceWithSale = price - price * 0.08;
                Console.WriteLine($"{priceWithSale:F2} lv.");
            }
            else if (fuel == "Gas" && quantityFuel > 25)
            {
                double price = gas * quantityFuel;
                double priceWithSale = price - price * 0.10;
                Console.WriteLine($"{priceWithSale:F2} lv.");
            }
            else if (fuel == "Diesel" && quantityFuel < 20)
            {
                double price = diesel * quantityFuel;
                Console.WriteLine($"{price:F2} lv.");
            }
            else if (fuel == "Diesel" && quantityFuel >= 20 && quantityFuel <= 25)
            {
                double price = diesel * quantityFuel;
                double priceWithSale = price - price * 0.08;
                Console.WriteLine($"{priceWithSale:F2} lv.");
            }
            else if (fuel == "Diesel" && quantityFuel > 25)
            {
                double price = diesel * quantityFuel;
                double priceWithSale = price - price * 0.10;
                Console.WriteLine($"{priceWithSale:F2} lv.");
            }
            else if (fuel == "Gasoline" && quantityFuel < 20)
            {
                double price = benzin * quantityFuel;
                Console.WriteLine($"{price:F2} lv.");
            }
            else if (fuel == "Gasoline" && quantityFuel >= 20 && quantityFuel <= 25)
            {
                double price = benzin * quantityFuel;
                double priceWithSale = price - price * 0.08;
                Console.WriteLine($"{priceWithSale:F2} lv.");
            }
            else if (fuel == "Gasoline" && quantityFuel > 25)
            {
                double price = benzin * quantityFuel;
                double priceWithSale = price - price * 0.10;
                Console.WriteLine($"{priceWithSale:F2} lv.");
            }
        }
    }
}
