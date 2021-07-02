using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int sourceYielding = int.Parse(Console.ReadLine());

            int totalSpice = 0;
            int count = 0;

            while (sourceYielding >= 100)
            {
                totalSpice += sourceYielding;
                sourceYielding -= 10;
                count++;
                if (totalSpice >= 26)
                {
                    totalSpice -= 26;
                }
                else
                {
                    totalSpice -= totalSpice;
                }
            }
            if (totalSpice >= 0 && count != 0)
            {
                totalSpice -= 26;

            }
            Console.WriteLine($"{count}");
            Console.WriteLine($"{totalSpice}");
        }
    }
}
