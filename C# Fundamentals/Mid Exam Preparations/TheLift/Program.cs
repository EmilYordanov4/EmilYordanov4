using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            peopleWaiting = FillingTheLift(peopleWaiting, lift);
            bool isEmpty = false;
            for (int i = 0; i < lift.Count; i++)
            {
                if (lift[i] == 4)
                {

                }
                else
                {
                    isEmpty = true;
                    break;
                }
            }

            if (peopleWaiting == 0 && isEmpty == false)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (peopleWaiting == 0 && isEmpty == true)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
        }

        private static int FillingTheLift(int peopleWaiting, List<int> lift)
        {
            for (int i = 0; i < lift.Count; i++)
            {
                if (peopleWaiting <= 0)
                {
                    break;
                }
                else if (lift[i] < 4)
                {
                    lift[i]++;
                    peopleWaiting--;
                    i--;
                }
            }

            return peopleWaiting;
        }
    }
}
