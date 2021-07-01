using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            
            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {money:F2}");
                sum += money;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
