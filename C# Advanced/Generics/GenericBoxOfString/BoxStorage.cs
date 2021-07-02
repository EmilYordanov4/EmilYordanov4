using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class BoxStorage<T> where T : IComparable
    {
        public List<Box<T>> Storage { get; set; }

        public BoxStorage()
        {
            this.Storage = new List<Box<T>>();
        }

        public void AddElement(Box<T> element) 
        {
            Storage.Add(element);
        }

        public void SwappingElements(int firstIndex, int secondIndex) 
        {
            Box<T> temp = Storage[firstIndex];
            Storage[firstIndex] = Storage[secondIndex];
            Storage[secondIndex] = temp;

            //foreach (var item in Storage)
            //{
            //    Console.WriteLine(item.ToString());
            //}
        }

        public int ComparisonByValue(T valueToCompare)
        {
            int count = 0;

            foreach (Box<T> item in Storage)
            {
                int result = valueToCompare.CompareTo(item.Value);
                if (result == -1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
