using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            // 51 47 32 61 21
            // 2


            for (int i = 0; i < n; i++)
            {
                string temp = inputArr[0];

                for (int k = 0; k < inputArr.Length - 1; k++)
                {
                    inputArr[k] = inputArr[k + 1];
                }
                inputArr[inputArr.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", inputArr));
        }
    }
}
