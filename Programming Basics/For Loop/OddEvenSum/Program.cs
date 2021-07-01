using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    leftSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    rightSum += int.Parse(Console.ReadLine());
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {leftSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
