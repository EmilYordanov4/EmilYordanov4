using System;

namespace ANDProcessors
{
    class Program
    {
        static void Main(string[] args)
        {
            int processorsNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int totalHours = workers * workDays * 8;

            double processorsMade = totalHours / 3;
            Math.Floor(processorsMade);

            if (processorsMade >= processorsNeeded)
            {
                Console.WriteLine($"Profit: -> {(processorsMade - processorsNeeded) * 110.10:F2} BGN");
            }
            else
            {
                Console.WriteLine($"Losses: -> {(processorsNeeded - processorsMade) * 110.10:F2} BGN");
            }
        }
    }
}
