using System;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "end")
            {
                char[] reverseWord = word.Reverse().ToArray();
                Console.WriteLine($"{word} = {string.Join("", reverseWord)}");
                word = Console.ReadLine();
            }
        }
    }
}
