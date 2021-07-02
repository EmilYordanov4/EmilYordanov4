using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            string result = string.Empty;
            bool isBigger = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int number = int.Parse(arr[i]);
                for (int k = i + 1; k < arr.Length; k++)
                {
                    int numberTwo = int.Parse(arr[k]);
                    if (number > numberTwo)
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger == true)
                {
                    result += arr[i] + " ";
                }
                isBigger = true;
            }
            Console.WriteLine(result);
        }
    }
}
