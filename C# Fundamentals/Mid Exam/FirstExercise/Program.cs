using System;

namespace FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double biscuitsPerWorker = double.Parse(Console.ReadLine());
            double countOfWorkers = double.Parse(Console.ReadLine());
            double competingFactory = double.Parse(Console.ReadLine());

            double totalBiscuits = 0;

            for (int i = 0; i < 30; i++)
            {
                if (i % 3 == 0)
                {
                    double discount = Math.Floor(biscuitsPerWorker * countOfWorkers * 0.75);
                    totalBiscuits += discount;
                }
                else
                {
                    totalBiscuits += biscuitsPerWorker * countOfWorkers;

                }
            }

            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
            double percentageDifference = 0;
            if (totalBiscuits > competingFactory)
            {
                percentageDifference = ((totalBiscuits - competingFactory) / competingFactory) * 100;
                Console.WriteLine($"You produce {percentageDifference:f2} percent more biscuits.");
            }
            else
            {
                percentageDifference = ((competingFactory - totalBiscuits) / competingFactory) * 100;
                Console.WriteLine($"You produce {percentageDifference:f2} percent less biscuits.");
            }
        }
    }
}
