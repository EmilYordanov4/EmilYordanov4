using System;
using System.Collections.Generic;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = tokens[0];
                int carEngineSpeed = int.Parse(tokens[1]);
                int carEnginePower = int.Parse(tokens[2]);
                int carCargoWeight = int.Parse(tokens[3]);
                string carCargoType = tokens[4];
                double tireOnePressure = double.Parse(tokens[5]);
                int tireOneAge = int.Parse(tokens[6]);
                double tireTwoPressure = double.Parse(tokens[7]);
                int tireTwoAge = int.Parse(tokens[8]);
                double tireThreePressure = double.Parse(tokens[9]);
                int tireThreeAge = int.Parse(tokens[10]);
                double tireFourPressure = double.Parse(tokens[11]);
                int tireFourAge = int.Parse(tokens[12]);

                Engine newEngine = new Engine(carEngineSpeed, carEnginePower);
                Cargo newCargo = new Cargo(carCargoWeight, carCargoType);

                Tire[] tires = new Tire[4]    
                {
                   new Tire(tireOnePressure, tireOneAge),
                   new Tire(tireTwoPressure, tireTwoAge),
                   new Tire(tireThreePressure, tireThreeAge),
                   new Tire(tireFourPressure, tireFourAge)
                };

                Car newCar = new Car(carModel, newEngine, newCargo, tires);

                allCars.Add(newCar);
            }
            string typeOfCargoNeeded = Console.ReadLine();
            foreach (var item in allCars)
            {
                if (typeOfCargoNeeded == "fragile" && item.Cargo.CargoType == typeOfCargoNeeded)
                {
                    for (int i = 0; i < item.Tires.Length; i++)
                    {
                        if (item.Tires[i].TirePressure < 1)
                        {
                            Console.WriteLine(item.Model);
                            break;
                        }
                    }
                }
                else if (typeOfCargoNeeded == "flamable" && item.Cargo.CargoType == typeOfCargoNeeded)
                {
                    if (item.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}
