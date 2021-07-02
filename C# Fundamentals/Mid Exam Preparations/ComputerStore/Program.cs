using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            string input = Console.ReadLine();
            while (input != "special" && input != "regular")
            {
                decimal priceOfItem = decimal.Parse(input);
                if (priceOfItem < 0)
                {
                    Console.WriteLine($"Invalid price!");
                }
                else if (priceOfItem == 0)
                {
                    Console.WriteLine($"Invalid order!");
                }
                else
                {
                    sum += priceOfItem;
                }

                input = Console.ReadLine();
            }
            if (sum <= 0)
            {
                Console.WriteLine($"Invalid order!");
            }
            else
            {
                decimal taxes = sum * 0.20m;
                decimal totalPriceWithoutTaxes = sum;
                decimal totalPrice = taxes + sum;
                if (input == "special")
                {
                    totalPrice -= totalPrice * 0.10m;
                }
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
