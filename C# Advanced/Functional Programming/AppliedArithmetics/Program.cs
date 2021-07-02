using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> addFunc = x => x.Select(n => n + 1).ToArray();
            Func<int[], int[]> multiplyFunc = x => x.Select(n => n * 2).ToArray();
            Func<int[], int[]> subtractFunc = x => x.Select(n => n - 1).ToArray();
            Action<int[]> printFunc = x => Console.WriteLine(string.Join(" ", x));

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string cmd = Console.ReadLine();

            while (cmd != "end")
            {
                if (cmd == "add")
                {
                    numbers = addFunc(numbers);
                }
                else if (cmd == "multiply")
                {
                    numbers = multiplyFunc(numbers);
                }
                else if (cmd == "subtract")
                {
                    numbers = subtractFunc(numbers);
                }
                else if (cmd == "print")
                {
                    printFunc(numbers);
                }


                cmd = Console.ReadLine();
            }
        }
    }
}
