using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            EntireTriangle(number);
        }

        static void EntireTriangle(int number)
        {
            UpperPart(number);
            BottomPart(number);

        }


        static void UpperPart(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void BottomPart(int number)
        {
            for (int i = number; i >= 1 ; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
