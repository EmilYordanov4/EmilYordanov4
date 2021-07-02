using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();


            while (command != "END")
            {
                int intNumber = 0;
                float floatingNumber = 0;
                char charactersType = ' ';
                bool booleanType = false;

                bool integer = Int32.TryParse(command, out intNumber);
                bool floatingPoint = float.TryParse(command, out floatingNumber);
                bool characters = char.TryParse(command, out charactersType);
                bool boolean = bool.TryParse(command, out booleanType);


                if (integer)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (floatingPoint)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (characters)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (boolean)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }

                command = Console.ReadLine();
            }
        }
    }
}
