using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasQuantity = double.Parse(Console.ReadLine());
            double orangesQuantity = double.Parse(Console.ReadLine());
            double raspberriesQuantity = double.Parse(Console.ReadLine());
            double strawberriesQuantity = double.Parse(Console.ReadLine());

            double raspberriesSumPerKg = strawberriesPrice / 2;
            double orangesSumPerKg = raspberriesSumPerKg - (raspberriesSumPerKg * 0.4);
            double bananasSumPerKg = raspberriesSumPerKg - (raspberriesSumPerKg * 0.8);

            double raspberriesSum = raspberriesQuantity * raspberriesSumPerKg;
            double orangesSum = orangesQuantity * orangesSumPerKg;
            double bananasSum = bananasQuantity * bananasSumPerKg;
            double strawberriesSum = strawberriesQuantity * strawberriesPrice;

            double kachpara = raspberriesSum + orangesSum + bananasSum + strawberriesSum;

            Console.WriteLine($"{kachpara:F2}");
        }
    }
}
