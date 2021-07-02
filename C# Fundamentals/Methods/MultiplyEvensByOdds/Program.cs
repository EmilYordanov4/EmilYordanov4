using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Multiply(number);
        }

        static void Multiply(int number)
        {
            int evenSum = EvenSumMethod(number);
            int oddSum = OddSumMethod(number);
            Console.WriteLine(Math.Abs(evenSum * oddSum));
        }

        static int EvenSumMethod(int number) 
        {
            int evenSum = 0;
            while (number != 0)
            {
                int decide = number % 10;
                if (decide % 2 == 0)
                {
                    evenSum += decide;
                }
                else
                {

                }
                number /= 10;
            }
            return evenSum;
        }
        
        static int OddSumMethod(int number) 
        {
            int oddSum = 0;
            while (number != 0)
            {
                int decide = number % 10;
                if (decide % 2 == 0)
                {
                    
                }
                else
                {
                    oddSum += decide;
                }
                number /= 10;
            }
            return oddSum;
        }
    }
}
