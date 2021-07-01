using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookNeeded = Console.ReadLine();
            string bookChecked = Console.ReadLine();
            int books = 0;

            while (bookChecked != bookNeeded)
            {
                if (bookChecked == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {books} books.");
                    Environment.Exit(0);
                }
                books++;
                bookChecked = Console.ReadLine();
            }
            Console.WriteLine($"You checked {books} books and found it.");
        }
    }
}
