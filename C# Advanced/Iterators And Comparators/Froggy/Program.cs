using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Lake<int> frog = new Lake<int>(info);

            Console.WriteLine(string.Join(", ", frog));
        }
    }
}
