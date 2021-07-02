using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string[] cmds = Console.ReadLine().Split(" ");
            
            while (cmds[1] != "Shopping!")
            {
                if (cmds[0] == "Urgent")
                {
                    Urgent(shoppingList, cmds);
                }
                else if (cmds[0] == "Unnecessary")
                {
                    Unnecessary(shoppingList, cmds);
                }
                else if (cmds[0] == "Correct")
                {
                    Correct(shoppingList, cmds);
                }
                else if (cmds[0] == "Rearrange")
                {
                    Rearrange(shoppingList, cmds);
                }
                cmds = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }

        private static void Rearrange(List<string> shoppingList, string[] cmds)
        {
            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (cmds[1] == shoppingList[i])
                {
                    shoppingList.Add(cmds[1]);
                    shoppingList.RemoveAt(i);
                }
            }
        }

        private static void Correct(List<string> shoppingList, string[] cmds)
        {
            string oldItem = cmds[1];
            string newItem = cmds[2];

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (oldItem == shoppingList[i])
                {
                    shoppingList[i] = newItem;
                }
            }
        }

        private static void Unnecessary(List<string> shoppingList, string[] cmds)
        {
            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (cmds[1] == shoppingList[i])
                {
                    shoppingList.RemoveAt(i);
                }
            }
        }

        private static void Urgent(List<string> shoppingList, string[] cmds)
        {
            bool ifExists = false;
            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (cmds[1] == shoppingList[i])
                {
                    ifExists = true;
                    break;
                }
            }
            if (ifExists == false)
            {
                shoppingList.Insert(0,cmds[1]);
            }
        }
    }
}
