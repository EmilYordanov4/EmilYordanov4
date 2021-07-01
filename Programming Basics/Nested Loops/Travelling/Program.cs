using System;
using System.Security.Cryptography;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    Environment.Exit(0);
                }
                double budgetNeeded = double.Parse(Console.ReadLine());
                double investment = double.Parse(Console.ReadLine());
                double budget = 0;

                while (destination != "End")
                {
                    budget += investment;

                    if (budget >= budgetNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                    investment = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}
