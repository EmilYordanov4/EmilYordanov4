using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int personsElevatedPerRun = int.Parse(Console.ReadLine());

            int course = (int)Math.Ceiling((double)persons / personsElevatedPerRun);

            Console.WriteLine($"{course}");

        }
    }
}
