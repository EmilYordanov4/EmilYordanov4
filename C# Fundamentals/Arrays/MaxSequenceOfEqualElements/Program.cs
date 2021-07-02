using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            int count = 0;
            int currentIndex = 0;
            int bestCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int number = int.Parse(arr[i]);

                for (int k = i; k < arr.Length; k++)
                {
                    int testNumber = int.Parse(arr[k]);
                    if (number == testNumber)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    currentIndex = i;
                }
                count = 0;
            }
            string longestNumber = string.Empty;
            for (int i = currentIndex; i < currentIndex + bestCount; i++)
            {
                longestNumber += arr[i] + " ";
            }
            Console.WriteLine(longestNumber);
        }
    }
}
