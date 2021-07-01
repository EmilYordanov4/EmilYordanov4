using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysForCampaign = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakePrice = 45;
            double wafflesPrice = 5.80;
            double pancakesPrice = 3.20;

            int cakesSum = cakes * cakePrice;
            double wafflesSum = waffles * wafflesPrice;
            double pancakesSum = pancakes * pancakesPrice;

            double sumPerDay = (cakesSum + wafflesSum + pancakesSum) * bakers;
            double sumFromCampaign = sumPerDay * daysForCampaign;
            double sumAfterPayment = sumFromCampaign - sumFromCampaign / 8;

            Console.WriteLine(sumAfterPayment);
        }
    }
}
