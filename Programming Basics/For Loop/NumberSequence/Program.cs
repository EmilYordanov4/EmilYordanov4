using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int kur = int.MaxValue;
            int kurva = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > kurva)
                {
                    kurva = number;

                }
                if (number < kur)
                {
                    kur = number;
                }
            }
                    Console.WriteLine($"Max number: {kurva}");
                    Console.WriteLine($"Min number: {kur}");
        }
    }
}
