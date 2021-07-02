using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[arrayOfNumbers.Length - 1];


            if (arrayOfNumbers.Length == 1)
            {
                Console.WriteLine(arrayOfNumbers[0]);
                return;

            }
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = arrayOfNumbers[j] + arrayOfNumbers[j + 1];
                }
                arrayOfNumbers = condensed;
            }
            Console.WriteLine(condensed[0]);
        }
    }
}

//for (int i = 0; i < arrayOfNumbers.Length; i++)
//{
//
//}