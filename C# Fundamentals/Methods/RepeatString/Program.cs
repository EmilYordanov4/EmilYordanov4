using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(input, repeatCount));

            static string RepeatedString(string input, int repeatCount) 
            {
                string endResult = string.Empty;
                for (int i = 0; i < repeatCount; i++)
                {
                    endResult += input;
                }
                return endResult;
            }
        }
    }
}
