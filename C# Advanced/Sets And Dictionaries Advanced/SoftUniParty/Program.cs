using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reservationList = new HashSet<string>();
            HashSet<string> joining = new HashSet<string>();

            string reservation = Console.ReadLine();
            while (reservation != "PARTY")
            {
                reservationList.Add(reservation);

                reservation = Console.ReadLine();
            }
            string commingToParty = Console.ReadLine();

            while (commingToParty != "END")
            {
                joining.Add(commingToParty);


                commingToParty = Console.ReadLine();
            }

            reservationList.ExceptWith(joining);
            Console.WriteLine($"{reservationList.Count}");
            foreach (var item in reservationList)
            {
                if (char.IsDigit(item[0]))
                {
                    Console.WriteLine($"{item}");
                }
            }
            foreach (var item in reservationList)
            {
                if (!char.IsDigit(item[0]))
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
