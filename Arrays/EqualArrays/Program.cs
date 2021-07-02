using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int index = 0;
            bool equal = true;
            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    int number = int.Parse(firstArray[i]);
                    sum += number;
                }
                else
                {
                    equal = false;
                    index = i;
                }

                if (equal == false)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    break;
                }
            }
            if (equal == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
