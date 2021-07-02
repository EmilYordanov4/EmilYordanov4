using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int balance = int.Parse(Console.ReadLine());

            int bulletCount = sizeOfGunBarrel;

            Stack<int> bullets = new Stack<int>(bulletsInfo);
            Queue<int> locks = new Queue<int>(locksInfo);

            while (bullets.Count != 0 && locks.Count != 0)
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                if (currentBullet <= currentLock)
                {
                    locks.Dequeue();
                    Console.WriteLine($"Bang!");
                }
                else
                {
                    Console.WriteLine($"Ping!");
                }
                balance -= bulletPrice;
                bulletCount--;
                if (bulletCount == 0 && bullets.Count != 0)
                {
                    bulletCount = sizeOfGunBarrel;
                    Console.WriteLine($"Reloading!");
                }
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${balance}");
            }
            else 
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
