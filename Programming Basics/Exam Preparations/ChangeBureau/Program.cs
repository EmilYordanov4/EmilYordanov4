using System;

namespace ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double chineseMoney = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            int bitcoinPrice = 1168;
            double chineseMoneyPrice = 0.15;
            double dollarPrice = 1.76;
            double euroPrice = 1.95;

            int totalBitcoin = bitcoin * bitcoinPrice;
            double ioans = chineseMoney * chineseMoneyPrice;
            double totalLeva = totalBitcoin + ioans * dollarPrice;

            double totalEuro = totalLeva / euroPrice;

            Console.WriteLine($"{totalEuro - totalEuro * commission / 100:F2}");
        }
    }
}
