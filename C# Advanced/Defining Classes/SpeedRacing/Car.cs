using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer) 
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        public static void Drive(Car car, double amountOfKm) 
        {
            double totalFuelNeeded = car.FuelConsumptionPerKilometer * amountOfKm;

            if (totalFuelNeeded > car.FuelAmount)
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                car.TravelledDistance += amountOfKm;
                car.FuelAmount -= totalFuelNeeded;  
            }
        }
    }
}
