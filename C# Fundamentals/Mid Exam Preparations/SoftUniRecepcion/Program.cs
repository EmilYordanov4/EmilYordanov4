using System;

namespace SoftUniRecepcion
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            int students = int.Parse(Console.ReadLine());

            int count = 0;
            while (students > 0)
            {
                count++;
                
                if (count % 4 == 0)
                {
                    continue;
                }
                else
                {
                    students -= sum;
                }
            }

            Console.WriteLine($"Time needed: {count}h.");
        }
    }
}
