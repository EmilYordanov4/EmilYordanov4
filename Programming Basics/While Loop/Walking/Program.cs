using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsPerDay = 10000;
            string input = Console.ReadLine();
            int stepsForTheDay = 0;

            while (input != "Going home")
            {
                int steps = int.Parse(input);
                stepsForTheDay += steps;
                if (stepsForTheDay >= stepsPerDay)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{Math.Abs(stepsPerDay - stepsForTheDay)} steps over the goal!");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            int petur = int.Parse(input);
            stepsForTheDay += petur;
            if (stepsForTheDay >= stepsPerDay)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(stepsPerDay - stepsForTheDay)} steps over the goal!");
            }
            else if (stepsForTheDay < stepsPerDay)
            {
                Console.WriteLine($"{stepsPerDay - stepsForTheDay} more steps to reach goal.");

            }
        }
    }
}
