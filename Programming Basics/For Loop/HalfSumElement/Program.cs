using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            int minValue = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= minValue)
                {
                    minValue = number;
                }
                sum += number;

            }

            if (sum - minValue == minValue)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {minValue}");
            }
            else
            {
                int result = sum - minValue;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(result - minValue)}");
            }
        }
    }
}
