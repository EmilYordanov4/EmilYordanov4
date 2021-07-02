using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;
        private int capacity;

        public Clinic(int capacity)
        {
            this.data = new List<Pet>();
            this.Capacity = capacity;
        }

        public void Add(Pet pet)
        {
            if (Count < this.Capacity)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            bool isRemoved = false;
            foreach (var item in data)
            {
                if (item.Name == name)
                {
                    data.Remove(item);
                    isRemoved = true;
                    break;
                }
            }

            return isRemoved;
        }

        public Pet GetPet(string name, string owner)
        {
            foreach (var item in data)
            {
                if (item.Name == name && item.Owner == owner)
                {
                    return item;
                }
            }

            return null;
        }

        public Pet GetOldestPet()
        {
            int maxAge = int.MinValue;
            var randomPet = new Pet(null, 0, null);
            for (int i = 0; i < Count; i++)
            {
                if (data[i].Age > maxAge)
                {
                    maxAge = data[i].Age;
                    randomPet = data[i];
                }
            }

            return randomPet;

            //foreach (var item in data)
            //{
            //    if (maxAge == item.Age)
            //    {
            //        return item;
            //    }
            //}

        }

        public string GetStatistics() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");
            foreach (var item in data)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }

            return sb.ToString().Trim();
        }

        public int Count => data.Count;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

    }
}
