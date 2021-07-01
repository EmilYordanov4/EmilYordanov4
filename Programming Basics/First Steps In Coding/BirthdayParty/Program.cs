using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentForHall = double.Parse(Console.ReadLine());

            double cakePrice = rentForHall * 0.20;
            double drinksPrice = cakePrice - cakePrice * 0.45;
            double animatorPrice = rentForHall / 3;

            double kachpara = rentForHall + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(kachpara);
        }
    }
}
