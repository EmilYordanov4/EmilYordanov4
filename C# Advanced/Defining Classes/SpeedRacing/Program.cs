using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumpPer1km = double.Parse(input[2]);
                Car newCar = new Car(model, fuelAmount, fuelConsumpPer1km);

                allCars.Add(newCar);
            }


            string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (info[0] != "End")
            {
                string carModel = info[1];
                double amountOfKm = double.Parse(info[2]);

                for (int i = 0; i < allCars.Count; i++)
                {
                    if (allCars[i].Model == carModel)
                    {
                        Car.Drive(allCars[i], amountOfKm);
                    }

                }

                info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in allCars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }

        }
    }
}
