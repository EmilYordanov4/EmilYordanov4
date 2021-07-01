using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositMonth = int.Parse(Console.ReadLine());
            double perYear = double.Parse(Console.ReadLine());

            double lihva = deposit * perYear / 100;
            double lihvaMesec = lihva / 12;
            double sum = deposit + (depositMonth * lihvaMesec);
            
            Console.WriteLine(sum);
        }
    }
}
