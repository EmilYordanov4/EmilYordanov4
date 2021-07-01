using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string passProfile = Console.ReadLine();

            string pass = Console.ReadLine();

            while (pass != passProfile)
            {
                pass = Console.ReadLine();

            }
            if (pass == passProfile)
            {
                Console.WriteLine($"Welcome {name}!");
                Environment.Exit(0);
            }
        }
    }
}
