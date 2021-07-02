using System;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            string[] eachNumber = numbers.Split(' ');

            foreach (string item in eachNumber)
            {
                double number = double.Parse(item);
                Console.WriteLine($"{number} => {(int)Math.Round(number, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
