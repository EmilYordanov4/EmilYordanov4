using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arrOne = new string[n];
            string[] arrTwo = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split().ToArray();

                if (i % 2 == 0)
                {
                    arrOne[i] = inputArr[0];
                    arrTwo[i] = inputArr[1];
                }
                else
                {
                    arrOne[i] = inputArr[1];
                    arrTwo[i] = inputArr[0];
                }
            }
            Console.WriteLine(string.Join(" ",arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));
        }
    }
}
