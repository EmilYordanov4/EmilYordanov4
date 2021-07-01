using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberOne = 0;

            for (int i = 0; i < number; i++)
            {

                numberOne += int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"{numberOne}");
        }
    }
}