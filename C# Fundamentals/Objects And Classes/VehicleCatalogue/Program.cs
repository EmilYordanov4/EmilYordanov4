using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            List<Car> allCars = new List<Car>();
            List<Truck> allTrucks = new List<Truck>();
            while (input[0] != "End")
            {
                if (input[0] == "car")
                {
                    Car newCar = new Car();
                    newCar.Model = input[1];
                    newCar.Color = input[2];
                    newCar.Horsepower = double.Parse(input[3]);

                    allCars.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck();
                    newTruck.Model = input[1];
                    newTruck.Color = input[2];
                    newTruck.Horsepower = double.Parse(input[3]);

                    allTrucks.Add(newTruck);
                }
                input = Console.ReadLine().Split(" ");
            }
            string neededVehicle = Console.ReadLine();
            while (neededVehicle != "Close the Catalogue")
            {
                for (int i = 0; i < allTrucks.Count; i++)
                {
                    if (allTrucks[i].Model.Contains(neededVehicle))
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {allTrucks[i].Model}");
                        Console.WriteLine($"Color: {allTrucks[i].Color}");
                        Console.WriteLine($"Horsepower: {allTrucks[i].Horsepower}");
                    }
                }
                for (int i = 0; i < allCars.Count; i++)
                {
                    if (allCars[i].Model.Contains(neededVehicle))
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {allCars[i].Model}");
                        Console.WriteLine($"Color: {allCars[i].Color}");
                        Console.WriteLine($"Horsepower: {allCars[i].Horsepower}");
                    }
                }

                neededVehicle = Console.ReadLine();
            }
            if (allCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {allCars.Sum(x => x.Horsepower) / allCars.Count:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}");
            }
            if (allTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {allTrucks.Sum(x => x.Horsepower) / allTrucks.Count:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}");
            }
        }
    }
}
class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public double Horsepower { get; set; }
}
class Truck
{
    public string Model { get; set; }
    public string Color { get; set; }
    public double Horsepower { get; set; }
}
