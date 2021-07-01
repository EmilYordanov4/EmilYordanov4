using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double haveMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int daysSpend = 0;
            while (haveMoney < neededMoney)
            {
                days++;
                string action = Console.ReadLine();
                double actionMoney = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    daysSpend++;
                    if (daysSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                    haveMoney -= actionMoney;
                    if (haveMoney < 0 )
                    {
                        haveMoney = 0;
                    }
                }
                else if (action == "save")
                {
                    daysSpend = 0;
                    haveMoney += actionMoney;
                }
            }
            if (haveMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }

        }
    }
}
