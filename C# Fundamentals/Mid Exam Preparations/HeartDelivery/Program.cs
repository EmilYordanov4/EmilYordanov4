using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhoodSize = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            int cupidPlace = 0;
            string[] cmds = Console.ReadLine().Split(" ");

            while (cmds[0] != "Love!")
            {
                string command = cmds[0];
                int jumpSize = int.Parse(cmds[1]);

                while (jumpSize > 0)
                {
                    cupidPlace++;
                    if (cupidPlace >= neighborhoodSize.Length)
                    {
                        cupidPlace = 0;
                        break;
                    }
                    jumpSize--;
                }
                if (neighborhoodSize[cupidPlace] == 0)
                {
                    Console.WriteLine($"Place {cupidPlace} already had Valentine's day.");
                    neighborhoodSize[cupidPlace] = 0;
                }
                else if (neighborhoodSize[cupidPlace] - 2 == 0)
                {
                    Console.WriteLine($"Place {cupidPlace} has Valentine's day.");
                    neighborhoodSize[cupidPlace] = 0;
                }
                else
                {
                    neighborhoodSize[cupidPlace] -= 2;
                }

                cmds = Console.ReadLine().Split(" ");
            }
            Console.WriteLine($"Cupid's last position was {cupidPlace}.");
            int housesHavingValentinesDay = 0;
            for (int i = 0; i < neighborhoodSize.Length; i++)
            {
                if (neighborhoodSize[i] == 0)
                {
                    housesHavingValentinesDay++;
                }
            }
            if (housesHavingValentinesDay == neighborhoodSize.Length)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhoodSize.Length - housesHavingValentinesDay} places.");
            }
        }
    }
}
