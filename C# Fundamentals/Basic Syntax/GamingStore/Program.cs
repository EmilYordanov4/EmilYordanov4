using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string games = Console.ReadLine();

            double currentMoney = balance;
            double moneySpend = 0;

            while (games != "Game Time")
            {
                if (currentMoney == 0)
                {
                    Console.WriteLine($"Out of money!");
                    break;
                }
                else if (games == "OutFall 4")
                {
                    if (currentMoney >= 39.99)
                    {
                        moneySpend += 39.99;
                        Console.WriteLine($"Bought {games}");
                        currentMoney -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (games == "CS: OG")
                {
                    if (currentMoney >= 15.99)
                    {
                        moneySpend += 15.99;
                        Console.WriteLine($"Bought {games}");
                        currentMoney -= 15.99;
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (games == "Zplinter Zell")
                {
                    if (currentMoney >= 19.99)
                    {
                        moneySpend += 19.99;
                        Console.WriteLine($"Bought {games}");
                        currentMoney -= 19.99;
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (games == "Honored 2")
                {
                    if (currentMoney >= 59.99)
                    {
                        moneySpend += 59.99;
                        Console.WriteLine($"Bought {games}");
                        currentMoney -= 59.99;
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (games == "RoverWatch")
                {
                    if (currentMoney >= 29.99)
                    {
                        moneySpend += 29.99;
                        Console.WriteLine($"Bought {games}");
                        currentMoney -= 29.99;
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (games == "RoverWatch Origins Edition")
                {
                    if (currentMoney >= 39.99)
                    {
                        moneySpend += 39.99;
                        Console.WriteLine($"Bought {games}");
                        currentMoney -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine($"Not Found");
                }

                games = Console.ReadLine();
            }
            if (currentMoney == 0)
            {
                Console.WriteLine($"Out of money!");
            }
            else if (games == "Game Time" && currentMoney > 0)
            {
                Console.WriteLine($"Total spent: ${moneySpend:F2}. Remaining: ${balance - moneySpend:F2}");
            }
        }
    }
}
