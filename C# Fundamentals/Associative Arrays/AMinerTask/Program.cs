using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> recources = new Dictionary<string, int>();

            while (true)
            {
                string recourceName = Console.ReadLine();
                if (recourceName == "stop")
                {
                    break;
                }
                int recourceQuantity = int.Parse(Console.ReadLine());

                if (!recources.ContainsKey(recourceName))
                {
                    recources[recourceName] = 0;
                }

                recources[recourceName] += recourceQuantity;
            }

            foreach (var item in recources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
