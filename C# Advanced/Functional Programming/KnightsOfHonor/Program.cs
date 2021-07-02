using System;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printingKnights = s => Console.WriteLine($"Sir {string.Join(Environment.NewLine + "Sir ", s)}");
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            printingKnights(names);
        }
    }
}
