using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lines = byte.Parse(Console.ReadLine());

            byte countOpened = 0;
            byte countClosed = 0;

            for (byte i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    countOpened++;
                }
                if (input == ")")
                {
                    countClosed++;
                    if (countClosed - countOpened != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (countClosed == countOpened)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
