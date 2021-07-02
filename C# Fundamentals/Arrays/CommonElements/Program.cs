using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split().ToArray();
            string[] arrTwo = Console.ReadLine().Split().ToArray();

            string result = string.Empty;

            for (int i = 0; i < arrTwo.Length; i++)
            {
                string word = arrTwo[i];
                for (int k = 0; k < arrOne.Length; k++)
                {
                    if (word == arrOne[k])
                    {
                        result += word + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
