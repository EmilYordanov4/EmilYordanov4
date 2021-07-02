using System;

namespace Problem_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] cmds = Console.ReadLine().Split();

            while (cmds[0] != "Done")
            {
                string action = cmds[0];

                if (action == "Change")
                {
                    input = ChangingChars(input, cmds);
                }
                else if (action == "Includes")
                {
                    IncludingString(input, cmds);
                }
                else if (action == "End")
                {
                    string endingString = cmds[1];

                    if (input.EndsWith(endingString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "Uppercase")
                {
                    input = input.ToUpper();

                    Console.WriteLine(input);
                }
                else if (action == "FindIndex")
                {
                    FindingIndex(input, cmds);
                }
                else if (action == "Cut")
                {
                    int startingIndex = int.Parse(cmds[1]);
                    int length = int.Parse(cmds[2]);

                    input = input.Substring(startingIndex, length);

                    Console.WriteLine(input);
                }
                cmds = Console.ReadLine().Split();
            }
        }

        private static void FindingIndex(string input, string[] cmds)
        {
            char neededChar = char.Parse(cmds[1]);

            int indexOfChar = input.IndexOf(neededChar);

            Console.WriteLine(indexOfChar);
        }

        private static void IncludingString(string input, string[] cmds)
        {
            string stringToInclude = cmds[1];

            if (input.Contains(stringToInclude))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static string ChangingChars(string input, string[] cmds)
        {
            char oldChar = char.Parse(cmds[1]);
            char newChar = char.Parse(cmds[2]);

            input = input.Replace(oldChar, newChar);

            Console.WriteLine(input);
            return input;
        }
    }
}
