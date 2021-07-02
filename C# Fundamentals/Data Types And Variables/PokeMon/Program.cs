using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokePowerHalf = pokePower;

            int count = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                count++;
                if (pokePower == pokePowerHalf * 0.50 && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
