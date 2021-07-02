using System;

namespace TestingTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", 4, StringSplitOptions.RemoveEmptyEntries);
            string name = $"{input[0]} {input[1]}";
            TTuple<string, string> firstOutput = new TTuple<string, string>(name, input[2]);

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //bool isDrunk = false;
            //if (input[2] == "drunk")
            //{
            //    isDrunk = true;
            //}

            TTuple<string, int> secondOutput = new TTuple<string, int>(input[0], int.Parse(input[1]));

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            TTuple<string, double> thirdOutput = new TTuple<string, double>(input[0], double.Parse(input[1]));

            Console.WriteLine(firstOutput.ToString());
            Console.WriteLine(secondOutput.ToString());
            Console.WriteLine(thirdOutput.ToString());

        }
    }
}
