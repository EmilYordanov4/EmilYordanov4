using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                if (IsSumDivisibleByEight(i) && IsHoldingAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }

            }

        }
        static bool IsSumDivisibleByEight(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsHoldingAtLeastOneOddDigit(int number)
        {
            while (number != 0)
            {
                int testNum = number % 10;
                if (testNum % 2 == 0)
                {

                }
                else
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
