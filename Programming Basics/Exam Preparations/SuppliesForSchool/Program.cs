using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int sharpie = int.Parse(Console.ReadLine());
            double chemical = double.Parse(Console.ReadLine());
            int sale = int.Parse(Console.ReadLine());

            double penPrice = 5.80;
            double sharpiePrice = 7.20;
            double chemicalPricePerLiter = 1.20;

            double sum = pens * penPrice + sharpie * sharpiePrice + chemical * chemicalPricePerLiter;
            double totalSum = sum - sum * sale / 100;

            Console.WriteLine($"{totalSum:F3}");
        }
    }
}
