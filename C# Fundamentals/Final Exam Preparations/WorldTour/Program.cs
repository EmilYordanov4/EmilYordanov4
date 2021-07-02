using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string[] cmds = Console.ReadLine().Split(":");

            while (cmds[0] != "Travel")
            {
                string action = cmds[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(cmds[1]);
                    string destination = cmds[2];

                    if (index >= 0 || index < stops.Length)
                    {
                        stops = stops.Insert(index, destination);
                    }
                    else
                    {
                    }
                    Console.WriteLine(stops);
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(cmds[1]);
                    int endIndex = int.Parse(cmds[2]);
                    int removeIndex = endIndex - startIndex + 1;
                    if (startIndex >= 0 && startIndex < stops.Length && endIndex >= 0 && endIndex < stops.Length && removeIndex >= 0)
                    {
                        stops = stops.Remove(startIndex, removeIndex);
                    }
                    Console.WriteLine(stops);
                }
                else if (action == "Switch")
                {
                    string oldString = cmds[1];
                    string newString = cmds[2];

                    stops = stops.Replace(oldString, newString);

                    Console.WriteLine(stops);
                }
                cmds = Console.ReadLine().Split(":");
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
