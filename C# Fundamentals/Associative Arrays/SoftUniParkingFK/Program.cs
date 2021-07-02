using System;
using System.Collections.Generic;

namespace SoftUniParkingFK
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string user = input[1];
                if (type == "register")
                {
                    string plateNumber = input[2];

                    if (registeredUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                    else
                    {
                        registeredUsers[user] = plateNumber;
                        Console.WriteLine($"{user} registered {plateNumber} successfully");
                    }

                }
                else if (type == "unregister")
                {
                    if (!registeredUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }

            foreach (var item in registeredUsers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
