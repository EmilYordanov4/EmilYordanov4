using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isEqual = false;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                int leftSum = 0;
                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += arr[k];
                }
                if (leftSum == rightSum)
                {
                    isEqual = true;
                    index = i;
                    break;
                }
                else
                {
                    isEqual = false;
                }
            }

            if (isEqual == true)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
