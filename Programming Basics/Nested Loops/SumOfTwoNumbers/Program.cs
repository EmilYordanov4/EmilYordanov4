using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool flag = false;
            int steps = 0;

            for (int i = start; i <= end; i++)
            {
                for (int k = start; k <= end; k++)
                {
                    steps++;
                    int sum = i + k;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{steps} ({i} + {k} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{steps} combinations - neither equals {magicNumber}");
            }
        }
    }
}
