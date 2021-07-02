using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            DecideType(type);

            static void DecideType(string type) 
            {
                if (type == "int")
                {
                    int numberOne = int.Parse(Console.ReadLine());
                    int numberTwo = int.Parse(Console.ReadLine());
                    GreaterInt(numberOne, numberTwo); 
                }
                else if (type == "string")
                {
                    string inputOne = Console.ReadLine();
                    string inputTwo = Console.ReadLine();
                    GreaterString(inputOne, inputTwo);
                }
                else if (type == "char")
                {
                    char inputOne = char.Parse(Console.ReadLine());
                    char inputTwo = char.Parse(Console.ReadLine());
                    GreaterChar(inputOne, inputTwo);
                }
            }

            static void GreaterInt(int numberOne, int numberTwo)
            {
                if (numberOne > numberTwo)
                {
                    Console.WriteLine(numberOne);
                }
                else
                {
                    Console.WriteLine(numberTwo);
                }
            }

            static void GreaterString(string inputOne, string inputTwo) 
            {
                String.Compare(inputTwo, inputOne);
                if (String.Compare(inputTwo, inputOne) == 1)
                {
                    Console.WriteLine(inputTwo);
                }
                else
                {
                    Console.WriteLine(inputOne);
                }
            }

            static void GreaterChar(int inputOne, int inputTwo)
            {
                if (inputOne > inputTwo)
                {
                    Console.WriteLine((char)inputOne);
                }
                else
                {
                    Console.WriteLine((char)inputTwo);
                }
            }
        }
    }
}
