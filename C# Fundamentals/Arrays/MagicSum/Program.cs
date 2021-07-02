using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int arrNumber = arr[i];
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arrNumber + arr[k] == magicNumber)
                    {
                        Console.WriteLine($"{arrNumber} {arr[k]}");
                    }
                }
            }
        }
    }
}
