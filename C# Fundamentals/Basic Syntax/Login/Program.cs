using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string rightPass = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                rightPass += username[i];
            }

            string password = Console.ReadLine();
            int count = 0;

            while (password != rightPass && count < 3 )
            {
                Console.WriteLine($"Incorrect password. Try again.");
                count++;
                password = Console.ReadLine();
            }
            if (password == rightPass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else if (count >= 3)
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}