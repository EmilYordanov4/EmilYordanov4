using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        private List<Car> cars;
        public List<Car> Cars { get=> cars; set=> cars = value; }
        public int Count => this.Cars.Count;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Parking(int capacity)
        {
            this.Cars = new List<Car>(capacity);
            this.Capacity = capacity;
        }
        public string AddCar(Car car)
        {

            if (this.Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return $"Car with that registration number, already exists!";
            }
            else if (Cars.Count == this.Capacity)
            {
                return $"Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber) 
        {
            if (Cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                Cars = Cars.Where(x => x.RegistrationNumber != registrationNumber).ToList();
                
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return $"Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber) 
        {
            return Cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers) 
        {
            foreach (var item in RegistrationNumbers)
            {
                if (Cars.Any(x => x.RegistrationNumber == item))
                {
                    Car foundCar = this.Cars.First(c => c.RegistrationNumber == item);
                    Cars.Remove(foundCar);
                }
            }
        }

        
    }
}
