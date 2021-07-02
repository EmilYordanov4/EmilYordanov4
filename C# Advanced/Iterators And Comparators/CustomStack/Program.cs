using System;

namespace CustomStackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> myStack = new CustomStack<string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] info = input.Split(" ",2, StringSplitOptions.RemoveEmptyEntries);
                if (info[0] == "Push")
                {
                    string[] elements = info[1].Split(", ", StringSplitOptions.RemoveEmptyEntries); 
                    myStack.Push(elements);
                }
                else if (info[0] == "Pop")
                {
                    myStack.Pop();
                }
                input = Console.ReadLine();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
