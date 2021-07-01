using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceForWashingmachine = double.Parse(Console.ReadLine());
            double priceForToys = double.Parse(Console.ReadLine());

            double moneyRecieved = 0;
            double moneyRecievedPerB = 9.00;
            double sum = 0;
            int toysRecieved = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyRecieved += moneyRecievedPerB;
                    moneyRecievedPerB += 10.00;
                }
                else
                {
                    toysRecieved += 1;
                }
            }
            sum = moneyRecieved + priceForToys * toysRecieved;

            if (sum >= priceForWashingmachine)
            {
                Console.WriteLine($"Yes! {sum - priceForWashingmachine:F2}"); 
            }
            else if (sum < priceForWashingmachine)
            {
                Console.WriteLine($"No! {priceForWashingmachine - sum:F2}"); //She miesh na ruka, kurvo!
            }
        }
    }
}
