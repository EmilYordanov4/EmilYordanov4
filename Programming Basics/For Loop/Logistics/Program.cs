using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double bus = 200;
            double truck = 175;
            double train = 120;

            int busTonnage = 0;
            int truckTonnage = 0;
            int trainTonnage = 0;

            double price = 0;
            double entireTonnage = 0;


            for (int i = 0; i < n; i++)
            {
                int tonnage = int.Parse(Console.ReadLine());

                if (tonnage <= 3)
                {
                    price += tonnage * bus;
                    entireTonnage += tonnage;
                    busTonnage += tonnage;
                }
                else if (tonnage >= 4 && tonnage <= 11)
                {
                    price += tonnage * truck;
                    entireTonnage += tonnage;
                    truckTonnage += tonnage;
                }
                else if (tonnage >= 12)
                {
                    price += tonnage * train;
                    entireTonnage += tonnage;
                    trainTonnage += tonnage;
                }
            }
            double averagePrice = price / entireTonnage;

            Console.WriteLine($"{averagePrice:F2}");
            Console.WriteLine($"{busTonnage / entireTonnage * 100:F2}%");
            Console.WriteLine($"{truckTonnage / entireTonnage * 100:F2}%");
            Console.WriteLine($"{trainTonnage / entireTonnage * 100:F2}%");
        }
    }
}
