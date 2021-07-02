using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;

            double maxVolume = 0;
            double kegVolume = 0;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                kegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (kegVolume >= maxVolume)
                {
                    maxVolume = kegVolume;
                    biggestKeg = kegName;
                }
                kegVolume = 0;
            }
            Console.WriteLine($"{biggestKeg}");
        }
    }
}
