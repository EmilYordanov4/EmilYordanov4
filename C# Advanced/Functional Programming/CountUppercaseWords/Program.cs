using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<char, bool> isFirstLetterUppercase = str => char.IsUpper(str);
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => isFirstLetterUppercase(x[0]))
                .ToArray();
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
