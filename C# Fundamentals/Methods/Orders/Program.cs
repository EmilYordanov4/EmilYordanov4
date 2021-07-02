using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double result = 0;
            if (product == "coffee")
            {
                result = (Coffee(1.50, quantity));
            }
            else if (product == "water")
            {
                result = (Water(1.00, quantity));
            }
            else if (product == "coke")
            {
                result = (Coke(1.40, quantity));
            }
            else if (product == "snacks")
            {
                result = (Snacks(2.00, quantity));
            }
            Console.WriteLine($"{result:F2}");
        }

        static double Coffee(double price, double quantity)
        {
            return price * quantity;
        }

        static double Water(double price, double quantity)
        {
            return price * quantity;
        }

        static double Coke(double price, double quantity)
        {
            return price * quantity;
        }

        static double Snacks(double price, double quantity)
        {
            return price * quantity;
        }
    }
}
