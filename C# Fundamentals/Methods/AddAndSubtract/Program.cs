using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtracting(Summing(firstNum, secondNum), thirdNum));
        }

        static int Summing(int first, int second) 
        {
            return first + second;
        }

        static int Subtracting(int first, int second) 
        {
            return first - second;
        }
    }
}
