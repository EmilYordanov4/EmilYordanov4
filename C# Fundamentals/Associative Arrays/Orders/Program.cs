using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> productQuantity = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] information = input.Split(" ");
                if (!productPrice.ContainsKey(information[0]))
                {
                    productPrice[information[0]] = 0;
                    productQuantity[information[0]] = 0;
                }

                productPrice[information[0]] = decimal.Parse(information[1]);
                productQuantity[information[0]] += int.Parse(information[2]);

                input = Console.ReadLine();
            }

            foreach (var item in productPrice)
            {
                Console.WriteLine($"{item.Key} -> {item.Value * productQuantity[item.Key]:f2}");
            }
        }
    }
}
