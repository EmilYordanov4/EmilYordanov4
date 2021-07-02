using System;
using System.Collections.Generic;
using System.Linq;

namespace Boms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffectInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bombCasingInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> bombEffects = new Queue<int>(bombEffectInfo);
            Stack<int> bombCasing = new Stack<int>(bombCasingInfo);

            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;

            bool isFull = false;

            while (bombEffects.Count != 0 && bombCasing.Count != 0)
            {
                int effect = bombEffects.Peek();
                int casing = bombCasing.Peek();
                int sum = effect + casing;

                if (effect == 0)
                {
                    effect = bombEffects.Peek();
                }
                if (casing == 0)
                {
                    casing = bombCasing.Peek();
                }

                if (sum == 40)
                {
                    daturaBombs++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum == 60)
                {
                    cherryBombs++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum == 120)
                {
                    smokeDecoyBombs++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else 
                {
                    List<int> temp = new List<int>(bombCasing);
                    temp[0] -= 5;
                    temp.Reverse();
                    bombCasing.Clear();

                    for (int i = 0; i < temp.Count; i++)
                    {
                        bombCasing.Push(temp[i]);
                    }
                }

                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    isFull = true;
                    break;
                }
            }

            if (isFull)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine($"Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }

            if (bombCasing.Count == 0)
            {
                Console.WriteLine($"Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");

        }
    }
}
