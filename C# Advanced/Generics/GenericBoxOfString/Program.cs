using System;
using System.Linq;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BoxStorage<string> newStorage = new BoxStorage<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<string> value = new Box<string>(input);
                newStorage.AddElement(value);
            }

            string valueToCompare = Console.ReadLine();
            

            int count = newStorage.ComparisonByValue(valueToCompare);
            Console.WriteLine(count);
        }
    }
}
