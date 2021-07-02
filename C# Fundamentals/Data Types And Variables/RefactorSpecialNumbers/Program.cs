using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int totalSum = 0;
            bool numberIs = false;
            for (int ch = 1; ch <= input; ch++)
            {
                int number = ch;
                while (number > 0)
                {
                    totalSum += number % 10;
                    number /= 10;
                }
                if (totalSum == 5 || totalSum == 7 || totalSum == 11)
                {
                    numberIs = true;
                }  
                Console.WriteLine("{0} -> {1}", ch, numberIs);
                totalSum = 0;
                numberIs = false;
            }
        }
    }
}

