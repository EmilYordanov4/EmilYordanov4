using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string[] commands = Console.ReadLine().Split(" - ");
            while (commands[0] != "Craft!")
            {
                Commands(items, commands);
                commands = Console.ReadLine().Split(" - ");
            }
            Console.WriteLine(string.Join(", ", items));
        }

        private static void Commands(List<string> items, string[] commands)
        {
            if (commands[0] == "Collect")
            {
                Collect(items, commands);
            }
            else if (commands[0] == "Drop")
            {
                Drop(items, commands);
            }
            else if (commands[0] == "Combine Items")
            {
                Combining(items, commands);
            }
            else if (commands[0] == "Renew")
            {
                Renew(items, commands);
            }
        }

        private static void Renew(List<string> items, string[] commands)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == commands[1])
                {
                    items.RemoveAt(i);
                    items.Add(commands[1]);
                }
            }
        }

        private static void Combining(List<string> items, string[] commands)
        {
            string[] itemsCombining = commands[1].Split(":");
            string oldItem = itemsCombining[0];
            string newItem = itemsCombining[1];

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == oldItem)
                {
                    items.Insert(i + 1, newItem);
                    break;
                }
            }
        }

        private static void Drop(List<string> items, string[] commands)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == commands[1])
                {
                    items.RemoveAt(i);
                }
            }
        }

        private static void Collect(List<string> items, string[] commands)
        {
            bool isInInventory = false;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == commands[1])
                {
                    isInInventory = true;
                    break;
                }
            }
            if (isInInventory == false)
            {
                items.Add(commands[1]);
            }
        }
    }
}
