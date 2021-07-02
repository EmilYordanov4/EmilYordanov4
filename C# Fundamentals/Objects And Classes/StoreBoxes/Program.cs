using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Item> Items = new List<Item>();
            List<Box> Box = new List<Box>();

            while (input != "end")
            {
                string[] information = input.Split().ToArray();

                Box newBox = new Box();
                Item newItem = new Item();

                newItem.PricerPerItem = decimal.Parse(information[3]);
                newItem.ItemName = information[1];

                Items.Add(newItem);

                newBox.SerialNumber = information[0]; 
                newBox.Item = information[1]; 
                newBox.ItemQuantity = decimal.Parse(information[2]); 
                newBox.PriceForABox = newItem.PricerPerItem * newBox.ItemQuantity;
                newBox.PricePerItem = newItem.PricerPerItem;
                Box.Add(newBox);

                input = Console.ReadLine();
            }
            foreach (Box newBox in Box.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine($"{newBox.SerialNumber}");
                Console.WriteLine($"-- {newBox.Item} - ${newBox.PricePerItem:f2}: {newBox.ItemQuantity}");
                Console.WriteLine($"-- ${newBox.PriceForABox:f2}");
            }
        }
    }
}
