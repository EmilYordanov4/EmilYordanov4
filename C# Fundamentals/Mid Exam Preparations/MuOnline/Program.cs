using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            bool isDead = false;
            int count = 0;

            string[] allRooms = Console.ReadLine().Split("|");

            for (int i = 0; i < allRooms.Length; i++)
            {
                count++;
                string[] room = allRooms[i].Split(" ");
                int amount = int.Parse(room[1]);
                if (room[0] == "potion")
                {
                    health = Healing(health, amount);
                }
                else if (room[0] == "chest")
                {
                    bitcoins = Chest(bitcoins, amount);
                }
                else
                {
                    health -= amount;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {room[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {room[0]}.");
                        isDead = true;
                        break;
                    }
                }
            }

            if (isDead == true)
            {
                Console.WriteLine($"Best room: {count}");
            }
            else
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }

        private static int Chest(int bitcoins, int amount)
        {
            bitcoins += amount;
            Console.WriteLine($"You found {amount} bitcoins.");
            return bitcoins;
        }

        private static int Healing(int health, int amount)
        {
            if (health + amount > 100)
            {
                Console.WriteLine($"You healed for {100 - health} hp.");
                health = 100;
                Console.WriteLine($"Current health: {health} hp.");
            }
            else
            {
                health += amount;
                Console.WriteLine($"You healed for {amount} hp.");
                Console.WriteLine($"Current health: {health} hp.");
            }

            return health;
        }
    }
}
