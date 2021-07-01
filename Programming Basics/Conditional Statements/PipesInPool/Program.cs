using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipeOnePulnej = pipeOne * hours;
            double pipeTwoPulnej = pipeTwo * hours;
            
            double pipePulnej = pipeOnePulnej + pipeTwoPulnej;

            if (pipePulnej <= volume )
            {
                Console.WriteLine($"The pool is {(pipePulnej / volume) *100:F2}% full. Pipe 1: {(pipeOnePulnej / pipePulnej) * 100:F2}%. Pipe 2: {(pipeTwoPulnej / pipePulnej) * 100:F2}%.");
            }
            else if (pipePulnej > volume)
            {
                Console.WriteLine($"For {hours:F2} hours the pool overflows with {pipePulnej - volume:F2} liters.");
            }
        }
    }
}
