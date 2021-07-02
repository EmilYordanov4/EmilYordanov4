using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printing = s => Console.WriteLine(string.Join(Environment.NewLine, s));
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            printing(names);
        }
    }
}
