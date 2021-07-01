using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtInCm = int.Parse(Console.ReadLine());
            int widghtInCm = int.Parse(Console.ReadLine());
            int heightInCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeFishTank = lenghtInCm * widghtInCm * heightInCm;
            double totalLiters = volumeFishTank * 0.001;
            double actualPercent = percent * 0.01;

            double litersNeeded = totalLiters * (1 - actualPercent);

            Console.WriteLine(litersNeeded);
        }
    }
}
