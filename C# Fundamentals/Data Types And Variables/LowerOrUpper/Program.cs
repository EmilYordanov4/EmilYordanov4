using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            int number = input;
            
            if (number >= 97)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
