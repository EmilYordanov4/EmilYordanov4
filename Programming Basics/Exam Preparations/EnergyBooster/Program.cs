using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string size = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());

            double rawMoney = 0;
            double totalMoney = 0;

            if (size == "big")
            {
                switch (input)
                {
                    case "Watermelon":
                        rawMoney = 5 * sets * 28.70;
                        break;
                    case "Mango":
                        rawMoney = 5 * sets * 19.60;
                        break;
                    case "Pineapple":
                        rawMoney = 5 * sets * 24.80;
                        break;
                    case "Raspberry":
                        rawMoney = 5 * sets * 15.20;
                        break;
                }
            }
            else if (size == "small")
            {
                switch (input)
                {
                    case "Watermelon":
                        rawMoney = 2 * sets * 56;
                        break;
                    case "Mango":
                        rawMoney = 2 * sets * 36.66;
                        break;
                    case "Pineapple":
                        rawMoney = 2 * sets * 42.10;
                        break;
                    case "Raspberry":
                        rawMoney = 2 * sets * 20;
                        break;
                }
            }
            if (rawMoney >= 400 && rawMoney <= 1000)
            {
                rawMoney -= rawMoney * 15 / 100;
            }
            else if (rawMoney >  1000)
            {
                rawMoney -= rawMoney / 2;
            }

            Console.WriteLine($"{rawMoney:F2} lv.");
        }
    }
}
