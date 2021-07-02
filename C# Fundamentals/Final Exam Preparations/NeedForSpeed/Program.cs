using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> carMileage = new Dictionary<string, int>();
            Dictionary<string, int> carFuel = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|");

                string name = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                carMileage.Add(name, mileage);
                carFuel.Add(name, fuel);
            }

            string[] cmds = Console.ReadLine().Split(" : ");

            while (cmds[0] != "Stop")
            {
                string typeOfCmd = cmds[0];

                if (typeOfCmd == "Drive")
                {
                    Driving(carMileage, carFuel, cmds);
                }
                else if (typeOfCmd == "Refuel")
                {
                    Refueling(carFuel, cmds);
                }
                else if (typeOfCmd == "Revert")
                {
                    Reverting(carMileage, cmds);
                }
                cmds = Console.ReadLine().Split(" : ");
            }

            carMileage = carMileage.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in carMileage)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value} kms, Fuel in the tank: {carFuel[item.Key]} lt.");
            }
        }

        private static void Reverting(Dictionary<string, int> carMileage, string[] cmds)
        {
            string name = cmds[1];
            int kilometers = int.Parse(cmds[2]);

            if (carMileage[name] - kilometers < 10000)
            {
                carMileage[name] = 10000;
            }
            else
            {
                carMileage[name] -= kilometers;
                Console.WriteLine($"{name} mileage decreased by {kilometers} kilometers");
            }
        }

        private static void Refueling(Dictionary<string, int> carFuel, string[] cmds)
        {
            string name = cmds[1];
            int fuelAdded = int.Parse(cmds[2]);

            if (carFuel[name] + fuelAdded > 75)
            {
                Console.WriteLine($"{name} refueled with {75 - carFuel[name]} liters");
                carFuel[name] = 75;
            }
            else
            {
                carFuel[name] += fuelAdded;
                Console.WriteLine($"{name} refueled with {fuelAdded} liters");
            }
        }

        private static void Driving(Dictionary<string, int> carMileage, Dictionary<string, int> carFuel, string[] cmds)
        {
            string name = cmds[1];
            int distance = int.Parse(cmds[2]);
            int fuelConsumed = int.Parse(cmds[3]);

            if (fuelConsumed > carFuel[name])
            {
                Console.WriteLine($"Not enough fuel to make that ride");
            }
            else
            {
                carFuel[name] -= fuelConsumed;
                carMileage[name] += distance;
                Console.WriteLine($"{name} driven for {distance} kilometers. {fuelConsumed} liters of fuel consumed.");
            }
            if (carMileage[name] >= 100000)
            {
                carFuel.Remove(name);
                carMileage.Remove(name);
                Console.WriteLine($"Time to sell the {name}!");
            }
        }
    }
}
