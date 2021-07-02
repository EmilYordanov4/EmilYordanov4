using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            Console.WriteLine(Pow(number, pow));

            static double Pow(double number, double pow) 
            {
                return Math.Pow(number, pow);
            }
        }
    }
}
