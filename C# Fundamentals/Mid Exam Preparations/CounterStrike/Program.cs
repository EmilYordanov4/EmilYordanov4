using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingEnergy = int.Parse(Console.ReadLine());
            int count = 0;
            string energyConsumed = Console.ReadLine();
            bool isOutOfEnergy = false;
            while (energyConsumed != "End of battle")
            {
                int neededEnergy = int.Parse(energyConsumed);
                if (startingEnergy < neededEnergy)
                {
                    isOutOfEnergy = true;
                    break;
                }
                count++;
                if (count % 3 == 0)
                {
                    startingEnergy += count;
                }
                startingEnergy -= neededEnergy;

                energyConsumed = Console.ReadLine();
            }
            if (isOutOfEnergy == true)
            {
                Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {startingEnergy} energy");
            }
            else
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {startingEnergy}");
            }
        }
    }
}
