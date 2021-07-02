using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();
            string[] info = Console.ReadLine().Split(", ");
            while (info[0] != "END")
            {
                string direction = info[0];
                string carNumber = info[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else
                {
                    parkingLot.Remove(carNumber);
                }


                info = Console.ReadLine().Split(", ");
            }
            if (parkingLot.Count > 0)
            {
                foreach (string item in parkingLot)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}
