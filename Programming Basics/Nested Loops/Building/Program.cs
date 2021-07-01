using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int l = floors; l == floors; l++)
            {
                for (int k = 0; k < rooms; k++)
                {
                    Console.Write($"L{l}{k} ");
                }
                Console.WriteLine();
            }

            floors--;

            for (int i = floors; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    for (int k = 0; k < rooms; k++)
                    {
                        Console.Write($"O{i}{k} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 0; k < rooms; k++)
                    {
                        Console.Write($"A{i}{k} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
