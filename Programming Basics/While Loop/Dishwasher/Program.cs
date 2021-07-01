using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesOfChemicals = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int loading = 0;

            int chemicalNeeded = 0;
            int pots1 = 0;
            int pots = 0;
            int dishes1 = 0;
            int dishes = 0;
            int chemical = bottlesOfChemicals * 750;

            while (input != "End")
            {
                loading++;
                int things = int.Parse(input);
                if (loading % 3 == 0)
                {
                    pots1 += things;
                    pots += things;
                    chemicalNeeded += pots * 15;
                    pots = 0;
                }
                else
                {
                    dishes1 += things;
                    dishes += things;
                    chemicalNeeded += dishes * 5;
                    dishes = 0;
                }
                if (chemicalNeeded > chemical)
                {
                    Console.WriteLine($"Not enough detergent, {chemicalNeeded - chemical} ml. more necessary!");
                    Environment.Exit(0);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{dishes1} dishes and {pots1} pots were washed.");
            Console.WriteLine($"Leftover detergent {chemical - chemicalNeeded} ml.");
        }
    }
}
