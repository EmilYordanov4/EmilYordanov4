using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int rosesPrice = 5;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            int narcissusPrice = 3;
            double gladiolusPrice = 2.50;

            double sum = 0;

            if (flower == "Roses")
            {
                sum = quantity * rosesPrice;
                if (quantity > 80)
                {
                    sum -= sum * 0.10;
                }
            }
            else if (flower == "Dahlias")
            {
                sum = quantity * dahliasPrice;
                if (quantity > 90)
                {
                    sum -= sum * 0.15;
                }
            }
            else if (flower == "Tulips")
            {
                sum = quantity * tulipsPrice;
                if (quantity > 80)
                {
                    sum -= sum * 0.15;
                }
            }
            else if (flower == "Narcissus")
            {
                sum = quantity * narcissusPrice;
                if (quantity < 120)
                {
                    sum += sum * 0.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                sum = quantity * gladiolusPrice;
                if (quantity < 80)
                {
                    sum += sum * 0.20;
                }
            }

            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - sum:F2} leva left.");
            }
            else if (budget < sum)
            {
                Console.WriteLine($"Not enough money, you need {sum - budget:F2} leva more.");
            }
        }
    }
}
