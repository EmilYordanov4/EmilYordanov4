using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litres = double.Parse(Console.ReadLine());

            if ((fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas") && litres >= 25)
            {
                Console.WriteLine($"You have enough {fuel.ToLower()}.");
            }
            else if ((fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas") && litres < 25)
            {
                Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
            
        }
    }
}
