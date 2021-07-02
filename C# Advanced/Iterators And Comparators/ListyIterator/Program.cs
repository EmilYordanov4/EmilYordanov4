using System;
using System.Linq;

namespace ListyIteratorProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> newList = new ListyIterator<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                try
                {
                    string[] tokens = input.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries);
                    if (tokens[0] == "Create")
                    {
                        if (tokens.Length > 1)
                        {
                            newList.Create(tokens[1].Split(" "));
                        }
                    }
                    else if (tokens[0] == "Move")
                    {
                        Console.WriteLine(newList.Move());
                    }
                    else if (tokens[0] == "HasNext")
                    {
                        Console.WriteLine(newList.HasNext());
                    }
                    else if (tokens[0] == "Print")
                    {
                        newList.Print();
                    }
                    else if (tokens[0] == "PrintAll")
                    {
                        foreach (string item in newList)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }


                    input = Console.ReadLine();
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                    input = Console.ReadLine();
                }
            }

        }
    }
}
