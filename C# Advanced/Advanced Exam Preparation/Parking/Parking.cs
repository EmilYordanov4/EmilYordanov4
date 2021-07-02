using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;
        private string type;
        private int capacity;

        public Parking(string type, int capacity)
        {
            this.data = new List<Car>();
            this.Type = type;
            this.Capacity = capacity;
        }

        public void Add(Car car)
        {
            if (this.Count < capacity)
            {
                this.data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            bool isRemoved = false;

            for (int i = 0; i < this.Count; i++)
            {
                if (data[i].Manufacturer == manufacturer && data[i].Model == model)
                {
                    data.Remove(data[i]);
                    isRemoved = true;
                }
            }
            return isRemoved;
        }

        public Car GetLatestCar()
        {
            Car tempCar = new Car(null, null, 0);
            int year = int.MinValue;
            if (this.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (var item in data)
                {
                    if (item.Year > year)
                    {
                        year = item.Year;
                        tempCar = item;
                    }
                }
            }
            return tempCar;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car tempCar = new Car(null, null, 0);
            bool isFound = false;
            foreach (var item in data)
            {
                if (item.Manufacturer == manufacturer && item.Model == model)
                {
                    tempCar = item;
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                return tempCar;
            }
            else
            {
                return null;
            }
        }

        public string GetStatistics() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }

        public int Count => data.Count;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
