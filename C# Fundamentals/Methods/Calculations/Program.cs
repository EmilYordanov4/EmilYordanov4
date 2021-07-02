using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string methodType = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (methodType == "add")
            {
                Console.WriteLine(Add(firstNum, secondNum));
            }
            else if (methodType == "multiply")
            {
                Console.WriteLine(Multiply(firstNum, secondNum));
            }
            else if (methodType == "subtract")
            {
                Console.WriteLine(Subtract(firstNum, secondNum));
            }
            else if (methodType == "divide")
            {
                Console.WriteLine(Divide(firstNum, secondNum));
            }
        }

        static int Add(int firstNum, int secondNum) 
        {
            return firstNum + secondNum;
        }

        static int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        static int Subtract(int n, int en) 
        {
            return n - en;
        }

        static int Divide(int no, int na) 
        {
            return no / na;
        }
    }
}
