using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int k = 0; k <= n; k++)
                {
                    for (int l = 0; l <= n; l++)
                    {
                        if (i + k + l == n)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
