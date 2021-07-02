using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Car> listCars = new List<Car>();
            List<Engine> listEngines = new List<Engine>();
            List<Tire[]> listTires = new List<Tire[]>();
            List<specialCar> listSpecialCars = new List<specialCar>();


            input = AddingTires(input, listTires);
            input = AddingEngines(input, listEngines);
            input = AddingCars(input, listCars, listEngines, listTires);

            for (int i = 0; i < listCars.Count; i++)
            {
                string currCarMake = listCars[i].Make;
                string currCarModel = listCars[i].Model;
                int currCarYear = listCars[i].Year;
                double currCarQuantity = listCars[i].FuelQuantity;
                double currCarConsumption = listCars[i].FuelConsumption;
                Engine currEngine = listCars[i].Engine;
                int horsePower = currEngine.HorsePower;
                Tire[] currTires = listCars[i].Tires;

                double pressureSum = 0;

                for (int j = 0; j < currTires.Length; j++)
                {
                    pressureSum += currTires[j].Pressure;
                }

                if (currCarYear >= 2017 && horsePower >= 330 && pressureSum >= 9 && pressureSum <= 10)
                {
                    currCarQuantity -= 0.2 * currCarConsumption;

                    specialCar specialCar = new specialCar(currCarMake, currCarModel, currCarYear, currEngine, currCarQuantity);
                    listSpecialCars.Add(specialCar);
                }
            }

            foreach (var specialCar in listSpecialCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }

        }

        private static string AddingCars(string input, List<Car> listCars, List<Engine> listEngines, List<Tire[]> listTires)
        {
            input = Console.ReadLine();
            while (input != "Show special")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carMake = tokens[0];
                string carModel = tokens[1];
                int carYear = int.Parse(tokens[2]);
                double carFuelQuantity = double.Parse(tokens[3]);
                double carFuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                Car car = new Car(carMake, carModel, carYear, carFuelQuantity, carFuelConsumption, listEngines[engineIndex], listTires[tiresIndex]);

                listCars.Add(car);

                input = Console.ReadLine();
            }

            return input;
        }

        private static string AddingEngines(string input, List<Engine> listEngines)
        {
            input = Console.ReadLine();
            while (input != "Engines done")
            {
                double[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                Engine engine = new Engine((int)tokens[0], tokens[1]);

                listEngines.Add(engine);

                input = Console.ReadLine();
            }

            return input;
        }

        private static string AddingTires(string input, List<Tire[]> listTires)
        {
            while (input != "No more tires")
            {
                double[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();



                Tire[] tires = new Tire[4]
                {
                new Tire((int)tokens[0], tokens[1]),
                new Tire((int)tokens[2], tokens[3]),
                new Tire((int)tokens[4], tokens[5]),
                new Tire((int)tokens[6], tokens[7])
                };

                listTires.Add(tires);

                input = Console.ReadLine();
            }

            return input;
        }
    }
}