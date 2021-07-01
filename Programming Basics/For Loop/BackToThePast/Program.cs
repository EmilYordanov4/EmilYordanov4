using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneySaved = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double moneySpend = 0;
            int yearsOld = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpend += 12000;
                }
                else
                {
                    moneySpend += 12000 + 50 * yearsOld;
                }
                yearsOld++;
            }

            if (moneySaved < moneySpend)
            {
                Console.WriteLine($"He will need {moneySpend - moneySaved:F2} dollars to survive.");
            }
            else if (moneySaved > moneySpend)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneySaved - moneySpend:F2} dollars left.");
            }
        }
    }
}
