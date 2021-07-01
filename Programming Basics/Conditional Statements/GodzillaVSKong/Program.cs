using System;

namespace GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            double decor= budget * 0.10;
            double priceClothing = statists * pricePerStatist;

            if (statists > 150)
            {
                priceClothing -= priceClothing * 0.10;
            }

            double totalSum = priceClothing + decor;

            if (totalSum <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalSum:F2} leva left.");
            }
            else if(totalSum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum - budget:F2} leva more.");
            }
            
        }
    }
}
