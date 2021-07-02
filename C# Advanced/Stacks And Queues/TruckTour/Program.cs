using System;
using System.Collections.Generic;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isCompleted = false;
            int countNeeded = n;

            Queue<string> pumps = new Queue<string>();
            Queue<string> testPumps = new Queue<string>();
            for (int k = 0; k < n; k++)
            {
                string infoForPumps = Console.ReadLine();
                pumps.Enqueue(infoForPumps);
                testPumps.Enqueue(infoForPumps);
            }

            int truckPetrol = 0;
            int startIndex = 0;

            while (isCompleted == false)
            {

                for (int i = 0; i < n; i++)
                {
                    string[] pump = testPumps.Peek().Split(" ");
                    int pumpPetrol = int.Parse(pump[0]);
                    int pumpDistanceCost = int.Parse(pump[1]);

                    truckPetrol += pumpPetrol;

                    if (truckPetrol >= pumpDistanceCost)
                    {
                        countNeeded--;
                        truckPetrol -= pumpDistanceCost;
                        testPumps.Dequeue();
                    }
                    else
                    {
                        countNeeded = n;
                        truckPetrol = 0;
                        startIndex++;
                        break;
                    }

                }
                if (countNeeded == 0)
                {
                    isCompleted = true;
                    break;
                }
                pumps.Enqueue(pumps.Dequeue());
                string[] infoForPumps = string.Join(", ", pumps).Split(", ");
                testPumps.Clear();
                for (int i = 0; i < infoForPumps.Length; i++)
                {
                    testPumps.Enqueue(infoForPumps[i]);
                }
                
            }
            Console.WriteLine(startIndex);
        }
    }
}
