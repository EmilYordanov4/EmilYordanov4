using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                int peopleInTheGroup = int.Parse(Console.ReadLine());
                total += peopleInTheGroup;

                if (peopleInTheGroup <= 5)
                {
                    p1 += peopleInTheGroup;
                }
                else if (peopleInTheGroup <= 12)
                {
                    p2 += peopleInTheGroup;
                }
                else if (peopleInTheGroup <= 25)
                {
                    p3 += peopleInTheGroup;
                }
                else if (peopleInTheGroup <= 40)
                {
                    p4 += peopleInTheGroup;
                }
                else
                {
                    p5 += peopleInTheGroup;
                }
            }
            Console.WriteLine($"{p1 * 1.00 / total * 100:F2}%");
            Console.WriteLine($"{p2 * 1.00 / total * 100:F2}%");
            Console.WriteLine($"{p3 * 1.00 / total * 100:F2}%");
            Console.WriteLine($"{p4 * 1.00 / total * 100:F2}%");
            Console.WriteLine($"{p5 * 1.00 / total * 100:F2}%");
        }
    }
}
