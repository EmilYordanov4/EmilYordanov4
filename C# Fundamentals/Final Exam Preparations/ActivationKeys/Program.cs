using System;
using System.Collections.Generic;
using System.Linq;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> inputAsChars = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                inputAsChars.Add(input[i]);
            }

            string[] command = Console.ReadLine().Split(">>>");
            while (command[0] != "Generate")
            {
                string typeOfAction = command[0];


                if (typeOfAction == "Contains")
                {
                    Contains(inputAsChars, command);
                }
                else if (typeOfAction == "Flip")
                {
                    Flip(inputAsChars, command);
                }
                else if (typeOfAction == "Slice")
                {
                    Slice(inputAsChars, command);
                }
                command = Console.ReadLine().Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {string.Join("", inputAsChars)}");
        }

        private static void Slice(List<char> inputAsChars, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);
            int index = startIndex;

            for (int i = startIndex; i < endIndex; i++)
            {
                inputAsChars.RemoveAt(index);
            }
            Console.WriteLine($"{string.Join("", inputAsChars)}");
        }

        private static void Flip(List<char> inputAsChars, string[] command)
        {
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);

            if (command[1] == "Upper")
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    char letterToUpper = inputAsChars[i];
                    inputAsChars[i] = char.ToUpper(letterToUpper);
                }
            }
            else
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    char letterToLower = inputAsChars[i];
                    inputAsChars[i] = char.ToLower(letterToLower);
                }
            }
            Console.WriteLine($"{string.Join("", inputAsChars)}");
        }

        private static void Contains(List<char> inputAsChars, string[] command)
        {
            string elementToContain = command[1];
            string keyAsString = string.Join("", inputAsChars);

            if (keyAsString.Contains(elementToContain))
            {
                Console.WriteLine($"{keyAsString} contains {elementToContain}");
            }
            else
            {
                Console.WriteLine($"Substring not found!");
            }
        }
    }
}
