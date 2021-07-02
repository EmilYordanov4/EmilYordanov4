using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] platesInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int onePlate = 0;
            int oneWave = 0;

            Queue<int> plates = new Queue<int>(platesInfo);
            Stack<int> wave = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            for (int i = 1; i <= n; i++)
            {
                if (wave.Count == 0)
                {
                    wave = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
                }
                if (i % 3 == 0 && i != 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                if (onePlate == 0)
                {
                    onePlate = plates.Peek();
                }
                if (oneWave == 0)
                {
                    oneWave = wave.Peek();
                }
                while (plates.Count != 0 && wave.Count != 0)
                {

                    if (oneWave > onePlate)
                    {
                        oneWave -= onePlate;

                        List<int> tempList = wave.ToList();
                        tempList[0] -= onePlate;
                        tempList.Reverse();
                        wave.Clear();
                        for (int j = 0; j < tempList.Count; j++)
                        {
                            wave.Push(tempList[j]);
                        }


                        plates.Dequeue();
                        if (plates.Count > 0)
                        {
                            onePlate = plates.Peek();
                        }
                    }
                    else if (oneWave < onePlate)
                    {
                        onePlate -= oneWave;
                        wave.Pop();

                        List<int> tempList = plates.ToList();
                        tempList[0] -= oneWave;
                        plates.Clear();
                        for (int j = 0; j < tempList.Count; j++)
                        {
                            plates.Enqueue(tempList[j]);
                        }
                        
                        if (wave.Count > 0)
                        {
                            oneWave = wave.Peek();
                        }
                    }
                    else if (oneWave == onePlate)
                    {
                        wave.Pop();
                        plates.Dequeue();
                        oneWave = 0;
                        onePlate = 0;
                        
                        if (wave.Count > 0)
                        {
                            oneWave = wave.Peek();
                        }
                        if (plates.Count > 0)
                        {
                            onePlate = plates.Peek();
                        }
                    }
                }

            }

            if (plates.Count <= 0)
            {
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                if (wave.Count > 0)
                {
                    Console.WriteLine($"Orcs left: {string.Join(", ", wave)}");
                }
            }
            else if (wave.Count <= 0)
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                if (plates.Count > 0)
                {
                    Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
                }
            }
        }
    }
}
